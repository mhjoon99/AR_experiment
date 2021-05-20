using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DropRegent : MonoBehaviour
{
    public GameObject Powder = GameObject.Find("Powder");
    public GameObject Cotton = GameObject.Find("Cotton");
    public GameObject Spoon = GameObject.Find("Spoon");
    public GameObject Plane = GameObject.Find("Plane");


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("옮김");
        Powder.SetActive(false);
        Plane.SetActive(true);
        SceneManager.LoadScene("SampleScene");

    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("뗌");
        Vector3 CR = Cotton.transform.localPosition;
        Powder.transform.position = CR + new Vector3(0, 1, 0);
    }

    public void Update()
    {
        Vector3 spn = Spoon.transform.localPosition;
        Powder.transform.position = spn + new Vector3(-221, -157, 3);

    }


}
