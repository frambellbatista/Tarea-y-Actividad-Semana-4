using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Jugar(){
		SceneManager.LoadScene("Juego");
	}

		public void Opciones(){
		SceneManager.LoadScene("Opciones");
	}

	public void Salir(){
		Application.Quit();
	}

}
