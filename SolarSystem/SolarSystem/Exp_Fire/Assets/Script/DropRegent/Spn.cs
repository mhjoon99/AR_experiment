using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spn : MonoBehaviour
{
    public GameObject Powder, Spoon, Regent, Plane;


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("충돌");
        Powder.SetActive(true);

    }
    public void Start()
    {
        Powder = GameObject.Find("Powder");
        Spoon = GameObject.Find("Spoon");
        Regent = GameObject.Find("Regent");
        Plane = GameObject.Find("Plane");

        Powder.SetActive(false);
        Plane.SetActive(false);
    }
    public void Update()
    {
        Vector3 spn = Spoon.transform.localPosition;
        Powder.transform.position = spn + new Vector3(-150, -105, -5);

    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("시약 품");
        Regent.SetActive(false);
    }
}