using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	// Use this for initialization
	public GameObject personaje;

	private bool derecha;
	private bool izquierda;
	void Start () {
		izquierda = false;
		derecha = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		if(derecha){
			girarDerecha();
		}
		if(izquierda){
			girarIzquierda();
		}
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
		personaje.transform.Rotate (new Vector3 (0,-45, 0) * Time.deltaTime* 5);
	}
	public  void girarIzquierda (){
		personaje.transform.Rotate (new Vector3 (0,45, 0) * Time.deltaTime* 5);
	}
}
