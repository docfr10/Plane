using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        float moveZ = Input.GetAxis("Jump");
        float unmoveZ = Input.GetAxis("Fire3");

        Vector3 movement = new Vector3(speed * moveHorizontal, speed * moveZ, speed * moveVertical);
        Vector3 unmovement = new Vector3(speed * moveHorizontal, speed * - unmoveZ, speed * moveVertical);

        rb.velocity += movement * speed * Time.deltaTime;
        rb.velocity += unmovement * speed * Time.deltaTime;
    }
}