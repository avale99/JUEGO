using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameSceneManager : MonoBehaviour
{
    private string mapa="Mapa" ;

    //This was just used to load menu stuff properly and change scenes
    
    public Canvas mainCanvas;
    public Canvas helpCanvas;
    public Canvas helpCanvas2;
    // Start is called before the first frame update
    public void loadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void loadMapSelector()
    {
        SceneManager.LoadScene(1);
    }

    public void loadHelpCanvas()
    {
        mainCanvas.enabled = false;
        helpCanvas.enabled = true;
    }

    public void loadHelpCanvasBack()
    {
        helpCanvas2.enabled = false;
        helpCanvas.enabled = true;
    }

    public void loadHelpCanvas2()
    {
        helpCanvas.enabled = false;
        helpCanvas2.enabled = true;
    }

    public void loadMainCanvas()
    {
        mainCanvas.enabled = true;
        helpCanvas.enabled = false;
        helpCanvas2.enabled = false;
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
