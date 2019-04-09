using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DespawnerScript : MonoBehaviour
{
	public float dropouts = 0.0f;
	public Text dropoutCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		Debug.Log("dropouts: " + dropouts);
    }

	void OnTriggerEnter(Collider TheColliderThatIWillBeCollidingWith){
		if(TheColliderThatIWillBeCollidingWith.tag == "student"){
			Destroy(TheColliderThatIWillBeCollidingWith.gameObject);
			addDropout ();
			SetCountText();
		}
	}

	public void addDropout(){
		dropouts++;
		SetCountText();
	}

	void SetCountText ()
	{
		dropoutCount.text = "Dropouts: " + dropouts.ToString ();
//		if (count >= 12)
//		{
//			dropoutCount.text = "You Win!";
//		}
	}
}
