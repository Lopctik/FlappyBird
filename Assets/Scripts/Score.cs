using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public Bird bird;
    public TMP_Text scoreText;

    public void ScoreChanger(int score)
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
