using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muda2 : MonoBehaviour
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
        if (GameManager.guapuruvu > 0)
        {
            GameManager.guapuruvu--;
        }

    }
}
