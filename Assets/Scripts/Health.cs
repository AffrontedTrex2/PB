using UnityEngine;
using UnityEngine.UI;
using System.Collections;



public class Health : MonoBehaviour
{

    public static int startingHealth = 5;

    public static int currentHealth;
    public Sprite[] heartsLeft;
    public Image HeartUI;

    void Start()
    {
        currentHealth = startingHealth;
        HeartUI.sprite = heartsLeft[currentHealth];
        Debug.Log("Health: " + currentHealth);
        for (int i = 0; i < heartsLeft.Length; i++)
        {
            Debug.Log(heartsLeft[i]);
        }
    }


    void Update()
    {

    }


    public void ChangeHealth(int amount)
    {
        Debug.Log("ChangeHealth called");
        Debug.Log("HealthBefore: " + currentHealth);
        currentHealth += amount;
        Debug.Log("Health: " + currentHealth);
        Debug.Log("Length: " + heartsLeft.Length);
        for (int i = 0; i < heartsLeft.Length; i++)
        {
            Debug.Log(heartsLeft[i]);
        }
        //HeartUI.sprite = heartsLeft[currentHealth];
    }
}