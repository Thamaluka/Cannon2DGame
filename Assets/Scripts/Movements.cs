using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour {
	//Public variables
	public Transform A,B,C,D,E,F;
	public float Velocity;
	public GameObject  Bat;
	public Vector3 Destiny;

	//private variable
	private GameObject TempBat;

	



	// Use this for initialization
	void Start () {

		Destiny = B.position;
		TempBat = Instantiate (Bat,A.position,Bat.transform.rotation);

	}
		
	// Update is called once per frame
	void Update () {

		//Move and Change tha Bats direction
		//Spawn just if the bat still in the scene else destroy it
		if (TempBat != null) {
			TempBat.transform.position = Vector3.MoveTowards (TempBat.transform.position, Destiny, Velocity * Time.deltaTime);

			if (TempBat.transform.position == Destiny) {
				if (Destiny == B.position) {
					Destiny = C.position;
				} else if (Destiny == C.position) {
					Destiny = D.position;
				} else if (Destiny == D.position) {
					Destiny = E.position;
				} else if (Destiny == E.position) {
					Destiny = F.position;
				} else if (Destiny == F.position) {
					DestroyObj ();
				}
			}
		} else {
			Destroy (this.gameObject);
		}

	
	}

	//Destroy the objects if not hit by FireBomb
	public void DestroyObj(){
		Destroy (this.gameObject);
		Destroy (TempBat, 0.1f);
	}


}
