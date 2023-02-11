using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCube : MonoBehaviour
{
    public Material glassMaterial;
    public void ResetPillar()
    {
        gameObject.GetComponent<MeshRenderer>().material = glassMaterial;
    }
}
