using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameSceneManager : MonoBehaviour
{
    private string mapa="Mapa" ;

    public void loadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void loadMapSelector()
    {
        SceneManager.LoadScene(1);
    }

    public void loadSettings()
    {
        SceneManager.LoadScene(3);
    }

    public void cargaMapa1(){
        SceneManager.LoadScene(2);
        PlayerPrefs.SetInt(mapa,1);
    }

    public void cargaMapa2(){
        SceneManager.LoadScene(2);
        PlayerPrefs.SetInt(mapa,2);
    }

    public void cargaMapa3(){
        SceneManager.LoadScene(2);
        PlayerPrefs.SetInt(mapa,3);
    }

    public void exit(){
        Application.Quit();
    }
}
