using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Movement : MonoBehaviour
{
    public float speed = 1.0f;
    public float minX = -2.5f;
    public float maxX = 2.5f;

    void Update()
    {
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }

        if (Keyboard.current.leftArrowKey.isPressed)
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }

        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, minX, maxX),
            transform.position.y,
            transform.position.z
        );
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Cars")
        {
            Time.timeScale = 0;
        }
    }
}