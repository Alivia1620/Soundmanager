using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnStart : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;

    // Start is called before the first frame update

    //Som i PlayerController og EnemyController Scriptet, bruger jeg void start til at tilgå vores class "SoundManager", vores public static "instance" og vores metode "PlaySound(_clip);

    void Start()
    {
        SoundManager.instance.PlaySound(_clip);
    }
}
