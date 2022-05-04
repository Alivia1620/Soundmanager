using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    //Fra EnemyControlleren har jeg kopiret void Start() scriptet, som tilgår class "MainGameManager", public static "instance" og metoden "AdjustScore(int num)", som binder PlayerControlleren og EnemyControlleren
    //til MainGameManageren som bruges som en Singleton pattern.

    void Start()
    {
        MainGameManager.instance.AdjustScore(2300);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
