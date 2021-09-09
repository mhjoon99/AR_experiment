using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class SelectMaterial : MonoBehaviour
{
    public GameObject cube1, cube2, cube3;
    public GameObject submit, messageBox;
    public GameObject retry, next;
    public Text message;

    public List<int> answerList = new List<int>();
    public List<int> clickedList = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        cube1 = GameObject.Find("Cube1");
        cube2 = GameObject.Find("Cube2");
        cube3 = GameObject.Find("Cube3");
        submit = GameObject.Find("Submit");
        messageBox = GameObject.Find("messageBox");
        retry = GameObject.Find("Retry");
        next = GameObject.Find("Next");
        message = GameObject.Find("message").GetComponent<Text>();

        messageBox.SetActive(false);
        submit.SetActive(true);
        submit.GetComponent<Button>().interactable = false;

        setAnswerList();
    }

    // Update is called once per frame
    void Update()
    {
        onClickMaterial();
        activeSubmit();
    }

    public void setAnswerList()
    {
        answerList.Add(1);
        answerList.Add(3);
    }

    public void activeSubmit()
    {
        if (clickedList.Count != 0)
            submit.GetComponent<Button>().interactable = true;
    }

    public void onClickMaterial()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.name == "Cube1")
                {
                    Debug.Log("Cube 1 touched");
                    if (clickedList.Contains(1))
                    {
                        clickedList.Remove(1);
                        if (!clickedList.Contains(1))
                        {
                            Debug.Log("Removed Cube1");
                        }
                    }
                    else if (!clickedList.Contains(1))
                    {
                        clickedList.Add(1);
                        if (clickedList.Contains(1))
                        {
                            Debug.Log("Added Cube1");
                        }
                    }
                    foreach (var x in clickedList)
                    {
                        Debug.Log(x.ToString());
                    }
                }
                else if (hit.collider.name == "Cube2")
                {
                    Debug.Log("Cube 2 touched");
                    if (clickedList.Contains(2))
                    {
                        clickedList.Remove(2);
                        if (!clickedList.Contains(2))
                        {
                            Debug.Log("Removed Cube2");
                        }
                    }
                    else if (!clickedList.Contains(2))
                    {
                        clickedList.Add(2);
                        if (clickedList.Contains(2))
                        {
                            Debug.Log("Added Cube2");
                        }
                    }
                    foreach (var x in clickedList)
                    {
                        Debug.Log(x.ToString());
                    }

                }
                else if (hit.collider.name == "Cube3")
                {
                    Debug.Log("Cube 3 touched");
                    if (clickedList.Contains(3))
                    {
                        clickedList.Remove(3);
                        if (!clickedList.Contains(3))
                        {
                            Debug.Log("Removed Cube3");
                        }
                    }
                    else if (!clickedList.Contains(3))
                    {
                        clickedList.Add(3);
                        if (clickedList.Contains(3))
                        {
                            Debug.Log("Added Cube3");
                        }
                    }
                    foreach (var x in clickedList)
                    {
                        Debug.Log(x.ToString());
                    }
                }
            }
        }
    }

    public void onClickSubmit()
    {
        clickedList.Sort();
        answerList.Sort();

        if (clickedList.SequenceEqual(answerList))
        {
            messageBox.SetActive(true);
            message.text = "정답입니다!";
            retry.SetActive(false);
            next.SetActive(true);
        }
        else
        {
            messageBox.SetActive(true);
            message.text = "정답이 아닙니다. 다시 한 번 생각해보세요!";
            retry.SetActive(true);
            next.SetActive(false);
        }
    }
    public void onClickRetry()
    {
        clickedList.Clear();
        messageBox.SetActive(false);
    }
    public void onclickNext()
    {
        clickedList.Clear();
        //다음 scene으로 넘어가는 code 작성...
    }
}