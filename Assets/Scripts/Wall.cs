using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider collision) {
        if (collision.tag == "Ball") {
           // Destroy(collision.gameObject);
            
        }
    }
}
