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

    // Use this for initialization
    void Start () {
        //initalizing timer value
        vidTimer = 30.0f;
        //retrieve objects
        MainMenuPanel = GameObject.Find("MainMenuPanel");
        DropinPanel = GameObject.Find("DropinPanel");
        MapPanel = GameObject.Find("MapPanel");
        EventsPanel = GameObject.Find("EventsPanel");
        AttractLoopPanel = GameObject.Find("AttractLoopPanel");
        Background = GameObject.Find("Background");

        AttractLoopPanel.SetActive(true);
        MainMenuPanel.SetActive(false);
        DropinPanel.SetActive(false);
        MapPanel.SetActive(false);
        EventsPanel.SetActive(false);
        Background.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
        vidTimer -= Time.deltaTime;
        if (Input.anyKey)
            vidTimer = 30.0f;
        if (vidTimer < 0)
        {
            AttractLoopPanel.SetActive(true);
            MainMenuPanel.SetActive(false);
            DropinPanel.SetActive(false);
            MapPanel.SetActive(false);
            EventsPanel.SetActive(false);
            Background.SetActive(false);
            vidTimer = 25.0f;

        }
    }
}
