using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManagerC : MonoBehaviour
{
    public Text nameTextC;
    public Text dialogueTextC;
    [Space]
    public bool pegouQuest = false; //ativa ao concluir a quest do NPC vinculado a este Dialogue Manager
    public bool pegouQuest2 = false;
    public bool peoguQuest3 = false;

    private Queue<string> sentences;
    public GameObject quest;

    void Start()
    {
        sentences = new Queue<string>();
    }

    private void Update()
    {

    }
    public void StartDialogue(Dialogue dialogue)
    {

        nameTextC.text = dialogue.name;

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
        dialogueTextC.text = sentence;

    }

    void EndDialogue()
    {
        AperteAquiC aperteC = FindObjectOfType<AperteAquiC>();
        QuestManager quests = FindObjectOfType<QuestManager>();
        
        if(pegouQuest == false && quests.questOstra1 == false)
        {
            quests.seteCapotes += 3;
            quests.cerejeira += 3;
            quests.guapuruvu += 3;
            pegouQuest = true;
            quest.SetActive(true);
        }

       // quests.questPescador1 = true;
       // quests.questDra1 = true;
       // quests.questLobo1 = true;
        Debug.Log("End of conversation.");
    }
}

