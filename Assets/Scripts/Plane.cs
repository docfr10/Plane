using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject Player;
    public GameObject Platform;
    public int Speed = 8;

    Rigidbody rb;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Player.transform.Rotate(0, 0, (float)-0.5);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Player.transform.Rotate(0, 0, (float)0.5);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Player.transform.position += Player.transform.right * Speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            Player.transform.Rotate((float)0.5, 0, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            Player.transform.Rotate((float)-0.5, 0, 0);
        }
        if (Input.GetKey(KeyCode.A)) 
        {
            Player.transform.Rotate(0, (float)-0.5, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Player.transform.Rotate(0, (float)0.5, 0);
        }
    }
}
