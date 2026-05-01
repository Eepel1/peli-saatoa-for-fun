using UnityEngine;

public class AlchMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float dead = -30;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position  + (Vector3.left * moveSpeed * Time.deltaTime);

        if (transform.position.x < dead)
        {
            Debug.Log("destroying");
            Destroy(gameObject);
        }
    }
}
