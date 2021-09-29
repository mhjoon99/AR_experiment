using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Cotton_Collision : MonoBehaviour
{
    public GameObject redFire, orangeFire, yellowFire, greenFire, lightgreenFire, purpleFire;
    public Buttons buttonsScript;
    public List<string> playerAns = new List<string>();

    void Start()
    {
        redFire = GameObject.Find("CottonFire").transform.FindChild("Magic fire pro red").gameObject;
        orangeFire = GameObject.Find("CottonFire").transform.FindChild("Magic fire pro orange").gameObject;
        yellowFire = GameObject.Find("CottonFire").transform.FindChild("Magic fire pro yellow").gameObject;
        greenFire = GameObject.Find("CottonFire").transform.FindChild("Magic fire pro green").gameObject;
        lightgreenFire = GameObject.Find("CottonFire").transform.FindChild("Magic fire pro lightGreen").gameObject;
        purpleFire = GameObject.Find("CottonFire").transform.FindChild("Magic fire pro purple").gameObject;

        buttonsScript = GameObject.Find("ButtonScripts").GetComponent<Buttons>();
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        string cur = this.name;
        if (cur=="Wool_Large1")
        {
            playerAns.Add(buttonsScript.curColor);
        }
        if (cur=="Wool_Large2")
        {
            playerAns.Add(buttonsScript.curColor);
        }
        if (cur=="Wool_Large3")
        {
            playerAns.Add(buttonsScript.curColor);
        }
        

        switch (buttonsScript.curColor)
        {
            case "red":
                redFire.gameObject.transform.position = this.transform.position;
                redFire.SetActive(true);
                break;
            case "orange":
                orangeFire.gameObject.transform.position = this.transform.position;
                orangeFire.SetActive(true);
                break;
            case "yellow":
                yellowFire.gameObject.transform.position = this.transform.position;
                yellowFire.SetActive(true);
                break;
            case "green":
                greenFire.gameObject.transform.position = this.transform.position;
                greenFire.SetActive(true);
                break;
            case "lightgreen":
                lightgreenFire.gameObject.transform.position = this.transform.position;
                lightgreenFire.SetActive(true);
                break;
            case "purple":
                purpleFire.gameObject.transform.position = this.transform.position;
                purpleFire.SetActive(true);
                break;
        }
    }
}
