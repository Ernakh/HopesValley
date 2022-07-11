using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plantation : MonoBehaviour
{
    [Header("Local e Objetos de plantação")]
    public GameObject Button;
    public GameObject cerejeira;
    public Transform localSpawn;

    public bool temPlanta = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
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

    public void PlantarCerejeira()
    {
        QuestManager quest = FindObjectOfType<QuestManager>();

        if (!temPlanta && quest.questDra1 && quest.cerejeira > 0)
        {
            Instantiate(cerejeira, localSpawn.position, Quaternion.identity);
            quest.cerejeira--;
            quest.nCerejeiras++;
            quest.plantouCerejeira = true;
            temPlanta = true;
        }
    }
}

