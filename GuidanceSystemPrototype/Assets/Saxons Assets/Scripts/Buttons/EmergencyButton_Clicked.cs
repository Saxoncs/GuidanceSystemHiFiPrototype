using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmergencyButton_Clicked : MonoBehaviour {

    public void Clicked()
    {
        // Uses the same basic method as guidance but stats counting at 
        // 10 if you need more space in the guidance system you'll need to tweak a few numbrs here
        
        for (int i = 0; i < 10; i++)
        {
            GameObject arrow = GameObject.Find("Arrow" + i);
            Arrow_Control arrows = arrow.GetComponent<Arrow_Control>();
            arrows.ActivateGuidance();
        }

        // This script will also make an emergency trigger arrow appear, hitting this arrow
        // is what will activate the emergency system and disble the others
        GameObject triggerarrow = GameObject.Find("EmergencyTriggerArrow");
        Arrow_Control triggerarrows = triggerarrow.GetComponent<Arrow_Control>();
        triggerarrows.ActivateGuidance();

        Destroy(gameObject);
        Destroy(GameObject.Find("book1"));
    }
}
