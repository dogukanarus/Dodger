using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject[] projectiles;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag is "Player")
        {
            foreach (GameObject obj in projectiles)
            {
                obj.SetActive(true);
            }
            Destroy(gameObject);
        }
    }
}
