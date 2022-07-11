using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantationB : MonoBehaviour
{
    [Header("Local e Objetos de plantação")]
    public GameObject Button;
    public GameObject guapuruvu;
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

    public void PlantarGuapuruvu()
    {
        QuestManager quest = FindObjectOfType<QuestManager>();

        if (!temPlanta && quest.questLobo1 && quest.guapuruvu > 0)
        {
            Instantiate(guapuruvu, localSpawn.position, Quaternion.identity);
            quest.guapuruvu--;
            quest.nGuapuruvu++;
            quest.plantouGuapuruvu = true;
            temPlanta = true;
        }

    }
}
