using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public ScoreManager manager;
    
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody>();
        this.direction = new Vector3 (1f, 0, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    void FixedUpdate(){
        this.rb.MovePosition(this.rb.position + direction * speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter(Collider other) {

        if (other.CompareTag("Paddlex")){
            direction.x = -direction.x;
        }

        if (other.CompareTag("Paddlez")){
            direction.z = -direction.z;
        }

        if (other.CompareTag("Skor1")){
            manager.AddPlayer1Score(1);
        }

        if (other.CompareTag("Skor2")){
            manager.AddPlayer2Score(1);
        }

        if (other.CompareTag("Skor3")){
            manager.AddPlayer3Score(1);
        }

        if (other.CompareTag("Skor4")){
            manager.AddPlayer4Score(1);
        }
    }
}
