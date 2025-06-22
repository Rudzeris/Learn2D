using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button exitButton;

    private void Start()
    {
        if(startButton == null || exitButton == null)
        {
            Debug.LogError("Buttons are not assigned in the MenuManager script.");
            return;
        }
        startButton.onClick.AddListener(StartGame);
        exitButton.onClick.AddListener(ExitGame);
    }

    private void StartGame()
    {
        //SceneManager.LoadScene("PlatformerScene"); // ��������� �������� ����� ������� �������
        SceneManager.LoadScene(1);
    }

    private void ExitGame()
    {
        Application.Quit(); // �������� � ������ ����

#if UNITY_EDITOR // �������� ������ � ��������� Unity
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
