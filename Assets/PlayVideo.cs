using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PlayVideo : MonoBehaviour {
    public float vidTimer;
    public GameObject MainMenuPanel;
    public GameObject EventsPanel;
    public GameObject DropinPanel;
    public GameObject MapPanel;
    public GameObject AttractLoopPanel;
    public GameObject Background;
    public GameObject locationPanel;
    public GameObject JPPanel;

    // Use this for initialization
    void Start () {
        //initalizing timer value
        vidTimer = 30.0f;
        /** Extra code in case we need to create references at runtime
        //retrieve objects
        MainMenuPanel = GameObject.Find("MainMenuPanel");
        DropinPanel = GameObject.Find("DropinPanel");
        MapPanel = GameObject.Find("MapPanel");
        EventsPanel = GameObject.Find("EventsPanel");
        AttractLoopPanel = GameObject.Find("AttractLoopPanel");
        Background = GameObject.Find("Background");
        //Set default state
        AttractLoopPanel.SetActive(true);
        MainMenuPanel.SetActive(false);
        DropinPanel.SetActive(false);
        MapPanel.SetActive(false);
        EventsPanel.SetActive(false);
        Background.SetActive(false);
        **/
    }
	
	// Update is called once per frame
	void Update () {
        vidTimer -= Time.deltaTime;
        //check for access 
        if (Input.anyKey)
            vidTimer = 30.0f;
        //check if loop already active 
        if (AttractLoopPanel.activeInHierarchy)
            vidTimer = 30.0f;
        //If timer hits 0, start attract loop
        if (vidTimer < 0)
        {
            AttractLoopPanel.SetActive(true);
            MainMenuPanel.SetActive(false);
            DropinPanel.SetActive(false);
            MapPanel.SetActive(false);
            EventsPanel.SetActive(false);
            Background.SetActive(false);
            locationPanel.SetActive(false);
            JPPanel.SetActive(false);
        }
    }
    
    //Function to reset timer, used in server
    public void resetTimer()
    {
        vidTimer = 30.0f;
    }
}
