using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour

    //Først gør laver jeg min SoundManager om til en Singleton Pattern. Singleton Pattern er forklaret i MainGameManager scriptet, så check det ud for en refresher, 

{
    public string _clip;

    public static SoundManager instance;

    [SerializeField] private AudioSource _musicSource, _effectSource;

    //Som MainGameManageren vil jeg kun have en, som kan bruges og tilgås igennem hele spillet. Heraf, kommer min void Awake Script.
    //Mit if-else statement siger, hvis der ikke er andre instance i spillet, skal dette være det nye instance.
    //DontDestroyOnLoad(gameObject); bliver brugt for at at SoundManageren ikke skal ødelægges, mens den bliver brugt.
    //else siger så, at hvis der allerede er en instance kørende, så skal SoundManageren ødelægges.

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
    //som jeg skriver øverst i en række [SerializedFields].

    public void PlaySound(AudioClip clip)
    {
        _effectSource.PlayOneShot(clip);
    }

    //Nu kommer næste del: Lave en SoundSlider, som man kan trække op og ned, alt efter hvor høj lyden/musikken skal være.
    //Dette er rimelig simpel, for Unity har allerede en AudioListener installeret, som jeg kan inkoporerer i min metode.
    //Først danner jeg en float som hedder value, hvor jeg kan skrive alt fra 0-100 ind. Bagefter skriver jeg at metoden skal hidkalde
    //AudioListener.volume = value; Unity ved allerede at hvad volumen er for en størrelse, og ved at lydene skal blive højere eller lavere, 
    //alt efter hvor mange procent volumen står på.

    public void ChangeMasterVolume(float value)
    {
        AudioListener.volume = value;
    }

    //ToggleEffects metoden høre til ToggleAudio Scriptet. ! betyder det modsatte, af hvad den burde være.

    public void ToggleEffects()
    {
        _effectSource.mute = !_effectSource.mute;
    }
    
    //Jeg gør nu det samme for musicSourcen.

    public void ToggleMusic()
    {
        _musicSource.mute = !_musicSource.mute;
    }
}
