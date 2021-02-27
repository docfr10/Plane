using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Settigs : MonoBehaviour
{
    public Dropdown dropdown;
    public Toggle toggle;

    Resolution[] res;
    public void Start()
    {
        Screen.fullScreen = true;

        toggle.isOn = false;

        Resolution[] resolution = Screen.resolutions;
        res = resolution.Distinct().ToArray();
        string[] strRes = new string[res.Length];
        for (int i = 0; i < res.Length; i++) 
        {
            strRes[i] = res[i].width.ToString() + "x" + res[i].height.ToString();

        }

        dropdown.ClearOptions();
        dropdown.AddOptions(strRes.ToList());
        dropdown.value = res.Length - 1;

        Screen.SetResolution(res[res.Length - 1].width, res[res.Length - 1].height, Screen.fullScreen);
    }
    void Update()
    {

    }

    public void setRes()
    {
        Screen.SetResolution(res[dropdown.value].width, res[dropdown.value].height, Screen.fullScreen);
    }

    public void FullScreenToggle()
    {
        Screen.fullScreen = !toggle.isOn;
    }
    
    public AudioMixer am;
    public void AudioVolume(float sliderValue)
    {
        am.SetFloat("masterVolume", sliderValue);
    }

    public void Quality(int q)
    {
        QualitySettings.SetQualityLevel(q);
    }


}
