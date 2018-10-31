using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Hide : MonoBehaviour {

    private bool hidden = false;

    public void Hide()
    {
         Renderer[] renderers = GetComponentsInChildren<Renderer>();
        foreach (var r in renderers)
        {
            if (!hidden)
            {
                r.enabled = false;
            }
            else
            {
                r.enabled = true;
            }

        }
            hidden = !hidden;
    }

}
