using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour {

	//Public variables
	public Transform Bats , Rock , BatsChange;
	public Text ScoreCannon;

	//Private variables
	private Cannon PoinstCannon;
	private float Timer;
	private int WaitingTime, SpawnCont;
	private bool Paused;

	// Use this for initialization
	void Start () {
		Paused = false;
		SpawnCont = 0;
		WaitingTime = 4;
		Instantiate (Bats, Bats.transform.position, Bats.transform.rotation);
		Instantiate (Rock);

	}
	
	// Update is called once per frame
	void Update () {

		//Diferent time for spawn Bats and its moves
		Timer += Time.deltaTime;
		if(Timer >WaitingTime){
			Instantiate (Bats, Bats.transform.position, Bats.transform.rotation);
			SpawnCont += 1;
			Timer = 0;

			if(SpawnCont == 5 || SpawnCont == 10 || SpawnCont == 15){
				WaitingTime-=1;
			}

			if(SpawnCont == 20){
				Bats = BatsChange;
				SpawnCont = 0;
				WaitingTime=4;
			}

		}

		//Key for pauseGame in PC mode
		if(Input.GetKey(KeyCode.P)){
			PauseGame ();
		}
			
	}

	//Class for pause button 
	public void PauseGame(){
		Paused = !Paused;
		if(Paused){
			Time.timeScale = 0;

		} else if(!Paused){
			Time.timeScale = 1;
		}
	}


}
