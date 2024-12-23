using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class RemoveButtonClick : MonoBehaviour
{
    private Button _button;
    private Bird _bird;
    public GameObject gameOverScreen;
    // Start is called before the first frame update
    void Start()
    {
        _bird = GameObject.Find("RedBird").GetComponent<Bird>(); 
        _button = GetComponent<Button>();
        _button.onClick.AddListener(restartButton);
    }

    // Update is called once per frame
    public void restartButton()
    {
        _bird.ResetGame();
        gameOverScreen.SetActive(false);
        SceneManager.LoadScene("SampleScene");
    }
}
