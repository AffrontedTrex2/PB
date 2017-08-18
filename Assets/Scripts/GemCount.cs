using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemCount : MonoBehaviour {

    Text txt;
    private int gems = 0;
    private int gems2;

    // Use this for initialization
    void Start () {
        txt = GameObject.Find("MainText").GetComponent<Text>();
        txt.text = "Gems: " + gems;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void UpdateScore() {
    }

    public void ChangeGemCount() {
        gems2 = gems;
        gems2 += 1;
        gems += 1;
        txt.text = "Gems: " + gems;
    }
}
