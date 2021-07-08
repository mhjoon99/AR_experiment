using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class match_collision : MonoBehaviour
{
    public GameObject fire, panel, match;
    int cnt = 0;

    void Start()
    {
        fire = GameObject.Find("Magic fire pro yellow");
        panel = GameObject.Find("Panel");
        match = GameObject.Find("Match");
    }

    private void Update()
    {
        Vector3 vec = match.transform.localPosition;
        GameObject.Find("PFire").transform.FindChild("Magic fire pro yellow").gameObject.transform.position = vec + new Vector3(0,100, -95);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Match")
        {
            if (cnt == 0) //불 붙이는 시도가 처음이라면
            {
                ++cnt;
                GameObject.Find("Canvas").transform.FindChild("Panel").gameObject.SetActive(true);
                Invoke("Time", 1.2f);
                match.transform.position = new Vector3(688, 15, 148);

            }
            else
            {
                GameObject.Find("PFire").transform.FindChild("Magic fire pro yellow").gameObject.SetActive(true);
            }
        }
        

    }

    void Time()
    {
        GameObject.Find("Canvas").transform.FindChild("Panel").gameObject.SetActive(false);
    }
}
