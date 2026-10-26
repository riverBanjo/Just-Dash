using UnityEngine;
using UnityEngine.AI;

public class PlayerCollision : MonoBehaviour
{
    public string obstacleTag = "Obstacle";

    public PlayerMovement movement;

    void OnCollisionEnter( Collision collision )
    {
        if ( collision.collider.tag == obstacleTag )
        {
            movement.enabled = false;
        }
    }

}
