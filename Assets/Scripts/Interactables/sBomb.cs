using UnityEngine;

public class sBomb : sInteractableBase
{

    private bool pickedUp;
    private bool buttonCount;
    private bool wireCount;
    private bool leverCount;
    private int Code;
    private string WiretoDefuse;
    private Vector3 startPos;
    private Vector3 pickedUpPos;
    [SerializeField]
    public sPlayer player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    protected override void Interact()
    {

    }
}
