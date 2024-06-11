using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeName : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    private CubeA childCube;
    // Start is called before the first frame update
    void Start()
    {
        childCube = GameObject.Find("ChildCube").GetComponent<CubeA>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeStringText()
    {
        childCube.Change(nameText.text);
    }
}
