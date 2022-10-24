using System.Collections;
using System.Collections.Generic;
using UnityEngine; //using UnityEngine.Events;

public class Shoot : MonoBehaviour
{
    SpriteRenderer sr;

    public float projectileSpeed;
    public Transform spawnPointLeft;
    public Transform spawnPointRight;
    public Projectile projectilePrefab;


    private void Start()
    {
        if (projectileSpeed <= 0)
            projectileSpeed = 7.0f;

        if(!spawnPointLeft || !spawnPointRight || !projectilePrefab)
        {
            Debug.Log("Set up default values in inspector for Shoot script on: " + gameObject.name);
        }
    }
    public void Fire()
    {
        sr = GetComponent<SpriteRenderer>();

        if (!sr.flipX)
        {
            Projectile curProjectile = Instantiate(projectilePrefab, spawnPointRight.position, spawnPointRight.rotation);
            curProjectile.speed = projectileSpeed;
        }
        else
        {
            Projectile curProjectile = Instantiate(projectilePrefab, spawnPointLeft.position, spawnPointLeft.rotation);
            curProjectile.speed = projectileSpeed * -1;
        }
    }
}
