using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private Transform _mainCamera;

    void Start()
    {
        _mainCamera = GameObject.Find("Main Camera").GetComponent<Transform>();
    }

    void Update()
    {
        if (transform.position.x <= _mainCamera.position.x - 10)
            Destroy(gameObject);
        
    }
}
