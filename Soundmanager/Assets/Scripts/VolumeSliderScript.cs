using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Pointen med dette Script, er at jeg tilg�r min metode for at �ndre volume "ChangeMasterVolume(val)", og g�r at min Slider UI kan blive brugt for at �ndre volume valuen. 

public class VolumeSliderScript : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    // Start is called before the first frame update
    void Start()
    {
        SoundManager.instance.ChangeMasterVolume(_slider.value);
        _slider.onValueChanged.AddListener(val => SoundManager.instance.ChangeMasterVolume(val));
    }
}
