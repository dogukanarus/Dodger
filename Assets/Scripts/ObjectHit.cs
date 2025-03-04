using System.Collections;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag is "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
            gameObject.tag = "Hit";

            // StartCoroutine(ChangeTagWithDelay());
        }
    }

    // IEnumerator ChangeTagWithDelay()
    // {
    //     yield return null;
    //     gameObject.tag = "Hit";
    // }
}
