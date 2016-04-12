using UnityEngine;
using System.Collections;

public class sound : MonoBehaviour {

	public GameObject sonido;
	public bool bandera;
	// Use this for initialization
	void Start () {
		bandera = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void habilitarSonido(){
		if (bandera) {
			
			sonido.GetComponent<AudioSource> ().Play ();
			bandera = false;
		} else {
			sonido.GetComponent<AudioSource> ().Stop ();
			bandera = true;
		}
	}
}
