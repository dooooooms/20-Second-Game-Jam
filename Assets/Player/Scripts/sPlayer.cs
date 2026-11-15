using UnityEngine;
using UnityEngine.InputSystem;

public class sPlayer : MonoBehaviour
{
    public Transform head;
    public Rigidbody body;
    public Camera cam;
    public InputActionAsset actions;
    //public InputAction interactAction;
    public float walkSpeed;
    public float runSpeed;

    private float interactdist = 3f;
    [SerializeField]
    private LayerMask mask;
    private sPlayerUI playerUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        playerUI = GetComponent<sPlayerUI>();

    }

    // Update is called once per frame
    void Update()
    {
        playerUI.UpdatePrompt(string.Empty);
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * 2f);
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactdist, mask))
        {
            if (hit.collider.GetComponent<sInteractableBase>() != null)
            {
                sInteractableBase interactable = hit.collider.GetComponent<sInteractableBase>();

                playerUI.UpdatePrompt(hit.collider.GetComponent<sInteractableBase>().prompt);
                if (actions.FindActionMap("Default").FindAction("Interact").triggered)
                {
                    interactable.BaseInt();
                }
            }
        }
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
