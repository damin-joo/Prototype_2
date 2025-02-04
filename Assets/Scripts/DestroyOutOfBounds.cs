using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 40.0f;
    private float lowerBound = -20.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check bounds of objects and make them disappear
        if (transform.position.z > topBound) {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound) {
            Debug.Log("Game Over!");        //game over if animals reach the end of screen
            Destroy(gameObject);
        }

    }
}
