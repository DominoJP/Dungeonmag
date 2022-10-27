using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{

    public GameObject MenuPanel;
    public GameObject PanelSelector;

    // Start is called before the first frame update
    void Start()
    {
        MenuPanel.SetActive(true);
        PanelSelector.SetActive(false);
    }

    public void ShowLevelPanel()
    {
        MenuPanel.SetActive(false);
        PanelSelector.SetActive(true);
    }

    public void ShowMenuPanel()
    {
        MenuPanel.SetActive(true);
        PanelSelector.SetActive(false);
    }
}
