using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
	/*
	public string spawnPointTag = "sometag";
	public bool alwaysSpawn = true;
    public float spawnInterval;
    private float timer;
    public int maxSpawn;
    public GameObject pts;
	
	public List<GameObject> prefabsToSpawn;

    private List<GameObject> BallList;
    */

    public Transform spawnArea;
    public List<Transform> egoSpawnCoor;
    public int maxBallSpawned, spawnInterval;
    public GameObject ballTemplate;
    private List<GameObject> ballList;

    private float timer;
	
    // Start is called before the first frame update
    void Start()
    {
        ballList = new List<GameObject>();
        timer = 0;
        
    }

    private void Update() {
        timer += Time.deltaTime;

        if( timer > spawnInterval)
        {
            //GenerateRandomBall();
            SpawnBallOnRandomSpecificCoor();
            timer -= spawnInterval;
        }
    }

    public void SpawnBallOnRandomSpecificCoor()
    {
        int randomIndex = Random.Range(0, egoSpawnCoor.Count);
        SpawnBallOnRandomSpecificCoor(new Vector3(egoSpawnCoor[randomIndex].position.x, egoSpawnCoor[randomIndex].position.y, egoSpawnCoor[randomIndex].position.z), randomIndex);
    }


    public void SpawnBallOnRandomSpecificCoor(Vector3 position, int index)
    {
        if (ballList.Count >= maxBallSpawned)
        {
            return;
        }

        GameObject ball = Instantiate(ballTemplate, new Vector3(position.x, position.y, position.z), Quaternion.identity, spawnArea);
    
        switch(index+1)
        {
            case 1:
            ball.GetComponent<Ball>().direction = new Vector3(10, 0 , -10);
            Debug.Log("1");
            break;

            case 2:
            ball.GetComponent<Ball>().direction = new Vector3(10, 0 , 10);
            Debug.Log("2");
            break;

            case 3:
            ball.GetComponent<Ball>().direction = new Vector3(-10, 0 , -10);
            Debug.Log("3");
            break;

            case 4:
            ball.GetComponent<Ball>().direction = new Vector3(-10, 0 , 10);
            Debug.Log("4");
            break;
        }

        ball.SetActive(true);

        ballList.Add(ball);
    }

    public void RemoveBall(GameObject ball)
    {
        ballList.Remove(ball);
        Destroy(ball);
    }

    public void RemoveAllBall()
    {
        while(ballList.Count > 0)
        {
            RemoveBall(ballList[0]);
        }
    }


}