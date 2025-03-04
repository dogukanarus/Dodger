using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float deltaSpeed;
    [SerializeField] Transform player;

    Vector3 playerPosition;

    void Awake()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, deltaSpeed * Time.deltaTime);
    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
