    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AperteAquiE : MonoBehaviour
{
    public int countE = 0;
    public bool textoAjuda = false;

    [Header("Controle de ligar/desligar UI")]
    [Space]
    public GameObject botaoInventario;
    public GameObject botaoLivro;
    public GameObject ui_DialogueE;


    [Header("Chama o inicio das falas do personagem")]

    public Dialogue dialogue;
    public Dialogue dialogue2;
    public Dialogue dialogue3;

    public void ApertouNPC()
    {
        QuestManager quests = FindObjectOfType<QuestManager>();

        if (countE == 0 && quests.questOstra1 == true) //deve mudar a booleana verificada para continuar a próxima quest. (22/06);
        {
            //Debug.Log("ENTROU NO GET KEY E");
            countE++;
            quests.questOstraConcluida = true;
            ui_DialogueE.SetActive(true);
            botaoInventario.SetActive(false);
            botaoLivro.SetActive(false);
            textoAjuda = true;
            FindObjectOfType<DialogueManagerE>().StartDialogue(dialogue);
            //this.gameObject.SetActive(false);
        }

        else if (countE == 1 && textoAjuda)
        {
            ui_DialogueE.SetActive(true);
            botaoInventario.SetActive(false);
            botaoLivro.SetActive(false);
            FindObjectOfType<DialogueManagerE>().StartDialogue(dialogue2);
        }

        else if(quests.nCerejeiras >= 8 && quests.nGuapuruvu >= 8 && quests.nSetecapotes >= 8)
        {
            ui_DialogueE.SetActive(true);
            botaoInventario.SetActive(false);
            botaoLivro.SetActive(false);
            FindObjectOfType<DialogueManagerE>().StartDialogue(dialogue3);
        }
    }
}
