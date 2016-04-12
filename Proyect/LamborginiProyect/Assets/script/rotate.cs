using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	// Use this for initialization
	public GameObject personaje;
	public GameObject personaje2;

//	public GameObject sonido;
//	public GameObject sonido2;
	public static bool noSound;

	private bool derecha;
	private bool izquierda;
	void Start () {
		izquierda = false;
		derecha = false;
		noSound = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(derecha){
			girarDerecha();
		}
		if(izquierda){
			girarIzquierda();
		}

//		if( !noSound){
//			sonido.GetComponent<AudioSource>().Stop ();
//
//		}
	}

	public void rotarDerechaDown(){
		derecha = true;
	}
	public void rotarDerechaUp(){
		derecha = false;
	}

	public void rotarIzquierdaDown(){
		izquierda = true;
	}
	public void rotarIzquierdaUp(){
		izquierda = false;
	}

	public  void girarDerecha (){
		noSound = true;
//		sonido.GetComponent<AudioSource>().Play ();
//		sonido2.GetComponent<AudioSource>().Play ();
		personaje.transform.Rotate (new Vector3 (0,-45, 0) * Time.deltaTime* 5);
		personaje2.transform.Rotate (new Vector3 (0,-45, 0) * Time.deltaTime* 5);

	}
	public  void girarIzquierda (){
		noSound = true;
//		sonido.GetComponent<AudioSource>().Play ();
//		sonido2.GetComponent<AudioSource>().Play ();
		personaje.transform.Rotate (new Vector3 (0,45, 0) * Time.deltaTime* 5);
		personaje2.transform.Rotate (new Vector3 (0,45, 0) * Time.deltaTime* 5);
	}
}
