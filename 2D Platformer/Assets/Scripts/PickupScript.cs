using UnityEngine;

public class PickupScript : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Debug.Log("Picked Up");
    }
}
