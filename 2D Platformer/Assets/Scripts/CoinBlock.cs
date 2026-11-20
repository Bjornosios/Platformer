using UnityEngine;

public class CoinBlock : MonoBehaviour
{
    [SerializeField] GameObject GemPreFab;
    [SerializeField] int GemsLeft;

    private void Start()
    {
        GemsLeft = 3;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.GetComponent<Rigidbody2D>().linearVelocityY > -0.1f)
            {
                if(GemsLeft > 0)
                {
                    Instantiate(GemPreFab, transform.position + new Vector3(0, 2f, 0), Quaternion.identity);
                    collision.gameObject.GetComponent<Rigidbody2D>().linearVelocityY = 0;
                    GemsLeft -= 1;
                }
                
                
            }
        }

    }
}
