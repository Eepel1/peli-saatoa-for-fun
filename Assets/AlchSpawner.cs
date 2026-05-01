using UnityEngine;

public class AlchSpawner : MonoBehaviour
{
    public GameObject alchPrefab;
    public float spawnrate = 2;
    private float timer = 0;
    public float heightOffset = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnAlch();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnAlch();
            timer = 0;
        }
        
        
    }

    void spawnAlch()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(alchPrefab, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
