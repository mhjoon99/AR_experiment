using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burn : MonoBehaviour
{
    public GameObject yellowFire, orangeFire, redFire, purpleFire, greenFire, lightGreenFire;
    public GameObject match, fire;
    private void Start()
    {
        yellowFire = GameObject.Find("PFire").transform.FindChild("Magic fire pro yellow").gameObject;
        orangeFire = GameObject.Find("PFire").transform.FindChild("Magic fire pro orange").gameObject;
        redFire = GameObject.Find("PFire").transform.FindChild("Magic fire pro red").gameObject;
        purpleFire = GameObject.Find("PFire").transform.FindChild("Magic fire pro purple").gameObject;
        greenFire = GameObject.Find("PFire").transform.FindChild("Magic fire pro green").gameObject;
        lightGreenFire = GameObject.Find("PFire").transform.FindChild("Magic fire pro lightgreen").gameObject;

        match = GameObject.Find("Match");
        fire = GameObject.Find("PFire").transform.FindChild("fire").gameObject;
    }

    private void Update()
    {
       Vector3 vec = match.transform.localPosition;
       fire.gameObject.transform.position = vec + new Vector3((float)0.05,(float)0.15, (float)-0.5);
    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("충돌");
        string selectedReagent = "Natrium";//임의로 한 거. 앞씬으로부터 넘도록 수정할 계획. 
        //StageManager = GameObject.Find("stagenum");
        //nowStage = StageManager.GetComponent<SceneChange>().stageNum;
        //switch (nowStage)  case 1: ~~                    !!!!!!!이런식으로 넘겨받게 할 것임.

        switch (selectedReagent)
        {
            case "Natrium"://노랑
                yellowFire.SetActive(true);
                
                break;
            case "Calcium"://주황
                orangeFire.SetActive(true);
                
                break;
            case "Lithium"://빨강
                redFire.SetActive(true);
                
                break;
            case "Kalium"://보라
                purpleFire.SetActive(true);

                break;
            case "Copper"://청록
                greenFire.SetActive(true);

                break;
            case "Barium"://연두
                lightGreenFire.SetActive(true);

                break;
        }

    }

}
