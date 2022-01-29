using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(new Vector3(0, 0, Time.deltaTime * speed));

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(new Vector3(rotationSpeed * Time.deltaTime * verticalInput,0,0));
    }
}
