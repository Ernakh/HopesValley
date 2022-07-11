using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Número de árvores que o jogador contém")]
    [Space]
    public static int ipêroxo = 0; 
    public static int guapuruvu = 0;
    public static int Grapia = 0;
    [Space]
    [Header("Contadores Visuais de UI")]
    [Space]
    public Text contadoripêroxo;
    public Text contadorguapuruvu;
    public Text contadorGrapia;
    
    void Start()
    {
        
    }



    void Update()
    {
        contadoripêroxo.text = ipêroxo.ToString() ;
        contadorguapuruvu.text = guapuruvu.ToString();
        contadorGrapia.text = Grapia.ToString();
    }
}
