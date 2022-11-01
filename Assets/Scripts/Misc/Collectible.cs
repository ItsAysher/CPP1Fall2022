using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    public enum Collectibles
    {
        Powerup,
        Life,
        Score
    }

    public Collectibles currentCollectible;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerController curPlayer = collision.gameObject.GetComponent<PlayerController>();

            switch(currentCollectible)
            {
                case Collectibles.Life:
                    curPlayer.lives++;
                    break;
                case Collectibles.Powerup:
                    curPlayer.StartJumpForceChange();
                    break;
                case Collectibles.Score:
                    curPlayer.score += 10;
                    break;
            }
            Destroy(gameObject);
        }
    }
}
