using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManagerF : MonoBehaviour
{
    public Text nameTextF;
    public Text dialogueTextF;
    [Space]
    public bool pegouQuest = false; //ativa ao concluir a quest do NPC vinculado a este Dialogue Manager
    public bool pegouQuest2 = false;
    public bool peoguQUest3 = false;

    //public GameObject quest;
    private Queue<string> sentences;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {

        nameTextF.text = dialogue.name;

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
        dialogueTextF.text = sentence;

    }

    void EndDialogue()
    {
        AperteAquiF aperteG = FindObjectOfType<AperteAquiF>();
        QuestManager quests = FindObjectOfType<QuestManager>();

        /*if (pegouQuest == false)
        {
            quests.grapia += 1;
            quests.ipeRoxo += 1;
            quests.guapuruvu += 1;
            pegouQuest = true;
            quest.SetActive(true);
        }

        quests.questPescador1 = true;
        quests.questDra1 = true;
        quests.questLobo1 = true;*/
        Debug.Log("End of conversation.");
    }
}
