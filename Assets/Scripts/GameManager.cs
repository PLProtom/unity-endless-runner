using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded;
    [SerializeField] private GameObject menu;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            menu.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
