using UnityEngine;

public class BirdCollision : MonoBehaviour
{

    private Bird _bird;

    void Start()
    {
        _bird = GetComponent<Bird>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ScoreZone")
        {
            _bird.IncreaseScore();
        } else
        {
            _bird.Loss();
        }

    }
}
