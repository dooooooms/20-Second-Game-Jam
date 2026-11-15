using System.Collections;
using UnityEngine;

public class sDrawer : sInteractableBase
{
    protected Vector3 closedPos;
    protected Vector3 openPos;
    protected bool open;


    private bool useDrawer = false;
    public float depth;
    public Object cube;
    [SerializeField]
    public AnimationCurve curve;
    public float speed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        open = true;
        depth = transform.localScale.x - 0.1f;

        closedPos = transform.position;
        //openPos = transform.position;
        openPos = closedPos + (transform.forward * depth);

    }

    protected override void Interact()
    {
        if (!useDrawer)
        {
            StartCoroutine(OpenClose());
        }
    }


    // Update is called once per frame
    void Update()
    {

    }

    //private void OnKeyDown(KeyCode keyCode.E)
    //{
    //    StartCoroutine("Interact");
    //}


    private IEnumerator OpenClose()
    {
        float distance = Vector3.Distance(closedPos, openPos);
        float distLeft = distance;
        if (!open)
        {
            useDrawer = true;

            while (distLeft > 0)
            {
                transform.position = Vector3.Lerp(openPos, closedPos, curve.Evaluate(1 - (distLeft / distance)));
                distLeft -= speed * Time.deltaTime;
                yield return null;
            }
            open = true;
            useDrawer = false;
        }
        else
        {
            useDrawer = true;
            //float distance = Vector3.Distance(openPos, closedPos);
            //float distLeft = distance;
            while (distLeft > 0)
            {
                transform.position = Vector3.Lerp(closedPos, openPos, curve.Evaluate(1 - (distLeft / distance)));
                distLeft -= speed * Time.deltaTime;
                yield return null;
            }
            useDrawer = false;
            open = false;
        }



        //    useDrawer = false;
        //    if (!open)
        //    {
        //        for (float i = 0f; i <= 1f; i += 0.1f)
        //        {
        //            transform.localPosition = new Vector3(transform.localPosition.x - 0.1f, transform.localPosition.y, transform.localPosition.z);
        //            yield return new WaitForSeconds(0f);
        //        }
        //        open = true;
        //    }
        //    else
        //    {
        //        for (float i = 1f; i >= 0f; i -= 0.1f)
        //        {
        //            transform.localPosition = new Vector3(transform.localPosition.x + 0.1f, transform.localPosition.y, transform.localPosition.z);
        //            yield return new WaitForSeconds(0f);
        //        }
        //        transform.localPosition = closedPos;
        //        open = false;
        //    }
        //    useDrawer = true;
        //}
    }
}
