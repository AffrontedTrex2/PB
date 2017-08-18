using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class endLevel : MonoBehaviour {

    public GlobalControl global;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            global.saveGems();
            Debug.Log(global.gems);
            SceneManager.LoadScene("Level 2");
        }
    }
}
