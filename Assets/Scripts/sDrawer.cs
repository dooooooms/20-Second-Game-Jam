using UnityEngine;

public class sDrawer : sInteractableBase
{
    protected Vector3 closedPos;
    protected Vector3 openPos;
    protected bool open;


    private bool useDrawer;
    public float depth;
    public Object cube;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        depth = transform.localScale.x - 0.1f;
        closedPos = transform.position;
        openPos = transform.position;
        closedPos = openPos + (transform.forward * depth);

    }

    protected override void Interact()
    {
        base.Interact();
    }


    // Update is called once per frame
    void Update()
    {

    }

    //private void OnKeyDown(KeyCode keyCode.E)
    //{
    //    StartCoroutine("Interact");
    //}


    //private IEnumerator Interact()
    //{
    //    useDrawer = true;
    //    if (!open)
    //    {
    //        for (float i = 0f; i <= 1f; i += 0.1f)
    //        {
    //            yield return null;
    //        }
    //    }
    //}
}
