using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volumecontrol : MonoBehaviour
{
    Slider slider;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = audio.volume;
    }

    // Update is called once per frame
    void Update()
    {
        audio.volume = slider.value;
    }
}
