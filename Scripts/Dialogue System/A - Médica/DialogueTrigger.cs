using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject aperteAqui;
    public GameObject ui_Dialog;
    public GameObject botaoLivro;
    public GameObject botaoInventario;

    private void OnTriggerEnter(Collider other)
    {
        if ((other.CompareTag("Player")))
        {
            Debug.Log(other);

            aperteAqui.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            aperteAqui.SetActive(false);
            ui_Dialog.SetActive(false);
            botaoLivro.SetActive(true);
            botaoInventario.SetActive(true);
        }
    }
}
