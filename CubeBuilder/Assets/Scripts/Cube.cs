using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cube : MonoBehaviour
{
    public string cubeName;
    public TextMeshProUGUI nameDisplay;
    private MaterialList materialHolder;
    // Start is called before the first frame update
    void Start()
    {
        cubeName = "Default";
        materialHolder = GameObject.Find("MaterialHolder").GetComponent<MaterialList>();
    }

    // Update is called once per frame
    void Update()
    {
        ShowName();
    }

    public void ShowName()
    {
        nameDisplay.text = cubeName;  //ABSTRACTION
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

    public void Change()
    {
        GetComponent<MeshRenderer>().material = materialHolder.MaterialRenderer();
    }
}
