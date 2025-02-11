using UnityEngine;

public class Collectible : MonoBehaviour
{

    public float rotationSpeed;
    public GameObject onCollectEffect;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0); 
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player")){
            // Destry the collectible when the player collides with it
            Destroy(gameObject);

            //instantiate the onCollectEffect at the collectible's position
        Instantiate(onCollectEffect, transform.position, transform.rotation);
        }
        

        

    }
}
