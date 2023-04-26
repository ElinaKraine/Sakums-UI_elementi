using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class atteluParadisana : MonoBehaviour
{
    public GameObject beensImage;
    public GameObject lasisImage;
    public GameObject tanteImage;
    public GameObject carImage;
    public GameObject paKreisiPoga;
    public GameObject paLabiPoga;
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
    public GameObject izmSlaideris;
    public GameObject rotSlaideris;

    public void beensAtelosana(bool vertiba) {
        beensImage.SetActive(vertiba);
        paKreisiPoga.GetComponent<Toggle>().interactable = vertiba;
        paLabiPoga.GetComponent<Toggle>().interactable = vertiba;
    }
    public void lacisAtelosana(bool vertiba) {
        lasisImage.SetActive(vertiba);
    }
    public void tanteAtelosana(bool vertiba) {
        tanteImage.SetActive(vertiba);
    }
    public void carAtelosana(bool vertiba) {
        carImage.SetActive(vertiba);
    }
    public void paKreisiBins() {
        beensImage.transform.localScale = new Vector2(1, 1);
    }
    public void paLabiBins() {
        beensImage.transform.localScale = new Vector2(-1,1);
    }
    public void izkritosais(int skaitlis) {
        if (skaitlis == 0)
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];
        else if (skaitlis == 1)
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];
        else if (skaitlis == 2)
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[2];
        else
            Debug.Log("Nav piesaistīts attēls!");
    }
    public void mainitLielumu(){
        float pasreizejaVertiba = izmSlaideris.GetComponent<Slider>().value;
        mainigaisAttels.transform.localScale = new Vector2(1f * pasreizejaVertiba, 1f * pasreizejaVertiba);
    }
    public void mainitRotaciju(){
        float pasreizejaVertiba = rotSlaideris.GetComponent<Slider>().value;
        mainigaisAttels.transform.localRotation = Quaternion.Euler(0, 0, pasreizejaVertiba*360);
    }

}
