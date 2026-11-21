using UnityEngine;

public class sBomb : sInteractableBase
{

    private bool pickedUp;
    public int buttonCount;
    public int wireCount;
    public int leverCount;
    public int[] Code = new int[3];
    private string WiretoDefuse;

    private Vector3 startPos;
    private Vector3 pickedUpPos;
    [SerializeField]
    public sPlayer player;

    public int defuseMethod;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        defuseMethod = Random.Range(0, 3);
        GenerateBomb(defuseMethod);
    }

    // Update is called once per frame
    void Update()
    {

    }

    protected override void Interact()
    {

    }

    private void GenerateBomb(int defuseMethod)
    {
        switch (defuseMethod)
        {
            case 0:
                buttonCount = Random.Range(1, 10);
                break;
            case 1:
                wireCount = Random.Range(2, 8);
                break;
            case 2:
                leverCount = Random.Range(1, 8);
                break;
            case 3:
                for (int i = 0; i < 3; i++)
                {
                    Code[i] = Random.Range(0, 9);
                }
                break;
        }
    }
}
