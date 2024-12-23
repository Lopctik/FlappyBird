using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class StartButtonClick : MonoBehaviour
{
    private Button _button;
    private Bird _bird;
    public GameObject startScreen;
    public TMP_Text flappyBird;
    public GameObject score;
    // Start is called before the first frame update
    void Start()
    {
        _bird = GameObject.Find("RedBird").GetComponent<Bird>(); 
        _button = GetComponent<Button>();
        _button.onClick.AddListener(StartButton);
    }

    public void StartButton()
    {
        flappyBird.text = "";
        score.SetActive(true);
        _bird.ResetGame();
        startScreen.SetActive(false);
    }
}
