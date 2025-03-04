using System.Threading;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timer;

    MeshRenderer mRenderer;
    Rigidbody rgbd;

    void Start()
    {
        mRenderer = GetComponent<MeshRenderer>();
        rgbd = GetComponent<Rigidbody>();

        mRenderer.enabled = false;
        rgbd.useGravity = false;
    }

    void Update()
    {
        if (Time.time > timer)
        {
            mRenderer.enabled = true;
            rgbd.useGravity = true;
        }
    }
}
