using System.Xml.Serialization;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float speed = 3f;
    void LateUpdate()
    {
        // move towards the middle where the player
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 1, 0), Time.deltaTime * speed);
    }
}