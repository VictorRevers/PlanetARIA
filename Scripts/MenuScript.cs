using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class MenuScript : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject astrosPanel;
    public GameObject astroPagePanel;
    public GameObject appController;
    public TMP_Text astroName;
    public TMP_Text astroDescriptionTXT;
    public Image astroImage;
    public GameObject arCanvas;
    public GameObject arCamera;
    public GameObject arStage;
    public GameObject gptPage;

    public GameObject about;
    public GameObject credits;


    private Astro astro;
    public void setAstroPagePanel(TMP_Text astroName){
        astrosPanel.SetActive(false);
        astroPagePanel.SetActive(true);
        PlayerPrefs.SetString("astroName", astroName.text);
        this.astroName.text = astroName.text;
        Astro astro = appController.GetComponent<AppController>().astrosList.Find(x => x.name == astroName.text);
        astroImage.sprite = astro.photo;
        astroDescriptionTXT.text = astro.description; 
        Debug.Log(astroName.text);
        appController.GetComponent<AppController>().AppendAstro();

    }



    public void BackToMainMenu(){
        if(astrosPanel.activeSelf){
            astrosPanel.SetActive(false);
        }else if(credits.activeSelf){
            credits.SetActive(false);
        }else if(about.activeSelf){
            about.SetActive(false);
        }
        
        mainMenu.SetActive(true);
    }

    public void BackToAstrosLists(){
        if(gptPage.activeSelf){
            gptPage.SetActive(false);        
        }else{
            astroPagePanel.SetActive(false);
            arCanvas.SetActive(false);
            arCamera.SetActive(false);
            arStage.SetActive(false);
        }
        
        astrosPanel.SetActive(true);
    }

    public void GoToCredits(){
        mainMenu.SetActive(false);
        credits.SetActive(true);
    }

    public void GoToAbout(){
        mainMenu.SetActive(false);
        about.SetActive(true);
    }

    public void GoToAr(){
        astroPagePanel.SetActive(false);
        arCanvas.SetActive(true);
        arCamera.SetActive(true);
        arStage.SetActive(true);
        
    }

    public void GoToAstros(){
        mainMenu.SetActive(false);
        astrosPanel.SetActive(true);
        appController.GetComponent<AppController>().AppendAstro();
    }

    public void GoToGPT(){
        astroPagePanel.SetActive(false);
        gptPage.SetActive(true);
    }
}
