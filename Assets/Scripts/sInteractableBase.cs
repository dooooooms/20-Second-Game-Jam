using UnityEngine;

public class sInteractableBase : MonoBehaviour
{


    public string prompt;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void BaseInt()
    {
        Interact();
    }

    protected virtual void Interact()
    {

    }
}
