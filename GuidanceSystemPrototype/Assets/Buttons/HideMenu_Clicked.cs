using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideMenu_Clicked : MonoBehaviour {

    private bool hidden = false;


    public void Clicked()
    {
        GameObject button = GameObject.Find("Search");
        Button_Hide hide = button.GetComponent<Button_Hide>();
        hide.Hide();

        button = GameObject.Find("TourTheLibrary");
        hide = button.GetComponent<Button_Hide>();
        hide.Hide();

        button = GameObject.Find("VirtualAssistant");
        hide = button.GetComponent<Button_Hide>();
        hide.Hide();

        button = GameObject.Find("InteractiveExibit");
        hide = button.GetComponent<Button_Hide>();
        hide.Hide();

        button = GameObject.Find("PopularBooks");
        hide = button.GetComponent<Button_Hide>();
        hide.Hide();

        button = GameObject.Find("communityNews");
        hide = button.GetComponent<Button_Hide>();
        hide.Hide();

        button = GameObject.Find("maps");
        hide = button.GetComponent<Button_Hide>();
        hide.Hide();

        button = GameObject.Find("contact");
        hide = button.GetComponent<Button_Hide>();
        hide.Hide();

        button = GameObject.Find("endSession");
        hide = button.GetComponent<Button_Hide>();
        hide.Hide();

    }
  
    //public void Clicked()
    //{
    //    if (hidden)
    //    {
    //        GameObject hide = GameObject.Find("Backboard");
    //        hide.GetComponent<Renderer>().enabled = true;
    //        hide = GameObject.Find("TourTheLibrary");
    //        hide.GetComponent<Renderer>().enabled = true;
    //        hide = GameObject.Find("Search");
    //        hide.GetComponent<Renderer>().enabled = true;
    //        hide = GameObject.Find("VirtualAssistant");
    //        hide.GetComponent<Renderer>().enabled = true;
    //        hide = GameObject.Find("InteractiveExhibit");
    //        hide.GetComponent<Renderer>().enabled = true;
    //        hide = GameObject.Find("PopularBooks");
    //        hide.GetComponent<Renderer>().enabled = true;
    //        hide = GameObject.Find("communityNews");
    //        hide.GetComponent<Renderer>().enabled = true;
    //        hide = GameObject.Find("contact");
    //        hide.GetComponent<Renderer>().enabled = true;
    //        hide = GameObject.Find("endSession");
    //        hide.GetComponent<Renderer>().enabled = true;
    //        hide = GameObject.Find("maps");
    //        hide.GetComponent<Renderer>().enabled = true;

    //        hidden = !hidden;
    //    }
    //    else
    //    {
    //        GameObject hide = GameObject.Find("Backboard");
    //        hide.GetComponent<Renderer>().enabled = false;
    //        hide = GameObject.Find("TourTheLibrary");
    //        hide.GetComponent<Renderer>().enabled = false;
    //        hide = GameObject.Find("Search");
    //        hide.GetComponent<Renderer>().enabled = false;
    //        hide = GameObject.Find("VirtualAssistant");
    //        hide.GetComponent<Renderer>().enabled = false;
    //        hide = GameObject.Find("InteractiveExhibit");
    //        hide.GetComponent<Renderer>().enabled = false;
    //        hide = GameObject.Find("PopularBooks");
    //        hide.GetComponent<Renderer>().enabled = false;
    //        hide = GameObject.Find("communityNews");
    //        hide.GetComponent<Renderer>().enabled = false;
    //        hide = GameObject.Find("contact");
    //        hide.GetComponent<Renderer>().enabled = false;
    //        hide = GameObject.Find("endSession");
    //        hide.GetComponent<Renderer>().enabled = false;
    //        hide = GameObject.Find("MapsButton");
    //        hide.GetComponent<Renderer>().enabled = false;

    //        hidden = !hidden;
        //}

    //}

}
