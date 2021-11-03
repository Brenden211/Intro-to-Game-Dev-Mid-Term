using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter (Collision collosionInfo)
    {
        if (collosionInfo.collider.tag == "Obstacle")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
