using UnityEngine;
using UnityEngine.Android;

public class Bird : MonoBehaviour
{
    public GameObject overScreen;
    private BirdMover1 _mover;
    private int _score;
    public Score scoreChanger;

    void Start()
    {
        overScreen.gameObject.SetActive(false);
        _mover = GetComponent<BirdMover1>();
        Time.timeScale = 0;  
        // ResetGame();
    }

    public void IncreaseScore()
    {
        _score++;
        scoreChanger.ScoreChanger(_score);
        // Debug.Log("You Get +1 Point");
    }

    public void ResetGame()
    {
        _score = 0;
        _mover.ResetBird();
        Time.timeScale = 1;

    }

    public void Loss()
    {
        overScreen.gameObject.SetActive(true);
        Debug.Log("You Loss");
        Time.timeScale = 0;
    }

}
