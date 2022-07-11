using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaLivro : MonoBehaviour
{
    public GameObject livro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void abrirlivro()
    {
        livro.SetActive(true);
    }

    public void fecharlivro()
    {
        livro.SetActive(false);
    }
}
