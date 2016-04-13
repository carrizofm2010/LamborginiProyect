using UnityEngine;
using System.Collections;

public class ControllerBar : MonoBehaviour {

    public Transform PanelBar;
    public bool showPanelBar;
    void Start()
    {
        PanelBar.gameObject.SetActive(false);
    }
    public void ShowOrHiddeBar()
    {
        PanelBar.gameObject.SetActive(showPanelBar);
        showPanelBar = !showPanelBar;
    }
}
