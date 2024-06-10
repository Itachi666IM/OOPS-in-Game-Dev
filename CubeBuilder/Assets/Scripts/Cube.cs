using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cube : MonoBehaviour
{
    private string cubeName;
    public TextMeshProUGUI textDisplay;
    // Start is called before the first frame update
    void Start()
    {
        cubeName = "Default";
        textDisplay.text = cubeName;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            TextDisplayWithName(); //ABSTRACTION
        }

        if(Input.GetMouseButtonDown(1))
        {
            DisableTextDisplay(); //ABSTRACTION
        }
    }

    void TextDisplayWithName()
    {
        textDisplay.gameObject.SetActive(true);
    }

    void DisableTextDisplay()
    {
        textDisplay.gameObject.SetActive(false);
    }

    //ENCAPSULATION
    public virtual void SetCubeName()
    {
        cubeName = "Default";
    }

    //POLYMORPHISM
    public void Change(string name)
    {
        cubeName = name;
    }

    public void Change(Material material)
    {
        Material cubeMaterial = GetComponent<Material>();
        cubeMaterial = material;
    }
}
