using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StageManager : MonoBehaviour
{
    public SceneChange sc;

    public void OnClickBox()
    {
        string nowbutton = EventSystem.current.currentSelectedGameObject.name;
        if (nowbutton == "K")  
            sc.stageNum = 1;
        else if (nowbutton == "C") 
            sc.stageNum = 2;
        else if (nowbutton == "Ba") 
            sc.stageNum = 3;
        else if (nowbutton == "Li") 
            sc.stageNum = 4;
        else if (nowbutton == "Na")
            sc.stageNum = 5;
        else if (nowbutton == "Cu")
            sc.stageNum = 6;


        if (sc.stageNum != 0) sc.call();
    }
}
