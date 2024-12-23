using UnityEngine;

public class BirdMover1 : MonoBehaviour
{

    public Vector3 startPosition;
    public int speed = 5;
    public float tapForce = 400;
    public float rotationSpeed;
    public float maxRotationZ = 180;
    public float minRotationZ = -180;
    private Rigidbody2D _rigidBody;
    private Quaternion _maxRotation;
    private Quaternion _minRotation;

    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        ResetBird();

        _maxRotation = Quaternion.Euler(0, 0, maxRotationZ);
        _minRotation = Quaternion.Euler(0, 0, minRotationZ);
    }

    public void ResetBird()
    {
        transform.position = startPosition;
        transform.rotation = Quaternion.Euler(0, 0, 0);
        _rigidBody.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space))
        {
            _rigidBody.velocity = new Vector2(speed, 0);
            transform.rotation = _maxRotation;
            _rigidBody.AddForce(Vector3.up * tapForce, ForceMode2D.Force);
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, _minRotation, rotationSpeed * Time.deltaTime);
    }
}
