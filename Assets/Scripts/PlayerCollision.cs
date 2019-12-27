
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public playerMovement movement;
   

    void OnCollisionEnter(Collision collisonInfo)
    {
        if (collisonInfo.collider.tag == "Obstacle")
        {

            movement.enabled = false; //same as GetComponent<playerMovement>().enabled = false;

            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
