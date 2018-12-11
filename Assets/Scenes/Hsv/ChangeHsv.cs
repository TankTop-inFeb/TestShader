using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHsv : MonoBehaviour
{

    [SerializeField]
    Material mat;
    float Hue;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("StartGo", 1f, 1f);
    }

    // Update is called once per frame
    void StartGo()
    {
        
        Hue = Random.Range(0, 255);
        mat.SetFloat("_Hue", Hue);
    }
}
