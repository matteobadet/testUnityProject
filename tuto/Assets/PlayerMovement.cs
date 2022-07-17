using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool zPressed = false;
    public bool qPressed = false;
    public bool dPressed = false;
    public bool sPressed = false;

    public float forwardForce = 2000f;
    public float strafForce = 1000f;

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("z"))
        {
            zPressed = true;
        }
        if (Input.GetKey("s"))
        {
            sPressed = true;
        }
        if (Input.GetKey("q"))
        {
            qPressed = true;
        }
        if (Input.GetKey("d"))
        {
            dPressed = true;
        }

        if (zPressed)
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
            zPressed = false;
        }
        if (sPressed)
        {
            rb.AddForce(0, 0, -1 * forwardForce * Time.deltaTime);
            sPressed = false;
        }
        if (qPressed)
        {
            rb.AddForce(-1 * strafForce * Time.deltaTime, 0, 0);
            qPressed = false;
        }
        if (dPressed)
        {
            rb.AddForce(strafForce * Time.deltaTime, 0, 0);
            dPressed = false;
        }

    }
}
