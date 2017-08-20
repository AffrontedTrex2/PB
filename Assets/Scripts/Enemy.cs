using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class Enemy : MonoBehaviour
{

	private bool hasCollided;

	public Health health;

	public float speed = 3f;
	public Vector3 pos1 = new Vector3(17, -7, 0);
	public Vector3 pos2 = new Vector3(32, -7, 0);

	void Start()
	{

	}

	void Update()
	{
		transform.position = Vector3.Lerp(pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
	}
		

	void OnTriggerEnter2D(Collider2D collision)
	{
		//If collided with player, change health and destroy enemy
		if (collision.gameObject.CompareTag("Player"))
		{
			if (!hasCollided)
			{
				hasCollided = true;
				health.ChangeHealth(-1);
				Destroy(gameObject);
			}
		}
	}
}
=======
public class Enemy : MonoBehaviour {

    public Health health;
    private bool hasCollided = false;

    // Use this for initialization
    void Awake ()
    {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!hasCollided)
            {
                hasCollided = true;
                health.ChangeHealth(-1);
                Destroy(gameObject);
            }
        }
    }
}
>>>>>>> ba601f37a1336b81c1e0fe0370a1fb303b9e7c98
