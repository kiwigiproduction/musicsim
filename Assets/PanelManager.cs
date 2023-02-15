using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    public GameObject homePanel;
    public GameObject profilePanel;
    public GameObject lifeStylePanel;
    public GameObject worldPanel;
    public GameObject settingsPanel;

    public void ProfileClick()
    {
        profilePanel.SetActive(true);

        homePanel.SetActive(false);
        lifeStylePanel.SetActive(false);
        worldPanel.SetActive(false);
        settingsPanel.SetActive(false);
    }

    public void HomeClick() 
    {
        homePanel.SetActive(true);

        lifeStylePanel.SetActive(false);
        profilePanel.SetActive(false);
        worldPanel.SetActive(false);
        settingsPanel.SetActive(false);
    }

    public void LifestyleClick()
    {
        lifeStylePanel.SetActive(true);

        homePanel.SetActive(false);
        profilePanel.SetActive(false);
        worldPanel.SetActive(false);
        settingsPanel.SetActive(false);
    }

    public void WorldClick()
    {
        worldPanel.SetActive(true);

        homePanel.SetActive(false);
        profilePanel.SetActive(false);
        lifeStylePanel.SetActive(false);
        settingsPanel.SetActive(false);
    }

    public void SettingsClick()
    {
        settingsPanel.SetActive(true);

        homePanel.SetActive(false);
        profilePanel.SetActive(false);
        lifeStylePanel.SetActive(false);
        worldPanel.SetActive(false);
    }


    // Start is called before the first frame update
    void Start()
    {


        profilePanel.SetActive(false);
        lifeStylePanel.SetActive(false);
        worldPanel.SetActive(false);
        settingsPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
