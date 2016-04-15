using UnityEngine;
using System.Collections;

public class cambiarPosicion : MonoBehaviour {

	public bool inicial=true;
	public GameObject personaje;
	public GameObject personaje2;

	// Use this for initialization
	void Start () {
        personaje.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        personaje.transform.localPosition = new Vector3(0f, 0f, 0f);

        personaje2.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        personaje2.transform.localPosition = new Vector3(0f, 0f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
	


	}
	public void downButton(){
		inicial = !inicial;
		if (!inicial){
			personaje.transform.rotation = Quaternion.Euler(-90f, 180f, 0f);
			personaje.transform.localPosition = new Vector3 (0.0f, 0.38f, 0.01f);
			personaje2.transform.rotation = Quaternion.Euler(-90f, 180f, 0f);
			personaje2.transform.localPosition = new Vector3 (0.0f, 0.38f, 0.01f);
		}
		if (inicial){
			personaje.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
			personaje.transform.localPosition = new Vector3 (0f, 0f, 0f);

			personaje2.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
			personaje2.transform.localPosition = new Vector3 (0f, 0f, 0f);
			
		}
	}
}
