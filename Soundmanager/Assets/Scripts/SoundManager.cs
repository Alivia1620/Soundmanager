using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour

    //F�rst g�r laver jeg min SoundManager om til en Singleton Pattern. Singleton Pattern er forklaret i MainGameManager scriptet, s� check det ud for en refresher, 

{
    public string _clip;

    public static SoundManager instance;

    [SerializeField] private AudioSource _musicSource, _effectSource;

    //Som MainGameManageren vil jeg kun have en, som kan bruges og tilg�s igennem hele spillet. Heraf, kommer min void Awake Script.
    //Mit if-else statement siger, hvis der ikke er andre instance i spillet, skal dette v�re det nye instance.
    //DontDestroyOnLoad(gameObject); bliver brugt for at at SoundManageren ikke skal �del�gges, mens den bliver brugt.
    //else siger s�, at hvis der allerede er en instance k�rende, s� skal SoundManageren �del�gges.

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }

    //Nu kommer en vigtig Metode til SoundManager Scriptet, metoden for at man kan spille en lyd. Vi har brug for nogle referencer til denne metode,
    //som jeg skriver �verst i en r�kke [SerializedFields].

    public void PlaySound(AudioClip clip)
    {
        _effectSource.PlayOneShot(clip);
    }

    //Nu kommer n�ste del: Lave en SoundSlider, som man kan tr�kke op og ned, alt efter hvor h�j lyden/musikken skal v�re.
    //Dette er rimelig simpel, for Unity har allerede en AudioListener installeret, som jeg kan inkoporerer i min metode.
    //F�rst danner jeg en float som hedder value, hvor jeg kan skrive alt fra 0-100 ind. Bagefter skriver jeg at metoden skal hidkalde
    //AudioListener.volume = value; Unity ved allerede at hvad volumen er for en st�rrelse, og ved at lydene skal blive h�jere eller lavere, 
    //alt efter hvor mange procent volumen st�r p�.

    public void ChangeMasterVolume(float value)
    {
        AudioListener.volume = value;
    }

    //ToggleEffects metoden h�re til ToggleAudio Scriptet. ! betyder det modsatte, af hvad den burde v�re.

    public void ToggleEffects()
    {
        _effectSource.mute = !_effectSource.mute;
    }
    
    //Jeg g�r nu det samme for musicSourcen.

    public void ToggleMusic()
    {
        _musicSource.mute = !_musicSource.mute;
    }
}
