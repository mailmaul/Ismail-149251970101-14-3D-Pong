using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed;

    public KeyCode atas;
    public KeyCode bawah;
    public KeyCode kiri;
    public KeyCode kanan;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        bool pressedkiri = Input.GetKey(kiri);
        bool pressedkanan = Input.GetKey(kanan);
        bool pressedatas = Input.GetKey(atas);
        bool pressedbawah = Input.GetKey(bawah);

        if (pressedkanan) {
            rb.velocity = Vector3.right * speed;
        }

        if (pressedkiri){
            rb.velocity = Vector3.left * speed;
        }

        if (pressedatas) {
            rb.velocity = Vector3.forward * speed;
        }

        if (pressedbawah){
            rb.velocity = Vector3.back * speed;
        }

        if (!pressedkanan && !pressedkiri && !pressedatas && !pressedbawah){
            rb.velocity = Vector3.zero;
        }
    }
}
