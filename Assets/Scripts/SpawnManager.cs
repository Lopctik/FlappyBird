using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject pipe;
    private Transform _spawnPos;

    public float startDelay = 2;
    public float repeatRate = 0.5f;

    public float yRangeTop = 0.4f;
    public float yRangeBottom = -2.4f;

    void Start()
    {
        _spawnPos = GetComponent<Transform>();
        // StartCoroutine(CreateObstacle());
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);   
        
    }

    void Update()
    {
        // StartCoroutine(CreateObstacle());
    }

    private void SpawnObstacle()
    {
        _spawnPos.position = new Vector3(_spawnPos.position.x, Random.Range(yRangeBottom, yRangeTop));
        Instantiate(pipe, _spawnPos.position, pipe.transform.rotation);
    }

    IEnumerator CreateObstacle()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        yield return new WaitForSeconds(startDelay);
    }

}
