using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowNumPlantas : MonoBehaviour
{
    public Text numPlantas;

    void Update()
    {
        numShow();
    }

    void numShow()
    {
        QuestManager questConfig = FindObjectOfType<QuestManager>();
        numPlantas.text = questConfig.cerejeira.ToString();
    }

}
