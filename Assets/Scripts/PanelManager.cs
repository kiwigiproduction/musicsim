using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    [SerializeField]
    private int panelCount = 30;

    public GameObject homePanel;
    public GameObject profilePanel;
    public GameObject lifeStylePanel;
    public GameObject worldPanel;
    public GameObject settingsPanel;

    public GameObject[] panels;
    private GameObject currentPanel;


    public void ProfileClick()
    {
        
        profilePanel.SetActive(true);

        homePanel.SetActive(false);
        lifeStylePanel.SetActive(false);
        worldPanel.SetActive(false);
        settingsPanel.SetActive(false);
        //return gameObject;
    }

    public void BandMembersClick() 
    {
        BadImageFormatException badImageFormatException = new BadImageFormatException();
        
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
        currentPanel = homePanel;

        profilePanel.SetActive(false);
        lifeStylePanel.SetActive(false);
        worldPanel.SetActive(false);
        settingsPanel.SetActive(false);
    }

    public bool check()
    {
        Debug.Log("it's working!");
        if (currentPanel.active == true)
        {
            foreach (GameObject panel in panels)
            {
                panel.SetActive(false); 
            }
            currentPanel.SetActive(true);
        }
        return true;
    }
    // Update is called once per frame
    void Update()
    {
       check();
    }
}
