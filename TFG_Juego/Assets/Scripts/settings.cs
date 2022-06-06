using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.SceneManagement;

public class settings : MonoBehaviour
{
    public AudioMixer controlVolumen;

    public void SetVolume(float volume){
        controlVolumen.SetFloat("volumen", volume);
    }

    public void SetFullScreen(bool isFullScreen){
        Screen.fullScreen = isFullScreen;
    }

    public void loadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
