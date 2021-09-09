using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selected_Reagent : MonoBehaviour
{
    public static string selectedReagent;

        private void Start()
    {
        selectedReagent = "Barium"; //임의로 설정한 것. 시약선택 Scene으로부터 넘어올 예정.
    }

    /*
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    씬간의 데이터공유를 위해서는 이걸 쓴다. 근데 나는 일단 static으로 해서 스크립트간에서만 쓸 거임.
    */

}
