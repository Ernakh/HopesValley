using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AperteAquiG : MonoBehaviour
{
    public int countG = 0;

    [Header("Controle de ligar/desligar UI")]
    [Space]
    public GameObject botaoInventario;
    public GameObject botaoLivro;
    public GameObject ui_DialogueG;

    [Header("Chama o inicio das falas do personagem")]

    public Dialogue dialogue;
    public Dialogue dialogue2;
    public Dialogue dialogue3;

    public void ApertouNPC()
    {
        QuestManager quests = FindObjectOfType<QuestManager>();

        if (countG == 0 && quests.questPref1 == true)  //deve mudar a booleana verificada para continuar a próxima quest. (22/06);
        {
            //Debug.Log("ENTROU NO GET KEY E");

            DialogueManagerG diag = FindObjectOfType<DialogueManagerG>();
            diag.StartDialogue(dialogue);
            ui_DialogueG.SetActive(true);

            this.gameObject.SetActive(false);
        }
    }
}
