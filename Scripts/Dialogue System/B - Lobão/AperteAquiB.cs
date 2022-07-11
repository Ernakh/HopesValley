using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AperteAquiB : MonoBehaviour
{

    public int countB = 0;

    [Header("Controle de ligar/desligar UI")]
    public GameObject botaoInventario;
    public GameObject botaoLivro;
    public GameObject ui_DialogueB;

    [Header("Chama o inicio das falas do personagem falas do personagem")]

    public Dialogue dialogueUm;
    public Dialogue dialogueDois;
    public Dialogue dialogueTres;

    public void AperteNPC()
    {
        QuestManager quests = FindObjectOfType<QuestManager>();

        if (countB == 0)
        {
            countB++;
            ui_DialogueB.SetActive(true);
            botaoInventario.SetActive(false);
            botaoLivro.SetActive(false);
            quests.questLobo1 = true;
            FindObjectOfType<DialogueManagerB>().StartDialogue(dialogueUm);
        }
        if (countB == 1 && quests.plantouGuapuruvu == true)
        {
            quests.pitangueira += 1;
            //<==============                                         É esta mudança de booleana que demonstra que o dialogo/quest foi concluido.
            countB++;                          //<==============                 A variavel contadora decide qual dialogo vira. Ela foi posta aqui para testes. Deve ser modificada apenas no final da quest.
            botaoLivro.SetActive(false);                                        //Foi posta aqui apenas para testes. Ela deve ser trocada ao final da primeira quest.
            botaoInventario.SetActive(false);
            ui_DialogueB.SetActive(true);
            FindObjectOfType<DialogueManagerB>().StartDialogue(dialogueDois);
            //this.gameObject.SetActive(false);
        }
    }
}

