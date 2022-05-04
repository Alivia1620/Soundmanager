using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Pointen med dette Script, er at jeg tilgår min metode for at ændre volume "ChangeMasterVolume(val)", og gør at min Slider UI kan blive brugt for at ændre volume valuen. 

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
