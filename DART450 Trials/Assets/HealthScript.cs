using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
	public float startHealth = 1000;
	public float amount = 0.00001f;

	//public GameObject spawnPoint; // the object despawn script is attached to
	//public DespawnerScript despawnerScript; // reference the script cs

	DespawnerScript despawner;

	[Header("Unity Stuff")]
	public Image healthBar;

	//current health
	private float health;
	
    // Start is called before the first frame update
    void Start()
    {
		//despawnerScript = spawnPoint.GetComponent<DespawnerScript>();
		despawner = FindObjectOfType<DespawnerScript>();
		health = startHealth;
    }

    // Update is called once per frame
    void Update()
    {
		TakeDamage (amount);
    }

	public void TakeDamage(float amount){
		health -= amount;
		healthBar.fillAmount = health / startHealth;

		if (health <= 0) {
			Die ();
			Destroy (gameObject);
		}
	}

	public void Die(){
		Debug.Log ("I died");
		//despawnerScript.addDropout ();
		despawner.addDropout();
	}
}
