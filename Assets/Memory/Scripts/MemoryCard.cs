using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    [SerializeField] private GameObject backCard;
    [SerializeField] SceneController controller;
    private int _id;
    public int Id
    {
        get { return _id; }
    }
    public void SetCard(int id, Sprite image)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }
    public void OnMouseDown()
    {
        if (backCard.activeSelf)
        {
            backCard.SetActive(false);
            controller.CardRevealed(this);
        }
    }

    public void Unreveal()
    {
        backCard.SetActive(true);
    }
}
