using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AperteAquiD : MonoBehaviour
{
    public int countD = 0;

    [Header("Controle de ligar/desligar UI")]
    public GameObject botaoInventario;
    public GameObject botaoLivro;
    public GameObject ui_DialogueD;

    [Header("Chama o inicio das falas do personagem falas do personagem")]

    public Dialogue dialogueUm;
    public Dialogue dialogueDois;
    public Dialogue dialogueTres;

    public void ApertouNPC()
    {
        QuestManager quests = FindObjectOfType<QuestManager>();

        if (countD == 0)
        {
            countD++;
            ui_DialogueD.SetActive(true);
            botaoInventario.SetActive(false);
            botaoLivro.SetActive(false);
            quests.questPescador1 = true;
            FindObjectOfType<DialogueManagerD>().StartDialogue(dialogueUm);
        }
        /*if (countD == 1 && quests.plantouSeteCapote == true)
        {
            quests.pitangueira += 1;
            //<==============                                         É esta mudança de booleana que demonstra que o dialogo/quest foi concluido.
            countD++;                     //<==============                 A variavel contadora decide qual dialogo vira. Ela foi posta aqui para testes. Deve ser modificada apenas no final da quest.
            FindObjectOfType<DialogueManagerB>().StartDialogue(dialogueDois);
            botaoLivro.SetActive(false);                                        //Foi posta aqui apenas para testes. Ela deve ser trocada ao final da primeira quest.
            botaoInventario.SetActive(false);
            ui_DialogueD.SetActive(true);
            //this.gameObject.SetActive(false);
        }*/
    }
}
