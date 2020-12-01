using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Player Player;
    public GameManager gameManager;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            Player.movement = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
