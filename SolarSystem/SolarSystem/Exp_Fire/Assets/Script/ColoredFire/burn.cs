using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burn : MonoBehaviour
{
    public GameObject yellowFire, orangeFire, redFire, purpleFire, greenFire, lightGreenFire;
    public GameObject StageManager;
    int nowStage;

    private void Start()
    {
        yellowFire = GameObject.Find("Magic fire pro yellow");
        orangeFire = GameObject.Find("Magic fire pro orange");
        redFire = GameObject.Find("Magic fire pro red");
        purpleFire = GameObject.Find("Magic fire pro purple");
        greenFire = GameObject.Find("Magic fire pro green");
        lightGreenFire = GameObject.Find("Magic fire pro lightGreen");
    }
    public void OnCollisionEnter(Collision collision)
    {


        StageManager = GameObject.Find("stagenum");
        nowStage = StageManager.GetComponent<SceneChange>().stageNum;

        switch (nowStage)
        {
            case 1://º¸¶ó
                purpleFire.SetActive(true);

                break;
            case 2://ÁÖÈ²
                orangeFire.SetActive(true);

                break;
            case 3://¿¬µÎ
                lightGreenFire.SetActive(true);

                break;
            case 4://»¡°­
                redFire.SetActive(true);

                break;
            case 5://³ë¶û
                yellowFire.SetActive(true);
                
                break;
            case 6://Ã»·Ï
                greenFire.SetActive(true);

                break;
            
        }
        //1-Ä®·ý,2-Ä®½·,3-¹Ù·ý,4-¸®Æ¬,5-³ªÆ®·ý,6-±¸¸®
    }

}
