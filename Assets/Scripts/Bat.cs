using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bat : MonoBehaviour {
	
	//Call class Cannon
	private Cannon Canhao;


	// Use this for initialization
	void Start () {
		Canhao = FindObjectOfType (typeof(Cannon))as Cannon;
	}

	//Destroy Bats and Firebomb
	void OnTriggerEnter2D(Collider2D col){
		switch (col.gameObject.tag) {

		case "Fire":
			Destroy (this.gameObject);
			Destroy (col.gameObject);
			Canhao.Poits += 10; 
			break;
		}
	}
}
