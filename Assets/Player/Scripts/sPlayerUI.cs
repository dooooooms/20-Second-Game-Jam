using TMPro;
using UnityEngine;

public class sPlayerUI : MonoBehaviour
{


    [SerializeField]
    private TextMeshProUGUI text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public void UpdatePrompt(string prompt)
    {
        text.text = prompt;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
