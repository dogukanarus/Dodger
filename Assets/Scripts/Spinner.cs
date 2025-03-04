using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xSpeed = 0f;
    [SerializeField] float ySpeed = 0f;
    [SerializeField] float zSpeed = 0f;

    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(xSpeed * Time.deltaTime, ySpeed * Time.deltaTime, zSpeed * Time.deltaTime);
    }
}
