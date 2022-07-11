using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerF : MonoBehaviour
{
    public GameObject aperteAquiF;
    public GameObject ui_Dialog;
    public GameObject botaoLivro;
    public GameObject botaoInventario;

    private void OnTriggerEnter(Collider other)
    {
        if ((other.CompareTag("Player")))
        {
            Debug.Log(other);

            aperteAquiF.SetActive(true);
            botaoLivro.SetActive(false);
            botaoInventario.SetActive(false);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            aperteAquiF.SetActive(false);
            ui_Dialog.SetActive(false);
            botaoLivro.SetActive(true);
            botaoInventario.SetActive(true);
        }
    }
}
