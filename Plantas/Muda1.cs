using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muda1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        print("oi");
        if (GameManager.Grapia > 0)
        {
            GameManager.Grapia--;
            GameManager.guapuruvu++;
        }
        

    }
}
