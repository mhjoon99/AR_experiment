using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpFire_Game : MonoBehaviour
{
    public string []reagentList = {"Natrium", "Calcium", "Lithium", "Kalium", "Copper", "Barium"};
    public List<string> chosen = new List<string>(); //�������õ� �þ�
    public List<string> ans = new List<string>(); //���õ� �þະ ����
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

        for(int i = 0; i < 2; i++) //reagent3���� ������ �ǹǷ�(ó���� �׳�1��+for������ 2��)
        {
            while (chosen.Contains(reagentList[num])) //��������Ʈ�� �̹� ������ �ٽ�random����
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
                case "Natrium"://���
                    ans.Add("yellow");

                    break;
                case "Calcium"://��Ȳ
                    ans.Add("orange");

                    break;
                case "Lithium"://����
                    ans.Add("red");

                    break;
                case "Kalium"://����
                    ans.Add("purple");

                    break;
                case "Copper"://û��
                    ans.Add("green");

                    break;
                case "Barium"://����
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
