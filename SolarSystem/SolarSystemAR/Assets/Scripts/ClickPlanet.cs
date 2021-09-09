using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ClickPlanet : MonoBehaviour
{
    public GameObject mercury, venus, earth, mars, jupiter, saturn, uranus, neptune;
    public GameObject messageBox;
    public Text message;
    float timeSpn;
    float checkTime;

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
        messageBox = GameObject.Find("messageBox");
        message = GameObject.Find("message").GetComponent<Text>();

        messageBox.SetActive(false);

        timeSpn = 0;
        checkTime = 3;
    }

    // Update is called once per frame
    void Update()
    {
        onClickPlanet();
    }

    public void onClickPlanet()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.name == "Mercury")
                {
                    Debug.Log("Mercury touched");
                    message.text = "수성은 태양계의 첫 번째 행성이며, 가벼운 가스층 외에 대기가 거의 존재하지 않는다.";
                    messageBox.SetActive(true);
                    timeSpn += Time.deltaTime;

                    if (timeSpn >= checkTime)
                    {
                        messageBox.SetActive(false);
                        timeSpn = 0;
                    }
                }
                if (hit.collider.name == "Venus")
                {
                    Debug.Log("Venus touched");
                    message.text = "금성 대기의 주성분은 이산화탄소이고, 대부분의 행성과는 다르게 반대로 자전을 한다.";
                    messageBox.SetActive(true);
                    timeSpn += Time.deltaTime;

                    if (timeSpn >= checkTime)
                    {
                        messageBox.SetActive(false);
                        timeSpn = 0;
                    }
                }
                if (hit.collider.name == "Earth")
                {
                    Debug.Log("Earth touched");
                    message.text = "우리가 살고 있는 행성이며, 태양계의 세 번째 행성이다.\n" +
                        "지구의 대기는 질소, 산소, 물, 아르곤, 이산화탄소 등으로 이루어져 있다.";
                    messageBox.SetActive(true);
                    timeSpn += Time.deltaTime;

                    if (timeSpn >= checkTime)
                    {
                        messageBox.SetActive(false);
                        timeSpn = 0;
                    }
                }
                if (hit.collider.name == "Mars")
                {
                    Debug.Log("Mars touched");
                    message.text = "화성은 태양계 행성 중 가장 가까이 있다.";
                    messageBox.SetActive(true);
                    timeSpn += Time.deltaTime;

                    if (timeSpn >= checkTime)
                    {
                        messageBox.SetActive(false);
                        timeSpn = 0;
                    }
                }
                if (hit.collider.name == "Jupiter")
                {
                    Debug.Log("Jupiter touched");
                    message.text = "목성은 태양계에서 가장 거대한 행성이며, 가장 빠르게 자전한다.";
                    messageBox.SetActive(true);
                    timeSpn += Time.deltaTime;

                    if (timeSpn >= checkTime)
                    {
                        messageBox.SetActive(false);
                        timeSpn = 0;
                    }
                }
                if (hit.collider.name == "Saturn")
                {
                    Debug.Log("Saturn touched");
                    message.text = "토성은 아름다운 고리를 갖고 있는 행성이다. 목성에 이어 태양계에서 두 번째로 크다.";
                    messageBox.SetActive(true);
                    timeSpn += Time.deltaTime;

                    if (timeSpn >= checkTime)
                    {
                        messageBox.SetActive(false);
                        timeSpn = 0;
                    }
                }
                if (hit.collider.name == "Uranus")
                {
                    Debug.Log("Uranus touched");
                    message.text = "망원경으로 발견된 최초의 행성이며, 천왕성의 대기에는 수소가 약 83%, 헬륨이 15%, 메탄 2% 등이 포함되어 있다고 한다.";
                    messageBox.SetActive(true);
                    timeSpn += Time.deltaTime;

                    if (timeSpn >= checkTime)
                    {
                        messageBox.SetActive(false);
                        timeSpn = 0;
                    }
                }
                if (hit.collider.name == "Neptune")
                {
                    Debug.Log("Neptune touched");
                    message.text = "해왕성은 계산과 예측으로 발견된 행성이다. 해왕성의 대기는 천왕성의 대기와 매우 비슷하며, 온도 또한 천왕성과 비슷하다고 한다.";
                    messageBox.SetActive(true);
                    timeSpn += Time.deltaTime;

                    if (timeSpn >= checkTime)
                    {
                        messageBox.SetActive(false);
                        timeSpn = 0;
                    }
                }
            }
        }
    }
}
