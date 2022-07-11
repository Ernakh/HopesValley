using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    //Numero de árvores de cada tipo que foi plantada. Serve para armazenar o as árvores plantada para que o prefeito libere a segunad leva de quests;
    [Header("Número de árvores plantadas:")]
    [Space]
    public int nCerejeiras = 0;
    public int nGuapuruvu = 0;
    public int nSetecapotes = 0;
    [Space]
    [Header("Controle de conclusão dos diálogos:")]
    [Space]
    public int cerejeira = 0;
    public int guapuruvu = 0;
    public int seteCapotes = 0;
    public int pitangueira = 0;
    /*public int ipeRoxo = 0;
    public int grapia = 0;
    public int salgueiroChorao = 0;
    public int paineraRosa = 0;
    public int chauchau = 0;
    public int cedro = 0;*/
    [Space]
    [Header("Organização quests Prefeito")]
    [Space]
    public bool questPref1 = true;
    public bool questPref2 = false;
    public bool questPref3 = false;
    public bool questPrefConcluida = false;
    [Space]
    [Header("Organização quests Lobo")]
    [Space]
    public bool plantouGuapuruvu = false;
    public bool questLobo1 = false;
    public bool prerequisitoQuestLobo2 = false;

    public bool questLobo1Concluida = false;

    public bool questLobo2 = false;
    public bool prerequisitoQuestLobo3 = false;

    public bool questLobo2Concluida = false;

    public bool questLobo3 = false;
    public bool questLobo3Concluida = false;

    public bool questLoboConcluida= false;
    [Space]
    [Header("Organização quests Dra Perola")]
    [Space]
    public bool plantouCerejeira = false;
    public bool questDra1 = false;
    public bool prerequisitoQuestDra2 = false;

    public bool questDra1Concluida = false;

    public bool questDra2 = false;
    public bool prerequisitoQuestDra3 = false;

    public bool questDra2Concluida = false;

    public bool questDra3 = false;
    public bool questDra3Concluida = false;

    public bool fullDraConcluida = false;
    [Space]
    [Header("Organização quests Pescador")]
    [Space]
    public bool plantouSeteCapote = false;
    public bool questPescador1 = false;
    public bool prerequisitoQuestPesc2 = false;

    public bool questPesc1Concluida = false;

    public bool questPescador2 = false;
    public bool prerequisitoQuestPesc3 = false;

    public bool questPesc2Concluida = false;

    public bool questPescador3 = false;
    public bool questpescadorConcluida = false;
    
    [Header("Organização quests Ostra")]
    [Space]
    public bool questOstra1 = false;
    public bool questOstra2 = false;
    public bool questOstra3 = false;
    public bool questOstraConcluida = false;
    
    /*[Header("Organização quests Dona Rita")]
    [Space]
    public bool questRita1 = false;
    public bool questRita2 = false;
    public bool questRita3 = false;
    public bool questRitaConcluida = false;
    [Space]
    [Header("Organização quests Bugiu")]
    [Space]
    public bool questBugiu1 = false;
    public bool questBugiu2 = false;
    public bool questBugiu3 = false;
    public bool questBugiuConcluida = false;
    [Space]
    [Space]
    [Header("Organização quests Girafa")]
    [Space]
    public bool questGirafa1 = false;
    public bool questGirafa2 = false;
    public bool questGirafa3 = false;
    public bool questGiradaConcluida = false;*/
}
