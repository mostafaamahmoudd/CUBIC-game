using UnityEngine;

public class playercollision : MonoBehaviour
{
    public playermovement movement;

    private void OnCollisionEnter (Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<gameMAnager>().EndGame();
        }
    }

}
