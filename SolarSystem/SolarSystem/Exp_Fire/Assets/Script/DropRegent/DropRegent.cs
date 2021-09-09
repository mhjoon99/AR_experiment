using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DropRegent : MonoBehaviour
{
    public GameObject Powder, Cotton, Spoon, Plane;


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("옮김");
        Powder.SetActive(false);
        Plane.SetActive(true);
        SceneManager.LoadScene("BurnMatch");

    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("뗌");
        Vector3 CR = Cotton.transform.localPosition;
        Powder.transform.position = CR + new Vector3(0, 1, 0);
    }
    public void Start()
    {
        Powder = GameObject.Find("Powder");
        Cotton = GameObject.Find("Cotton");
        Spoon = GameObject.Find("Spoon");
        Plane = GameObject.Find("Plane");

        Powder.SetActive(false);
        Plane.SetActive(false);
    }
    public void Update()
    {
        Vector3 spn = Spoon.transform.localPosition;
        Powder.transform.position = spn + new Vector3(-150, -105, 5);

    }


}
