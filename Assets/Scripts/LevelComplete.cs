using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        // load the next level by using the current build index plus 1
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
