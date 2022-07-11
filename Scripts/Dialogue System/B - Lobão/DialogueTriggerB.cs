using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerB : MonoBehaviour
{
    [Header("Liga/Desliga a UI")]

    public GameObject aperteAquiB;
    public GameObject ui_DialogB;
    public GameObject botaoLivro;
    public GameObject botaoInventario;

    private void OnTriggerEnter(Collider other)
    {
        if ((other.CompareTag("Player")))
        {
            Debug.Log(other);

            aperteAquiB.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            aperteAquiB.SetActive(false);
            ui_DialogB.SetActive(false);
            botaoLivro.SetActive(true);
            botaoInventario.SetActive(true);
        }
    }
}
