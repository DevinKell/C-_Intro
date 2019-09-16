using UnityEngine;

public class OjbectController : MonoBehaviour
{

    void Start()
    {

    }

    void FixedUpdate()
    {
        transform.Translate(Input.GetAxis("Horizontal"), Input.GetAxis("Jump"), Input.GetAxis("Vertical"), Space.World);
        transform.Rotate(3, 3, 3);
    }
}
