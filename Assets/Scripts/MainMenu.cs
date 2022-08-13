using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string newGameScene;

    public void NewGame()
    {
        ScoreKeeper sk = FindObjectOfType<ScoreKeeper>();
        if (sk != null) {
            sk.ResetScore();
        }
        SceneManager.LoadScene(newGameScene);
    }
}
