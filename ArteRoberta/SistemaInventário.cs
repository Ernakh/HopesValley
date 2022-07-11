using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaInventário : MonoBehaviour
{
    public GameObject Inventario;
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
        Inventario.SetActive(true);
    }

    public void fecharInventário()
    {
        Inventario.SetActive(false);
    }
}
