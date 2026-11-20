using UnityEngine;

public class PickupScript : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        Destroy(gameObject);
        Debug.Log("Picked Up");
    }
}
