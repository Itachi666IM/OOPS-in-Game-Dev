using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialList : MonoBehaviour
{
    public Material[] materialList;

    public Material MaterialRenderer()
    {
        int randomMaterial = Random.Range(0, materialList.Length);
        return materialList[randomMaterial];
    }
}
