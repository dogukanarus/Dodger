using UnityEngine;

public class Scorer : MonoBehaviour
{
    int counter = 0;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag is not "Hit")
        {
            counter++;
            Debug.Log("Hit Count is: " + counter);
        }

    }
}
