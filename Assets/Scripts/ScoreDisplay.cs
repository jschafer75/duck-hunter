using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text Display;

    void Update(){
        Display.text = FindObjectOfType<ScoreKeeper>().Score.ToString();
    }
}
