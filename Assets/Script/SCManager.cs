using UnityEngine;
using UnityEngine.SceneManagement;

public class SCManager : MonoBehaviour
{
    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
    }
    public void PlayGameButton()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
