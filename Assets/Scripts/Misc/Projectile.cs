using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public float lifetime;
    // Start is called before the first frame update
    void Start()
    {
        if (lifetime <= 0)
            lifetime = 2.0f;

        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
        Destroy(gameObject, lifetime);

        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Player" ) //|| collision.gameObject.name != "Collectible")
                Destroy(gameObject);

        Debug.Log("Collided with " + collision.gameObject.name);
    }
}
