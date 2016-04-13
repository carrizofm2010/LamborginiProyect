using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {

    public Transform CarModel;
    private enum Chasi { chasisv3, chasis1 ,chasis_0, baul, capo, chasis_externo, parachoque, puerta_1, puertas_2 }
    void Start()
    {
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
        MeshRenderer[] meshRenderer = CarModel.GetComponentsInChildren<MeshRenderer>(true);
        foreach (MeshRenderer component in meshRenderer)
        {
            if (component.name.Equals(Chasi.chasisv3.ToString())) {
                component.sharedMaterial.color = color;
            }
            if (component.name.Equals(Chasi.chasis1.ToString()))
            {
                component.sharedMaterial.color = color;
            }
            if (component.name.Equals(Chasi.chasis_0.ToString()))
            {
                component.sharedMaterial.color = color;
            }
            if (component.name.Equals(Chasi.baul.ToString()))
            {
                component.sharedMaterial.color = color;
            }
            if (component.name.Equals(Chasi.capo.ToString()))
            {
                component.sharedMaterial.color = color;
            }
            if (component.name.Equals(Chasi.chasis_externo.ToString()))
            {
                component.sharedMaterial.color = color;
            }
            if (component.name.Equals(Chasi.parachoque.ToString()))
            {
                component.sharedMaterial.color = color;
            }
            if (component.name.Equals(Chasi.puerta_1.ToString()))
            {
                component.sharedMaterial.color = color;
            }
            if (component.name.Equals(Chasi.puertas_2.ToString()))
            {
                component.sharedMaterial.color = color;
            }

        }
    }
}
