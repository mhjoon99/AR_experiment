using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1 : MonoBehaviour
{

    int click, nowStage;
    GameObject StageManager;

    void Start()
    {

        StageManager = GameObject.Find("stagenum");
        nowStage = StageManager.GetComponent<SceneChange>().stageNum;


    }
}
