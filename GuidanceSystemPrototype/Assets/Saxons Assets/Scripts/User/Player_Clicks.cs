using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Clicks : MonoBehaviour {
    private Camera playerCam;


	// Use this for initialization
	void Start () {
        playerCam = GetComponent<Camera>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0))
        {
            Vector3 point = new Vector3 (playerCam.pixelWidth / 2, playerCam.pixelHeight / 2,  0);
            Ray ray = playerCam.ScreenPointToRay(point);
            RaycastHit hit;
            if (Physics.Raycast (ray, out hit))
            {
                GameObject hitObject = hit.transform.gameObject;
                //objects will need scripts in response to being hit.

                Button_Clicked target = hitObject.GetComponent<Button_Clicked>();
                HideMenu_Clicked hide = hitObject.GetComponent<HideMenu_Clicked>();
                GuidanceButton_Clicked guide = hitObject.GetComponent<GuidanceButton_Clicked>();
                EmergencyButton_Clicked emergency = hitObject.GetComponent<EmergencyButton_Clicked>();
                PopularBooksButton_Clicked books = hitObject.GetComponent<PopularBooksButton_Clicked>();

                if (target != null)
                {
                    target.Clicked();

                    if (hide != null)
                    {
                        hide.Clicked();
                    }
                    else if (guide != null)
                    {
                        guide.Clicked();
                    }
                    else if (emergency != null)
                    { 
                        emergency.Clicked();
                    }
                    else if (books != null)
                    {
                        books.Clicked();
                    }
                }
                else {StartCoroutine(ShotGen(hit.point));}
                
            }
        }
        //else
        //{
        //    Vector3 point = new Vector3(playerCam.pixelWidth / 2, playerCam.pixelHeight / 2, 0);
        //    Ray ray = playerCam.ScreenPointToRay(point);
        //    RaycastHit hit;
        //    if (Physics.Raycast(ray, out hit))
        //    {
        //        GameObject hitObject = hit.transform.gameObject;
        //        //objects will need scripts in response to being hit.

        //        Button_Clicked target = hitObject.GetComponent<Button_Clicked>();

        //        if (target != null)
        //        {
        //            target.Hovered();
        //        }
        //    }
        //}
	}

    private IEnumerator ShotGen(Vector3 pos)
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        sphere.transform.position = pos;

        yield return new WaitForSeconds(1);

        Destroy(sphere);
    }

    private void OnGUI()
    {
        int size = 24;
        float posx = playerCam.pixelWidth / 2 - size / 4;
        float posy = playerCam.pixelHeight / 2 - size / 4;

        GUI.Label(new Rect(posx, posy, size, size), "O");
    }

}
