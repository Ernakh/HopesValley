using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AperteAqui : MonoBehaviour
{
    public int count = 0;

    [Header("Controle de ligar/desligar UI:")]
    [Space]
    public GameObject botaoInventario;
    public GameObject botaoLivro;
    public GameObject ui_Dialogue;
    [Space]
    [Header("Chama o inicio das falas do personagem:")]
    [Space]
    public Dialogue dialogue;
    public Dialogue dialogueDois;
    public Dialogue dialogueTres;
    public Dialogue dialogueConcluido;

    public void AperteNPC()
    {
        QuestManager quests = FindObjectOfType<QuestManager>();

        if (count == 0)
        {
            count++;
            botaoLivro.SetActive(false);
            botaoInventario.SetActive(false);
            ui_Dialogue.SetActive(true);
            quests.questDra1 = true;
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            //gameObject.SetActive(false);
        }

        /* if (count == 1 && quests.plantouCerejeira == true)
        {
            quests.seteCapotes += 1;
            //<==============                                         É esta mudança de booleana que demonstra que o dialogo/quest foi concluido.
            count++;                          //<==============                 A variavel contadora decide qual dialogo vira. Ela foi posta aqui para testes. Deve ser modificada apenas no final da quest.
            botaoLivro.SetActive(false);                                        //Foi posta aqui apenas para testes. Ela deve ser trocada ao final da primeira quest.
            botaoInventario.SetActive(false);
            ui_Dialogue.SetActive(true);
            quests.questDra1 = true;
            FindObjectOfType<DialogueManager>().StartDialogue(dialogueDois);
            //this.gameObject.SetActive(false);
        }*/
    }
}
