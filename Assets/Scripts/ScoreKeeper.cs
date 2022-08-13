using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public int Score = 0;

    void Start() {
        DontDestroyOnLoad(this);
    }

    public void UpdateScore(int change) {
        Score += change;
    }

    public void ResetScore() {
        Score = 0;
    }
}
