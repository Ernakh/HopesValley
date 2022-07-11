using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantationD : MonoBehaviour
{
    [Header("Local e Objetos de plantação")]
    public GameObject Button;
    public GameObject seteCapote;
    public Transform localSpawn;

    public bool temPlanta = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Button.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Button.SetActive(false);
        }
    }

    public void PlantarSeteCapote()
    {
        QuestManager quest = FindObjectOfType<QuestManager>();

        if (!temPlanta && quest.questPescador1 && quest.seteCapotes > 0)
        {
            Instantiate(seteCapote, localSpawn.position, Quaternion.identity);
            quest.seteCapotes--;
            quest.nSetecapotes++;
            quest.plantouSeteCapote = true;
            temPlanta = true;
        }

    }
}
