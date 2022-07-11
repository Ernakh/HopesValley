using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerC : MonoBehaviour
{
    public GameObject aperteAquiC;
    public GameObject ui_Dialog;
    public GameObject botaoLivro;
    public GameObject botaoInventario;

    private void OnTriggerEnter(Collider other)
    {
        if ((other.CompareTag("Player")))
        {
            Debug.Log(other);

            aperteAquiC.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            aperteAquiC.SetActive(false);
            ui_Dialog.SetActive(false);
            botaoLivro.SetActive(true);
            botaoInventario.SetActive(true);
        }
    }
}
