using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    public float turnSpeed = 50;
    private float horisontalInput;
    private float verticallInput;
    void Start()
    {
        
    }

    void Update()
    {
        horisontalInput = Input.GetAxis("Horizontal");
        verticallInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 0, Time.deltaTime * speed * verticallInput));
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horisontalInput);
    }
}
