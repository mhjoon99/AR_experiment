using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectAnswer : MonoBehaviour
{
    GameObject mercury, venus, earth, mars, jupiter, saturn, uranus, neptune;
    float timer, delay;
    // Start is called before the first frame update
    void Start()
    {
        mercury = GameObject.Find("Mercury");
        venus = GameObject.Find("Venus");
        earth = GameObject.Find("Earth");
        mars = GameObject.Find("Mars");
        jupiter = GameObject.Find("Jupiter");
        saturn = GameObject.Find("Saturn");
        uranus = GameObject.Find("Uranus");
        neptune = GameObject.Find("Neptune");

        timer = 0.0f;
        delay = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //int checkMercury = mercury.GetComponent<FixMercury>().GetMercury();
        int checkVenus = venus.GetComponent<FixVenus>().GetVenus();
        int checkEarth = earth.GetComponent<FixEarth>().GetEarth();
        int checkMars = mars.GetComponent<FixMars>().GetMars();
        int checkJupiter = jupiter.GetComponent<FixJupiter>().GetJupiter();
        int checkSaturn = saturn.GetComponent<FixSaturn>().GetSaturn();
        int checkUranus = uranus.GetComponent<FixUranus>().GetUranus();
        int checkNeptune = neptune.GetComponent<FixNeptune>().GetNeptune();

        timer += Time.deltaTime;

        if(timer >= delay)
        {
            //Debug.Log("Mercury : " + checkMercury);
            Debug.Log("Venus : " + checkVenus);
            Debug.Log("Earth : " + checkEarth);
            Debug.Log("Mars : " + checkMars);
            Debug.Log("Jupiter : " + checkJupiter);
            Debug.Log("Saturn : " + checkSaturn);
            Debug.Log("Uranus : " + checkUranus);
            Debug.Log("Neptune : " + checkNeptune);

            timer = 0;
        }
    }
}
