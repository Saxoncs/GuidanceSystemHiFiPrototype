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

                if (target != null)
                {
                    target.Clicked();
                }
                else {StartCoroutine(ShotGen(hit.point));}
                
            }
        }
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
