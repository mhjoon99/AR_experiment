using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpFire_Game : MonoBehaviour
{
    public string []reagentList = {"Natrium", "Calcium", "Lithium", "Kalium", "Copper", "Barium"};
    public List<string> chosen = new List<string>(); //랜덤선택된 시약
    public List<string> ans = new List<string>(); //선택된 시약별 색깔
    public Text reagent1, reagent2, reagent3;
    

    void Start()
    {
        reagent1 = GameObject.Find("Canvas").transform.FindChild("reagent1").transform.FindChild("Text").GetComponent<Text>();
        reagent2 = GameObject.Find("Canvas").transform.FindChild("reagent2").transform.FindChild("Text").GetComponent<Text>();
        reagent3 = GameObject.Find("Canvas").transform.FindChild("reagent3").transform.FindChild("Text").GetComponent<Text>();

        GameObject.Find("Canvas").transform.FindChild("explain").gameObject.SetActive(true);
        Invoke("Explain", 3f);
    }

    void Update()
    {
        
    }

    void PickReagent()
    {
        int num = Random.Range(0, 6);
        chosen.Add(reagentList[num]);

        for(int i = 0; i < 2; i++) //reagent3개만 뽑으면 되므로(처음에 그냥1개+for문에서 2개)
        {
            while (chosen.Contains(reagentList[num])) //뽑은리스트에 이미 있으면 다시random돌림
            {
                num = Random.Range(0, 6);
            }
            chosen.Add(reagentList[num]);
        }

        reagent1.text = chosen[0];
        reagent2.text = chosen[1];
        reagent3.text = chosen[2];

        foreach(string item in chosen)
        {
            switch (item)
            {
                case "Natrium"://노랑
                    ans.Add("yellow");

                    break;
                case "Calcium"://주황
                    ans.Add("orange");

                    break;
                case "Lithium"://빨강
                    ans.Add("red");

                    break;
                case "Kalium"://보라
                    ans.Add("purple");

                    break;
                case "Copper"://청록
                    ans.Add("green");

                    break;
                case "Barium"://연두
                    ans.Add("lightgreen");

                    break;
            }
        }

    }

    void Explain()
    {
        GameObject.Find("Canvas").transform.FindChild("explain").gameObject.SetActive(false);
        PickReagent();
    }
}
