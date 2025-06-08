using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] private MemoryCard original;
    public const int gridRows = 2;
    public const int gridCols = 4;
    public const float offsetX = 2f;
    public const float offsetY = 2.5f;

    [SerializeField] Sprite[] images;
    [SerializeField] TMP_Text scoreLabel;

    private MemoryCard firstRevealed;
    private MemoryCard secondRevealed;
    private int score = 0;

    void Start()
    {
        Vector3 startPos = original.transform.position;

        // create shuffled list of cards
        int[] numbers = { 0, 0, 1, 1, 2, 2, 3, 3 };
        numbers = ShuffleArray(numbers);

        // place cards in a grid
        for (int i = 0; i < gridCols; i++)
        {
            for (int j = 0; j < gridRows; j++)
            {
                MemoryCard card;

                // use the original for the first grid space
                if (i == 0 && j == 0)
                {
                    card = original;
                }
                else
                {
                    card = Instantiate(original) as MemoryCard;
                }

                // next card in the list for each grid space
                int index = j * gridCols + i;
                int id = numbers[index];
                card.SetCard(id, images[id]);

                float posX = (offsetX * i) + startPos.x;
                float posY = -(offsetY * j) + startPos.y;
                card.transform.position = new Vector3(posX, posY, startPos.z);
            }
        }
    }
            // Knuth shuffle algorithm
    private int[] ShuffleArray(int[] numbers)
    {
        int[] newArray = numbers.Clone() as int[];
        for (int i = 0; i < newArray.Length; i++)
        {
            int tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;
    }

    public void CardRevealed(MemoryCard card)
    {
        if (firstRevealed == null)
        {
            firstRevealed = card;
        }
        else
        {
            secondRevealed = card;
            StartCoroutine(CheckMatch());
        }
    }

    private IEnumerator CheckMatch()
    {

        // increment score if the cards match
        if (firstRevealed.Id == secondRevealed.Id)
        {
            score++;
            scoreLabel.text = $"Score: {score}";
        }

        // otherwise turn them back over after .5s pause
        else
        {
            yield return new WaitForSeconds(.5f);

            firstRevealed.Unreveal();
            secondRevealed.Unreveal();
        }

        firstRevealed = null;
        secondRevealed = null;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Scene");
    }
}