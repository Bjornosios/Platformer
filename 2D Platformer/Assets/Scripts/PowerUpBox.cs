using UnityEngine;

public class PowerUpBox : MonoBehaviour
{
    [SerializeField] GameObject PowerUpPreFab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.GetComponent<Rigidbody2D>().linearVelocityY > -0.1f)
            {
                Instantiate(PowerUpPreFab, transform.position, Quaternion.identity);
                collision.gameObject.GetComponent<Rigidbody2D>().linearVelocityY = 0;
                Destroy(gameObject);
            }
        }

    }
}
