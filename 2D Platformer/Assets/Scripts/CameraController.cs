using UnityEngine;

public class CameraController : MonoBehaviour
{
    Transform PlayerTransform;
    [SerializeField] Vector3 Offset;
    private void Start()
    {
        PlayerTransform = FindAnyObjectByType<Movement>().transform;
        Offset = transform.position - PlayerTransform.position;
    }
    private void FixedUpdate()
    {
        transform.position = PlayerTransform.position + Offset;
    }
}
