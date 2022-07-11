using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerD : MonoBehaviour
{
    [Header("Liga/Desliga a UI")]

    public GameObject aperteAquiD;
    public GameObject ui_DialogD;
    public GameObject botaoLivro;
    public GameObject botaoInventario;
    //public GameObject inventario; // <==| USAR PARA DESATIVAR O INVETARIO QUE ABRE AO SAIR DO TRIGGER COM O NPC.

    private void OnTriggerEnter(Collider other)
    {
        if ((other.CompareTag("Player")))
        {
            aperteAquiD.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            aperteAquiD.SetActive(false);
            ui_DialogD.SetActive(false);
            botaoLivro.SetActive(true);
            botaoInventario.SetActive(true);
            //inventario.SetActive(false);
        }
    }
}
