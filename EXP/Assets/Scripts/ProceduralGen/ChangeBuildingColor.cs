using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBuildingColor : MonoBehaviour
{
    Renderer rend;
    Material matCurrent;
    public Material mat1;
    public Material mat2;
    public Material mat3;
    int matIndex;
    private void Start()
    {
        rend = GetComponent<MeshRenderer>();
        ChooseMat();
    }
    void ChooseMat()
    {
        matIndex = Random.Range(1, 4);
        switch (matIndex)
        {
            case 1:
                matCurrent = mat1;
                break;
            case 2:
                matCurrent = mat2;
                break;
            case 3:
                matCurrent = mat3;
                break;
        }
        rend.material = matCurrent;
    }
}
