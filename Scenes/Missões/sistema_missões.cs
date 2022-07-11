using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sistema_missões : MonoBehaviour
{
    public GameObject missão;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void abrirMissões()
    {
        missão.SetActive(true);
    }

    public void fecharMissões()
    {
        missão.SetActive(false);
    }
}
