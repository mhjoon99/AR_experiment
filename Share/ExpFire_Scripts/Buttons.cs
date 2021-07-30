using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Buttons : MonoBehaviour
{
    public GameObject red, orange, yellow, green, lightgreen, purple;
    public GameObject redFire, orangeFire, yellowFire, greenFire, lightgreenFire, purpleFire;
    public GameObject submit, rePaint;
    public GameObject match;
    public GameObject o, x;

    public List<string> color = new List<string> {"red", "orange", "yellow", "green", "lightgreen", "purple"};
    public string curColor = ""; 

    public Cotton_Collision cottonScript;
    public ExpFire_Game expFire_Game_Script;


    void Start()
    {
        red = GameObject.Find("Canvas").transform.FindChild("palette").transform.FindChild("red").gameObject;
        orange = GameObject.Find("Canvas").transform.FindChild("palette").transform.FindChild("orange").gameObject;
        yellow = GameObject.Find("Canvas").transform.FindChild("palette").transform.FindChild("yellow").gameObject;
        green = GameObject.Find("Canvas").transform.FindChild("palette").transform.FindChild("green").gameObject;
        lightgreen = GameObject.Find("Canvas").transform.FindChild("palette").transform.FindChild("lightgreen").gameObject;
        purple = GameObject.Find("Canvas").transform.FindChild("palette").transform.FindChild("purple").gameObject;
        rePaint = GameObject.Find("Canvas").transform.FindChild("palette").transform.FindChild("rePaint").gameObject;
        submit = GameObject.Find("Canvas").transform.FindChild("submit").gameObject;
        o = GameObject.Find("Canvas").transform.FindChild("O").gameObject;
        x = GameObject.Find("Canvas").transform.FindChild("X").gameObject;

        match = GameObject.Find("Match");
        
        redFire = GameObject.Find("PFire").transform.FindChild("Magic fire pro red").gameObject;
        orangeFire = GameObject.Find("PFire").transform.FindChild("Magic fire pro orange").gameObject;
        yellowFire = GameObject.Find("PFire").transform.FindChild("Magic fire pro yellow").gameObject;
        greenFire = GameObject.Find("PFire").transform.FindChild("Magic fire pro green").gameObject;
        lightgreenFire = GameObject.Find("PFire").transform.FindChild("Magic fire pro lightGreen").gameObject;
        purpleFire = GameObject.Find("PFire").transform.FindChild("Magic fire pro purple").gameObject;

        cottonScript = GameObject.Find("WoolScripts").GetComponent<Cotton_Collision>();
        expFire_Game_Script = GameObject.Find("ExpFire_Game").GetComponent<ExpFire_Game>();
    }

    void Update()
    {
        redFire.gameObject.transform.position = match.transform.position + new Vector3((float)-0.5, (float)2.2, 0);
        orangeFire.gameObject.transform.position = match.transform.position + new Vector3((float)-0.5, (float)2.2, 0);
        yellowFire.gameObject.transform.position = match.transform.position + new Vector3((float)-0.5, (float)2.2, 0);
        greenFire.gameObject.transform.position = match.transform.position + new Vector3((float)-0.5, (float)2.2, 0);
        lightgreenFire.gameObject.transform.position = match.transform.position + new Vector3((float)-0.5, (float)2.2, 0);
        purpleFire.gameObject.transform.position = match.transform.position + new Vector3((float)-0.5, (float)2.2, 0); 
    }

    public void OnClickColor()
    {
        curColor = EventSystem.current.currentSelectedGameObject.name;

        redFire.SetActive(false); //여기 그냥 PFire.setActive(false)해도 되려나? 일단 pass
        orangeFire.SetActive(false);
        yellowFire.SetActive(false);
        greenFire.SetActive(false);
        lightgreenFire.SetActive(false);
        purpleFire.SetActive(false);

        switch (curColor)
        {
            case "red":
                redFire.SetActive(true);
                break;
            case "orange":
                orangeFire.SetActive(true);
                break;
            case "yellow":
                yellowFire.SetActive(true);
                break;
            case "green":
                greenFire.SetActive(true);
                break;
            case "lightgreen":
                lightgreenFire.SetActive(true);
                break;
            case "purple":
                purpleFire.SetActive(true);
                break;
        }
    }

    public void OnClickRepaint() //다시칠하기버튼, 다시하기 버튼 둘 다 이 리스너를 사용.
    {
        cottonScript.playerAns.Clear();

        match.transform.position = new Vector3(11, 3, 1);

        redFire.SetActive(false);
        orangeFire.SetActive(false);
        yellowFire.SetActive(false);
        greenFire.SetActive(false);
        lightgreenFire.SetActive(false);
        purpleFire.SetActive(false);

        cottonScript.redFire.SetActive(false);
        cottonScript.orangeFire.SetActive(false);
        cottonScript.yellowFire.SetActive(false);
        cottonScript.greenFire.SetActive(false);
        cottonScript.greenFire.SetActive(false);
        cottonScript.lightgreenFire.SetActive(false);
        cottonScript.purpleFire.SetActive(false);

        x.SetActive(false);
        o.SetActive(false);
    }
    public void OnClickSubmit()
    {
       

        if (expFire_Game_Script.ans.Equals(cottonScript.playerAns))
        {
            o.SetActive(true);//정답패널
        }
        else
        {
            x.SetActive(true);//오답패널

            //요아래로는 확인용.. 
            string answer = "";
            string player = "";
            foreach(string item in expFire_Game_Script.ans)
            {
                answer += item;
            }
            foreach (string item in cottonScript.playerAns)
            {
                player += item;
            }

            Debug.Log(answer);
            Debug.Log(player); 
        }
    }

    public void OnClickGoHome()
    {
        //목록으로 버튼 클릭 시. 메인화면으로 돌아간다.
    }

}
