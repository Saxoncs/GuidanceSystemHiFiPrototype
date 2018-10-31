using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_Control : MonoBehaviour {
   
   
    void OnTriggerEnter(Collider other)
    {

        Debug.Log("collision detected with:" + other.ToString());


        GameObject child1 = this.gameObject.transform.GetChild(0).gameObject;
        GameObject child2 = this.gameObject.transform.GetChild(1).gameObject;
        GameObject child3 = this.gameObject.transform.GetChild(2).gameObject;
        child1.GetComponent<Renderer>().enabled = false;
        child2.GetComponent<Renderer>().enabled = false;
        child3.GetComponent<Renderer>().enabled = false;
    }

    public void ActivateGuidance()
    {
        GameObject child1 = this.gameObject.transform.GetChild(0).gameObject;
        GameObject child2 = this.gameObject.transform.GetChild(1).gameObject;
        GameObject child3 = this.gameObject.transform.GetChild(2).gameObject;
        child1.GetComponent<Renderer>().enabled = true;
        child2.GetComponent<Renderer>().enabled = true;
        child3.GetComponent<Renderer>().enabled = true;
    }

}
