using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar_Controller : MonoBehaviour {

    public void GuidancePillar()
    {
        GameObject bluepill = this.gameObject.transform.GetChild(0).gameObject;
        bluepill.GetComponent<Renderer>().enabled = true;
    }

    public void EmergencyPillar()
    {
            GameObject redpill = this.gameObject.transform.GetChild(1).gameObject;
            redpill.GetComponent<Renderer>().enabled = true;
    }

}
