using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
	
	public string spawnPointTag = "sometag";
	public bool alwaysSpawn = true;
    public float spawnInterval;
    private float timer;
    public int maxSpawn;
    public GameObject pts;
	
	public List<GameObject> prefabsToSpawn;

    private List<GameObject> BallList;
	
    // Start is called before the first frame update
    void Start()
    {
        BallList = new List<GameObject>();
        timer = 0;
        GenerateRandomBall();
    }

    private void Update() {
        timer += Time.deltaTime;

        if( timer > spawnInterval)
        {
            GenerateRandomBall();
            timer -= spawnInterval;
        }
    }

    private void OnTriggerEnter(Collider collision) {
        if (collision.tag == "Ball") {
            Destroy(collision.gameObject);
        }
    }


    public void GenerateRandomBall()
    {
        GameObject[] spawnPoints = GameObject.FindGameObjectsWithTag(spawnPointTag);
		foreach(GameObject spawnPoint in spawnPoints){
			int randomPrefab = Random.Range(0, 5);
			if(alwaysSpawn){
				pts = Instantiate(prefabsToSpawn[randomPrefab]);
				pts.transform.position = spawnPoint.transform.position;
			}else{

                if (BallList.Count <= maxSpawn)
                {
                    int spawnOrNot = Random.Range(0, 5);
                    if(spawnOrNot == 0){
					pts = Instantiate(prefabsToSpawn[randomPrefab]);
					pts.transform.position = spawnPoint.transform.position;

                    BallList.Add(pts);
				    }
                }
			}
		}
    }

}