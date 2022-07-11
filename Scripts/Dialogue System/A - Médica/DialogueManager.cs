using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameTextA;
    public Text dialogueTextA;
    [Space]
    public bool pegouQuest1 = false; //ativa ao concluir a quest do NPC vinculado a este Dialogue Manager
    public bool pegouQuest2 = false;
    public bool peoguQUest3 = false;
    public GameObject quest;

    private Queue<string> sentences;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        
            nameTextA.text = dialogue.name;

            sentences.Clear();

            foreach (string sentence in dialogue.sentences)
            {
                sentences.Enqueue(sentence);
            }

            DisplayNextSentence();  
    }

    public void DisplayNextSentence()
    {
        
            if (sentences.Count == 0)
            {
                EndDialogue();
                
                return;
            }

            string sentence = sentences.Dequeue();
            dialogueTextA.text = sentence;

    }

    void EndDialogue()
    {
        // aperte = this.GetComponent<AperteAqui>();

        AperteAqui aperteACount = FindObjectOfType<AperteAqui>();
        QuestManager quests = FindObjectOfType<QuestManager>();

        //IMPORTANTE: aqui conclui-se apenas o primeiro DIALOGO. A quest1 da DRA se conclui no SEGUNDO DIALOGO. Isto ajuda para termos um marcador como pre requisito para quests de outro personagem. 
        if (aperteACount.count == 1)
        {
            if (pegouQuest1 == false && quests.cerejeira != 0)
            {

                pegouQuest1 = true;
                quest.SetActive(true);

                quests.pitangueira += 1; 
            }
        }

        if (aperteACount.count == 2 && quests.plantouCerejeira == true)  //No segundo dialogo que concluise a quest. Assim, libera-se a proxima tb. Mas para isto 
        {
            quests.questLobo2 = true;
            quests.questDra1Concluida = true;
            quests.questDra2 = true;
            quests.prerequisitoQuestLobo2 = true;
        }
        /*if (aperteA.count == 3)
            quests.questDra3 = true;*/
        //FindObjectOfType<AperteAqui>().questUmAceita = true;
        Debug.Log("End of conversation.");
    }
}
