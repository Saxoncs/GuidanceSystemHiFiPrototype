using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopularBooksButton_Clicked : MonoBehaviour
{
    private int distance = 1;
    public GameObject book1;
    public GameObject book2;

    public void Clicked()
    { 
    Instantiate(book1, this.transform.position + this.transform.forward*distance +this.transform.right*2, this.transform.rotation);
    Instantiate(book2, this.transform.position + this.transform.forward*distance + this.transform.right*1, this.transform.rotation);
    }
}