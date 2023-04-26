using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ainuParsledzeja : MonoBehaviour {
    //Metode ļauj pārslēgties no UI ainas uz Sākuma ainu
    public void uzSakums(){
        SceneManager.LoadScene("Sakums", LoadSceneMode.Single);
    }
    //Metode, kura aizver programmu, ja tā ir izveidota kā .exe
    public void Apturet(){
        Application.Quit();
    }
    public void uzUIainu(){
        SceneManager.LoadScene("UIelementi", LoadSceneMode.Single);
    }
}
