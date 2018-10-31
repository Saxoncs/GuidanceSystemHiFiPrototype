using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Clicked : MonoBehaviour {


    private void Start()
    {
        GetComponent<Renderer>().material.shader = Shader.Find("Diffuse");
    }

    public void Clicked()
    {
        StartCoroutine (React());
    }

    //public void Hovered()
    //{
    //    StartCoroutine(MouseOver());
    //}

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

    //private IEnumerator MouseOver()
    //{

    //    Debug.Log("cursor is hovering over an object");

    //    GetComponent<Renderer>().material.shader = Shader.Find("Standard");

    //    yield return new WaitForSeconds(0.5f);

    //    GetComponent<Renderer>().material.shader = Shader.Find("Diffuse");
    //}
}
