using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update.

    //N�r void Start er sat igang, g�r jeg at vores class "MainGameManager", vores public static "instance" og metoden som skal binde alle tre Scripts sammen "AdjustScore(int num)", bliver tilg�et med det samme.

    void Start()
    {
        MainGameManager.instance.AdjustScore(-1000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
