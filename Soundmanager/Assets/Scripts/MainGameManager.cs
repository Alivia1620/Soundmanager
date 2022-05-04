using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameManager : MonoBehaviour
    
    //MainGameManageren er vores Singleton pattern. For at lave MainGameManageren om til en singleton pattern, skal jeg f�rst omdanne MainGameManegeren til en public static class, som jeg navngiver instance.
    //Det g�r jeg, fordi instance og static betyder at MainGameManageren kun vil blive brugt en gang, alts� �n instance. Det betyder at MainGameManageren ikke kun er bundet til dette script, men ogs� kan blive tilg�et fra
    //andre scripts. Vi skal ikke kun declare MainGameManageren som instance, vi er ogs� n�dt til at initialize den. Her kommer Unity's Awake funktion ind i billedet. Det vil g�re scriptet accesable under alle dele af spillet,
    //fra spillets start til slut. Awake funktionen bliver initialized, f�r noget andet bliver initialized i spillet. 

{
    public static MainGameManager instance;

    private int _currentScore;

    //N�r vi skriver void Awake(){instance = this;}, g�r at instance (som er vores public static MainGameManager member, nu har f�et af vide at den skal inizialeres f�r noget andet, n�r spillet det starter.

    void Awake()
    {
        instance = this;
    }

    //Metoden AdjustScore kan bruges i vores Singleton Pattern, ved at MainGameManageren instance som starter ved Awake, kan hj�lpe PlayerControlleren og EnemyControlleren med at adjuste deres score uden at noget skal �ndres
    //i deres script. Det skal kun �ndres via MainGameManageren. Det er her hvor det smarte, ved en Singleton pattern kommer ind i billedet. F�rst skal vi dog have en Score som kan �ndres, og som man kan se har jeg skrevet den ind,
    //med navnet _currentScore. Den er privat, for som sagt, skal den kun �ndres via MainGameManageren.

    public void AdjustScore(int num)
    {
        _currentScore = _currentScore + num;
    }

    //For at se vores Scores, opretter jeg nu en OnGui void. Den Viser Scoren, oppe i venstre hj�rne af sk�rmen.

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 100), "Score = " + _currentScore);
    }
}
