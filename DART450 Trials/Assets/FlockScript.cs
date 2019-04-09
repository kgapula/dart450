using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlockScript : MonoBehaviour
{
	//script to control student movements

	public float ViewRadius = 70.0f;
	public float WalkSpeed = 0.5f;
	public Vector3 Direction = new Vector3(0,0,1);

    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {

		//get all nearby dudes
		int layerMask = 1 << 8; //only looking at "dude" layer... which includes "goals" as well
		RaycastHit[] NearbyDudes = Physics.SphereCastAll(transform.position, ViewRadius, transform.forward, ViewRadius, layerMask);

		//store initial y
		float oldy = transform.rotation.y;
		Debug.Log("rotation : " + oldy);

		//find average orientation of nearby dudes
		float avgy = 0.0f;

		foreach(RaycastHit tempdude in NearbyDudes){
			if(tempdude.transform.tag == "dude"){
				avgy+=tempdude.transform.rotation.y;
			}
		}

		avgy = avgy/(NearbyDudes.Length);
		Debug.Log("avgy: " + avgy);

		if(NearbyDudes.Length > 0){


		}

		//fix vector3

		//combining effects
		//transform.rotation.y = (oldy+avgy+transform.rotation.y)/3;
		//transform.rotation.x = 0;
		//transform.rotation.z = 0;

		//walk
		transform.Translate(Vector3.forward*Time.deltaTime*WalkSpeed); 



    }
}
