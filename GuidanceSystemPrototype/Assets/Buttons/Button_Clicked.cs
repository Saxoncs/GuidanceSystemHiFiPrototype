using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Clicked : MonoBehaviour {

    public void Clicked()
    {
        StartCoroutine (React());
    }

    private IEnumerator React()
    {

        //Make the button shrink slightly when clicked
        Vector3 basesize = transform.localScale;
        Vector3 clickedsize = transform.localScale;

        clickedsize.y = basesize.y * 0.95f;
        clickedsize.x = basesize.x * 0.95f;

        transform.localScale = clickedsize;

        yield return new WaitForSeconds(0.1f);

        transform.localScale = basesize;
    }
}
