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

}
