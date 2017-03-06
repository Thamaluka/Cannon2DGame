using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cannon : MonoBehaviour {
	//Public variables
	public GameObject Canhao , FireBomb;
	public Transform FirePlace;
	public Text Score;
	public int Poits;

	//private variables
	private float Temp,timer,WaitingTime,FireVelocity,X;
	private AudioSource AudioFire;

	// Use this for initialization
	void Start () {

		WaitingTime = 1.5f;
		FireVelocity = 6f;
		AudioFire = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		//Updates the score game
		Score.text = "Score: " + Poits.ToString ();
		Temp = Canhao.transform.localEulerAngles.z;

		//Move the cannon automatically
		if (timer < WaitingTime) {
			Canhao.transform.RotateAround (transform.position, Vector3.forward, 50 * Time.deltaTime);
		} else {
			Canhao.transform.RotateAround (transform.position, Vector3.back, 50 * Time.deltaTime);
		}

		if(Temp > 310f && Temp <320f){
			timer = 0;
		}

		timer += Time.deltaTime;

		//Key to shoot 
		if(Input.GetButtonDown("Fire2") || Input.touchCount>0){
			fire ();
		}
				
	}

	//Function responsible for to shoot
	void fire(){
		GameObject fireTemp = Instantiate (FireBomb,FirePlace.position,Canhao.transform.rotation);
		AudioFire.Play ();
		X = 5 * FirePlace.transform.position.x;

		fireTemp.GetComponent<Rigidbody2D> ().velocity = new Vector2 (X,FireVelocity);
		Destroy (fireTemp, 4);
	}


}
