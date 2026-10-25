using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    public Vector3 cameraDistanceFromPlayer = new Vector3(0,1,-5);

    void Update()
    {
        transform.position = player.position + cameraDistanceFromPlayer;
    }
}
