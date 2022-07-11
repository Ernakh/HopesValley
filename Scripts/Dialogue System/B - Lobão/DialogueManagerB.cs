using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManagerB : MonoBehaviour
{
    public Text nameTextB;
    public Text dialogueTextB;
    [Space]
    public bool pegouQuest = false; //ativa ao concluir a quest do NPC vinculado a este Dialogue Manager
    public bool pegouQuest2 = false;
    public bool peoguQUest3 = false;
    public GameObject quest;
    private Queue<string> sentences;

    void Start()
    {
        sentences = new Queue<string>();
    }

    private void Update()
    {

    }
    public void StartDialogue(Dialogue dialogue)
    {

        nameTextB.text = dialogue.name;

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
        dialogueTextB.text = sentence;

    }

    void EndDialogue()
    {
        /*AperteAquiB aperteBCount = FindObjectOfType<AperteAquiB>();
        QuestManager quests = FindObjectOfType<QuestManager>();

        if (aperteBCount.countB == 1)
        {
            if(pegouQuest == false && quests.grapia != 0)
            {
                
                pegouQuest = true;
                quest.SetActive(true);
                //quests.grapia -= 1;
                quests.pitangueira += 1;
            }

        }

        if(aperteBCount.countB == 2 && quests.plantouGuapuruvu == true)
        {
            quests.questPescador2 = true;
            quests.questLobo1Concluida = true;  
            quests.questLobo2 = true;
            quests.prerequisitoQuestPesc2 = true;

        }
        /*if (aperteB.countB == 2)
            quests.questLobo2 = true;
        if (aperteB.countB == 3)
            quests.questLobo3 = true;*/
        Debug.Log("End of conversation.");
    }
}
