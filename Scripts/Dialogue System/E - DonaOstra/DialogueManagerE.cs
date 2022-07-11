using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManagerE : MonoBehaviour
{
    public Text nameTextE;
    public Text dialogueTextE;
    [Space]
    public bool pegouQuest = false; //ativa ao concluir a quest do NPC vinculado a este Dialogue Manager
    public bool pegouQuest2 = false;

    //public GameObject quest;
    private Queue<string> sentences;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {

        nameTextE.text = dialogue.name;

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
        dialogueTextE.text = sentence;

    }

    void EndDialogue()
    {
        AperteAquiE aperteE = FindObjectOfType<AperteAquiE>();
        QuestManager quests = FindObjectOfType<QuestManager>();
        if(!pegouQuest && quests.questOstraConcluida)
        {
            pegouQuest = true;
            quests.guapuruvu += 5;
            quests.cerejeira += 5;
            quests.seteCapotes += 5;
        }
    }
}
