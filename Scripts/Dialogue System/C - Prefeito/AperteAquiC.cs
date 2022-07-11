using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AperteAquiC : MonoBehaviour
{
    public int countC = 0;

    [Header("Controle de ligar/desligar UI")]
    [Space]
    public GameObject botaoInventario;
    public GameObject botaoLivro;
    public GameObject ui_DialogueC;

    [Header("Chama o inicio das falas do personagem")]

    public Dialogue dialogue;
    public Dialogue dialogue2;
    public Dialogue dialogue3;


    public void ApertouNPC()
    {
        QuestManager quests = FindObjectOfType<QuestManager>();

        if (countC == 0 && quests.questPref1 == true)
        {
            ui_DialogueC.SetActive(true);
            botaoInventario.SetActive(false);
            botaoLivro.SetActive(false);
            FindObjectOfType<DialogueManagerC>().StartDialogue(dialogue);

            //this.gameObject.SetActive(false);
        }
        if (quests.nCerejeiras == 3 && quests.nGuapuruvu == 3 && quests.nSetecapotes == 3)
        {
            quests.questOstra1 = true;
            ui_DialogueC.SetActive(true);
            botaoInventario.SetActive(false);
            botaoLivro.SetActive(false);
            FindObjectOfType<DialogueManagerC>().StartDialogue(dialogue2);
        }
    }
}
