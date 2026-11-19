using UnityEngine;

public class sDoor : sInteractableBase
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //protected Vector3 closedPos;
    //protected Vector3 openPos;
    //protected bool open;

    public Animator animator;
    //private bool useDoor = false;
    //public float depth;
    //public GameObject rect;
    //[SerializeField]
    //public AnimationCurve curve;
    //public float speed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Animator animator = GetComponent<Animator>();
    }

    protected override void Interact()
    {
        //if (!useDoor)
        //{
        //    StartCoroutine(OpenClose());
        //}
        Debug.Log("Pressed E");
        if (!animator.GetBool("Open"))
        {
            animator.SetBool("Open", true);
            Debug.Log("Open");
        }
        else { animator.SetBool("Open", false); Debug.Log("Close"); }
    }


    // Update is called once per frame
    void Update()
    {

    }


    //private IEnumerator OpenClose()
    //{
    //    float time = 0;
    //    Quaternion rotation = Quaternion.FromToRotation(closedPos, openPos);
    //    Quaternion rotLeft = rotation;
    //    if (!open)
    //    {
    //        useDoor = true;

    //        while (rotLeft > 0f)
    //        {
    //            transform.position = Vector3.Lerp(openPos, closedPos, curve.Evaluate(1 - (distLeft / distance)));
    //            rotLeft -= speed * Time.deltaTime;
    //            transform.rotation = Quaternion.Lerp(openPos, closedPos, curve.Evaluate(time));

    //            yield return null;
    //        }
    //        open = true;
    //        useDoor = false;
    //    }
    //    else
    //    {
    //        useDoor = true;
    //        //float distance = Vector3.Distance(openPos, closedPos);
    //        //float distLeft = distance;
    //        while (rotLeft > 0)
    //        {
    //            transform.position = Vector3.Lerp(closedPos, openPos, curve.Evaluate(1 - (distLeft / distance)));
    //            rotLeft -= speed * Time.deltaTime;
    //            yield return null;
    //        }
    //        useDoor = false;
    //        open = false;
    //    }









}
