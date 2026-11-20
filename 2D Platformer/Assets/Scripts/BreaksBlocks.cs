using UnityEngine;

public class BreaksBlocks : MonoBehaviour
{
    [SerializeField] GameObject BrokenParticles;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.GetComponent<Rigidbody2D>().linearVelocityY > -0.1f)
            {
                
                collision.gameObject.GetComponent<Rigidbody2D>().linearVelocityY = 0;
                Destroy(gameObject);
            }
        }

    }
}
