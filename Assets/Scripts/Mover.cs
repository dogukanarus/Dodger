using System;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0f;
    void Start()
    {
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float yValue = Input.GetAxis("Jump") * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(xValue, yValue, zValue);
    }
}
