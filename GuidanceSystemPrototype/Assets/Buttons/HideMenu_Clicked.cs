using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideMenu_Clicked : MonoBehaviour {

    private bool hidden = false;

  
    public void Clicked()
    {
        if (hidden)
        {
            GameObject hide = GameObject.Find("Backboard");
            hide.GetComponent<Renderer>().enabled = true;
            hide = GameObject.Find("TourButton");
            hide.GetComponent<Renderer>().enabled = true;
            hide = GameObject.Find("SearchButton");
            hide.GetComponent<Renderer>().enabled = true;
            hide = GameObject.Find("VirtualAssistantButton");
            hide.GetComponent<Renderer>().enabled = true;
            hide = GameObject.Find("InteractiveExhibitsButton");
            hide.GetComponent<Renderer>().enabled = true;
            hide = GameObject.Find("PopularBooksButton");
            hide.GetComponent<Renderer>().enabled = true;
            hide = GameObject.Find("CommunityNewsButton");
            hide.GetComponent<Renderer>().enabled = true;
            hide = GameObject.Find("ContactButton");
            hide.GetComponent<Renderer>().enabled = true;
            hide = GameObject.Find("CloseButton");
            hide.GetComponent<Renderer>().enabled = true;
            hide = GameObject.Find("MapsButton");
            hide.GetComponent<Renderer>().enabled = true;

            hidden = !hidden;
        }
        else
        {
            GameObject hide = GameObject.Find("Backboard");
            hide.GetComponent<Renderer>().enabled = false;
            hide = GameObject.Find("TourButton");
            hide.GetComponent<Renderer>().enabled = false;
            hide = GameObject.Find("SearchButton");
            hide.GetComponent<Renderer>().enabled = false;
            hide = GameObject.Find("VirtualAssistantButton");
            hide.GetComponent<Renderer>().enabled = false;
            hide = GameObject.Find("InteractiveExhibitsButton");
            hide.GetComponent<Renderer>().enabled = false;
            hide = GameObject.Find("PopularBooksButton");
            hide.GetComponent<Renderer>().enabled = false;
            hide = GameObject.Find("CommunityNewsButton");
            hide.GetComponent<Renderer>().enabled = false;
            hide = GameObject.Find("ContactButton");
            hide.GetComponent<Renderer>().enabled = false;
            hide = GameObject.Find("CloseButton");
            hide.GetComponent<Renderer>().enabled = false;
            hide = GameObject.Find("MapsButton");
            hide.GetComponent<Renderer>().enabled = false;

            hidden = !hidden;
        }

    }

}
