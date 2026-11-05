using UnityEngine;

public class sDrawer : MonoBehaviour
{
    protected Vector3 closedPos;
    protected Vector3 openPos;
    protected bool open;

    private bool useDrawer;
    public float depth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        depth = transform.localScale.x - 0.1f;
        closedPos = transform.position;
        openPos = transform.position;
        closedPos = openPos + (transform.forward * depth);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnKeyDown(KeyCode= KeyCode.E)
    {
        Invoke("Interact", 0f);
    }


}
