using UnityEngine;

public class sPlayer : MonoBehaviour
{
    public Transform head;
    public Rigidbody body;
    public Camera cam;

    public float walkSpeed;
    public float runSpeed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * 2f);

    }

    private void FixedUpdate()
    {
        //movement basic
        Vector3 newVelocity = Vector3.up * body.linearVelocity.y;
        float speed = Input.GetKey(KeyCode.LeftShift) ? runSpeed : walkSpeed;
        newVelocity.x = Input.GetAxis("Horizontal") * speed;
        newVelocity.z = Input.GetAxis("Vertical") * speed;
        body.linearVelocity = newVelocity;
        body.linearVelocity = transform.TransformDirection(newVelocity);
    }

    private void LateUpdate()
    {
        Vector3 e = head.eulerAngles;
        e.x -= Input.GetAxis("Mouse Y") * 2f;
        e.x = ViewAngle(e.x, -85f, 85f);
        head.eulerAngles = e;
    }

    public static float ViewAngle(float angle, float anglemin, float anglemax)
    {
        if (angle > 180)
        {
            angle -= 360;

        }
        else if (angle < -180)
        {
            angle += 360;
        }
        if (angle > anglemax)
        {
            angle = anglemax;

        }
        if (angle < anglemin)
        {
        }
        return angle;
    }

}
