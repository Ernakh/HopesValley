using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paginalivro : MonoBehaviour
{
    public GameObject Livro; 
    public GameObject Livro2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void abrirInventario()
    {
        Livro2.SetActive(true);
    }

    public void fecharInventário()
    {
        Livro.SetActive(false);
    }
}
