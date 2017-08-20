using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharacter : MonoBehaviour
{

    GameObject zach, stan;
    int characterSelect;
    GameObject CurrentChar;
    public bool Trigger = false;
<<<<<<< HEAD
	public Canvas canvas;

	public Camera zachCam;
	public Camera stanCam;
=======
>>>>>>> ba601f37a1336b81c1e0fe0370a1fb303b9e7c98

    // Use this for initialization
    void Start()
    {
        characterSelect = 1; //current character
        zach = GameObject.Find("hero");
        stan = GameObject.Find("hero2");
<<<<<<< HEAD
		transform.position = new Vector3 (3, 0, 0);

		//zachCam = zach.GetComponent<Camera> ();
		//stanCam = stan.GetComponent<Camera> ();

		canvas.worldCamera = zachCam;
=======
        transform.position = new Vector3(3, 0, 0);


>>>>>>> ba601f37a1336b81c1e0fe0370a1fb303b9e7c98
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = GameObject.FindGameObjectWithTag("Player").transform.position; //current position of Player
        Vector3 oldPos = new Vector3(2, 1, 0); //Empty old position vector


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Trigger = false;
            characterSelect = 1;
            oldPos = pos;
            Debug.Log("1" + oldPos);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Trigger = false;
            characterSelect = 2;
            oldPos = pos;
            Debug.Log("2" + oldPos);
        }

        if (characterSelect == 1)
        {
            if (Trigger == false)
            {
                zach.SetActive(true); //Activate Zach
                stan.SetActive(false);

                GameObject.Find("hero").transform.position = oldPos;

                Trigger = true; //Change trigger back to true so that it doesn't repeat more than once.

<<<<<<< HEAD
				canvas.worldCamera = zachCam;
=======
>>>>>>> ba601f37a1336b81c1e0fe0370a1fb303b9e7c98

            }

        }
        else if (characterSelect == 2)
        {
            if (Trigger == false)
            {
                zach.SetActive(false); //Activate Stan
                stan.SetActive(true);

                GameObject.Find("hero2").transform.position = oldPos; //Set Stan's position to the previous players' old position.

                Trigger = true;

<<<<<<< HEAD
				canvas.worldCamera = stanCam;
=======

>>>>>>> ba601f37a1336b81c1e0fe0370a1fb303b9e7c98
            }

        }
    }
}
