using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmergencyTriggerArrow_Controller : MonoBehaviour {

     void OnTriggerEnter(Collider other)
    {
        //Here I has to be set to the exact number of arros and the naming must be exact
        for (int i = 0; i < 2; i++)
        {
            Debug.Log("EMERGENCY!");
            GameObject arrow = GameObject.Find("EmergencyArrow" + i);
            Arrow_Control arrows = arrow.GetComponent<Arrow_Control>();
            arrows.ActivateGuidance();
        }

    }
}
