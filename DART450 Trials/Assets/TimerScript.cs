using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
	public float timeLeft = 30.0f;
	public Text timer; 
    // Start is called before the first frame update
    void Start()
    {
        
    }



	void Update()
	{
		timeLeft -= Time.deltaTime;
		if(timeLeft < 0)
		{
			//GameOver();
		}

		timer.text = "Time: " + timeLeft.ToString ();
	}
}
