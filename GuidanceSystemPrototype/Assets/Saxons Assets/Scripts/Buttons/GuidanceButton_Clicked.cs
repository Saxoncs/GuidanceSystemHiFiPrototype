using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuidanceButton_Clicked : MonoBehaviour {

public void Clicked()
    {
        //This will need to be repeated for every arrow we need, in order to work all arrows must follow the same naming convention!
        for (int i = 0; i < 10; i++)
        {
            GameObject arrow = GameObject.Find("Arrow" + i);
            Arrow_Control arrows = arrow.GetComponent<Arrow_Control>();
            arrows.ActivateGuidance();


        }
        GameObject beam = GameObject.Find("LightBeam");
        Pillar_Controller bluebeam = beam.GetComponent<Pillar_Controller>();
        bluebeam.GuidancePillar();
    }
}
