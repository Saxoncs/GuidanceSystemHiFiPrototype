using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour {

    public Transform target;
    // Update is called once per frame
    void Update ()
    {

        // For some reason this moves the entire menu and doesn't just rotate it
        if (target != null)
        {
            transform.LookAt(target);
        }
    }
}
