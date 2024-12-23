using UnityEngine;

public class BirdTracker : MonoBehaviour
{

    public GameObject bird;
    public float xOffset = -1;
    // public float yOffset = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(bird.transform.position.x - xOffset, transform.position.y, transform.position.z);
    }
}
