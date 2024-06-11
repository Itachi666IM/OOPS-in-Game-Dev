using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewButton : MonoBehaviour
{
    private GameObject parentCube;
    public GameObject childCube;
    public GameObject changeMaterialButton;
    public GameObject changeNameButton;

    private void Start()
    {
        parentCube = GameObject.Find("DefaultCube");

    }

    public void DisableAndEnable()
    {
        parentCube.SetActive(false);
        childCube.SetActive(true);
        changeMaterialButton.SetActive(true);
        changeNameButton.SetActive(true);
        gameObject.SetActive(false);
    }
}
