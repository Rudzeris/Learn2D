using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Button menuButton;
    void Start()
    {
        if(menuButton == null)
        {
            Debug.LogError("Menu button is not assigned in the UIManager script.");
            return;
        }
        menuButton.onClick.AddListener(OpenMenu);
    }
    private void OpenMenu()
    {
        SceneManager.LoadScene("MenuScene"); // или индекс сцены, например, 0
    }
}
