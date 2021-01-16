using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("vr場景");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
