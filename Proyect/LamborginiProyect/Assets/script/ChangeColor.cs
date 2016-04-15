using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChangeColor : MonoBehaviour {

    public Transform CarModel1;
    public Transform CarModel2;
    List<string> elementos = new List<string>();
    void Start()
    {
        elementos.Add("guardabarro");
        elementos.Add("chasisv3");
        elementos.Add("chasis_0");
        elementos.Add("chasis1x (1)");
        elementos.Add("chasis0");
        elementos.Add("cinturon_de_seguridad_2");
        elementos.Add("soporte_de_asiento");
        elementos.Add("baul");
        elementos.Add("capo");
        elementos.Add("chasis_externo");
        elementos.Add("parachoque");
        elementos.Add("puerta_1");
        elementos.Add("puertas_2");
        elementos.Add("chasis2");
        elementos.Add("parte_central_2");

        ChangeColorMaterial(Color.red);
    }
    public void ColorRed() {
        ChangeColorMaterial(Color.red);
    }
    public void ColorYellow()
    {
        ChangeColorMaterial(Color.yellow);
    }
    public void ColorGray()
    {
        ChangeColorMaterial(Color.gray);
    }
    public void ColorBlue()
    {
       
        ChangeColorMaterial(Color.green);
    }
    public void ChangeColorMaterial(Color color) {

        MeshRenderer[] meshRenderer = CarModel1.GetComponentsInChildren<MeshRenderer>(true);
        foreach (MeshRenderer component in meshRenderer)
        {
            for (int i = 0; i < elementos.Count; i++) {
                if (component.name.Equals(elementos[i]))
                {
                    component.sharedMaterial.color = color;
                }

            }

        }
        MeshRenderer[] meshRenderer2 = CarModel2.GetComponentsInChildren<MeshRenderer>(true);
        foreach (MeshRenderer component in meshRenderer2)
        {
            for (int i = 0; i < elementos.Count; i++)
            {
                if (component.name.Equals(elementos[i]))
                {
                    component.sharedMaterial.color = color;
                }

            }
        }
    }
}
