using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBomb : MonoBehaviour {
	
	//Collider for destroy FireBomb when touch rocks
	void OnTriggerEnter2D(Collider2D col){
		switch (col.gameObject.tag) {
		case "Hit":
			Destroy (this.gameObject);
			break;
		}
	}
}
