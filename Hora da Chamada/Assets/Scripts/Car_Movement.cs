using UnityEngine;
using UnityEngine.InputSystem;

public class Car_Movement : MonoBehaviour
{
    public float speed = 4.0f;

    void Update()
    {
        transform.position -= new Vector3(0, speed * Time.deltaTime, 0);
    }
}