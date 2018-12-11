using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testyurayura : MonoBehaviour {

    [SerializeField]
    Material mat;
    float a = -1;
    float b = 0;
    bool Change;

	// Use this for initialization
	void Start () {
        a = -1;
        b = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {

        {
            if (!Change)
            {
                a += Time.deltaTime /5;
                b += Time.deltaTime;
                if (a >1)
                {
                    Change = true;
                }
            }
            else
            {
                a -= Time.deltaTime / 5;
                b -= Time.deltaTime;
                if (a < -1)
                {
                    Change = false;
                }
            }

            mat.SetFloat("_Amplitude", a);
            mat.SetFloat("_RimPower", b);
        }
    }
}
