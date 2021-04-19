using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Slider mainSlider;
	public Slider Sfxslider;
    public Toggle musicon;
    void Update()
    {
		if (musicon.isOn==false)
		{
			AudioManager.instance.SetVolume("Music",0);
		}
		else
		{
			AudioManager.instance.SetVolume("Music",mainSlider.value);
		}
		
		AudioManager.instance.SetVolume("click",Sfxslider.value);
		AudioManager.instance.SetVolume("beep1",Sfxslider.value);
        print(musicon.isOn);
    }
    
}
