
using System;
using UnityEngine;
using UnityEngine.SceneManagement;


public class match_collision : MonoBehaviour
{
    public GameObject fire, panel, match;
    
    int cnt=0;
    void Start()
    {
        fire = GameObject.Find("Magic fire pro yellow");
        panel = GameObject.Find("Panel");
        match = GameObject.Find("Capsule");

    }
    private void Update()
    {
        Vector3 vec = match.transform.localPosition;
        fire.transform.position = vec + new Vector3(0, 45, 45);
    }

    private void OnCollisionEnter(Collision collision)
    { 
        if (cnt == 0) //불 붙이는 시도가 처음이라면
        {
            ++cnt;
            panel.SetActive(true);
            Invoke("Time", 1.2f);
            match.transform.position = new Vector3(469, 254, -320);
            
        }
        else
        {
            fire.SetActive(true);
            Invoke("Load", 3f);
           
        }
        
    }

    void Time()
    {
        panel.SetActive(false);
    }

    void Load()
    {
        SceneManager.LoadScene("ColoredFire");
    }





}
