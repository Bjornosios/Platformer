using UnityEngine;

public class CameraController : MonoBehaviour
{
    Transform PlayerTransform;
    [SerializeField] Vector3 Offset;
    [SerializeField] float CameraSweepSpeed;
    
    private void Start()
    {
        PlayerTransform = FindAnyObjectByType<Movement>().transform;
        Offset = transform.position - PlayerTransform.position;
    }
    private void Update()
    {
        //transform.position = PlayerTransform.position + Offset;
        transform.position = Vector3.Lerp(transform.position, PlayerTransform.position + Offset, CameraSweepSpeed * Time.deltaTime);
    }
    
}
