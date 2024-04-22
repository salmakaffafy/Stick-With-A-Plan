using UnityEngine;

public class BounceTriggerManager : MonoBehaviour
{
    public float bounceForce = 10f; // bouncing force
    bool HasBouncingStickNote=false;
    void OnTriggerEnter2D(Collider2D asset)
    {
        if (asset.CompareTag("Player"))
        {

            if (HasBouncingStickNote==true)
            {
                Rigidbody2D playerRb = asset.GetComponent<Rigidbody2D>();
                playerRb.velocity = Vector2.up * bounceForce;
            }
        }
    }

    bool PlayerHasBouncingStickyNote()
    {
        //logic
    }
}
