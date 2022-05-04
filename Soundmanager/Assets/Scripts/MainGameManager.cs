using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameManager : MonoBehaviour
    
    //MainGameManageren er vores Singleton pattern. For at lave MainGameManageren om til en singleton pattern, skal jeg først omdanne MainGameManegeren til en public static class, som jeg navngiver instance.
    //Det gør jeg, fordi instance og static betyder at MainGameManageren kun vil blive brugt en gang, altså én instance. Det betyder at MainGameManageren ikke kun er bundet til dette script, men også kan blive tilgået fra
    //andre scripts. Vi skal ikke kun declare MainGameManageren som instance, vi er også nødt til at initialize den. Her kommer Unity's Awake funktion ind i billedet. Det vil gøre scriptet accesable under alle dele af spillet,
    //fra spillets start til slut. Awake funktionen bliver initialized, før noget andet bliver initialized i spillet. 

{
    public static MainGameManager instance;

    private int _currentScore;

    //Når vi skriver void Awake(){instance = this;}, gør at instance (som er vores public static MainGameManager member, nu har fået af vide at den skal inizialeres før noget andet, når spillet det starter.

    void Awake()
    {
        instance = this;
    }

    //Metoden AdjustScore kan bruges i vores Singleton Pattern, ved at MainGameManageren instance som starter ved Awake, kan hjælpe PlayerControlleren og EnemyControlleren med at adjuste deres score uden at noget skal ændres
    //i deres script. Det skal kun ændres via MainGameManageren. Det er her hvor det smarte, ved en Singleton pattern kommer ind i billedet. Først skal vi dog have en Score som kan ændres, og som man kan se har jeg skrevet den ind,
    //med navnet _currentScore. Den er privat, for som sagt, skal den kun ændres via MainGameManageren.

    public void AdjustScore(int num)
    {
        _currentScore = _currentScore + num;
    }

    //For at se vores Scores, opretter jeg nu en OnGui void. Den Viser Scoren, oppe i venstre hjørne af skærmen.

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 100), "Score = " + _currentScore);
    }
}
