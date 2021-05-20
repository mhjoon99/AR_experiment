using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spn : MonoBehaviour
{
    public GameObject Powder = GameObject.Find("Powder");
    public GameObject Spoon = GameObject.Find("Spoon");
    public GameObject Regent = GameObject.Find("Regent");


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("충돌");
        Powder.SetActive(true);

    }
    
    public void Update()
    {
        Vector3 spn = Spoon.transform.localPosition;
        Powder.transform.position = spn + new Vector3(-221, -157, 3);

    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("시약 품");
        Regent.SetActive(false);
    }
}