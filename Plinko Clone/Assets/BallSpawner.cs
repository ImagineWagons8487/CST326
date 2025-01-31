using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public Transform indicator;
    public GameObject ballPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if input, spawn more balls
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 spawnPos = indicator.position;
        
            //create new ball instance at position
            Instantiate(ballPrefab, spawnPos, Quaternion.identity);
        }
    }
}
