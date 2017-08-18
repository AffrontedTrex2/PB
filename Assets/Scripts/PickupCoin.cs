using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupCoin : MonoBehaviour
{
    public GemCount gems; //Reference GemCount.cs, called gems.
    public bool HasBeenCollected = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Hello");
        if (collision.gameObject.CompareTag("Player"))
        {
            if (HasBeenCollected == false)
            {
                HasBeenCollected = true;
                Destroy(gameObject);
                gems.ChangeGemCount();

            }
            
        }
    }
}
