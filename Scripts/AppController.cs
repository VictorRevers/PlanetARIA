using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Vuforia;

public class AppController : MonoBehaviour
{
    [SerializeField]public TMP_Dropdown _dropdown;
    public List<Astro> astrosList;
    public GameObject panel;
    //public GameObject astrosPanel;

    public GameObject panelControlBtn;
    public GameObject MidAirStage;
    public GameObject shownedPlanet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PanelControlBtn(){
        if(panel.activeSelf){
            panel.SetActive(false);
            panelControlBtn.transform.position -= Vector3.up * 950;
        }else{
            panel.SetActive(true);
            panelControlBtn.transform.position += Vector3.up * 950;
        }
    }
    public void AppendAstro(){
        string astroName = PlayerPrefs.GetString("astroName");
        /*if(_dropdown.options[_dropdown.value].text != "ASTROS"){
            Astro astro = astrosList.Find(x => x.name == _dropdown.options[_dropdown.value].text);
            shownedPlanet.transform.PrefabUtility.ApplyPrefabInstace(astro.model3d); 
        }*/
        

        if(/*_dropdown.options[_dropdown.value].text*/ astroName != "ASTROS"){
            //astrosPanel.SetActive(false);
            /*if(MidAirStage.transform.childCount == 1){
                Destroy(MidAirStage.transform.GetChild(0).gameObject);
            }*/
            if(/*_dropdown.options[_dropdown.value].text*/ astroName.Equals("Saturno")){
                shownedPlanet.transform.GetChild(0).gameObject.SetActive(true);
            }else{
                shownedPlanet.transform.GetChild(0).gameObject.SetActive(false);
            }

            Astro astro = astrosList.Find(x => x.name == astroName /*_dropdown.options[_dropdown.value].text*/);
            Debug.Log(astro.name);
            shownedPlanet.GetComponent<MeshRenderer>().material = astro.material;       
            //GameObject astroPrefab = Instantiate(astro.model3d, new Vector3(-651,-1032,10),Quaternion.identity); //web cam position
            /*GameObject astroPrefab = Instantiate(astro.model3d,new Vector3(0,0,0),Quaternion.identity,MidAirStage.transform); //cellphone position  Quaternion.identity
            astroPrefab.transform.localScale = new Vector3(0.08f,0.08f,0.08f);
            astroPrefab.transform.position -= Vector3.left * 0.1f;
            astroPrefab.transform.position += Vector3.forward * 0.3f;
            astroPrefab.transform.position -= Vector3.down * 0.3f;
            //astroPrefab.transform.parent = MidAirStage.transform;
            Debug.Log("ddwn value: "+astro.name);*/
        }/*else{
            if(MidAirStage.transform.childCount == 1){
                Destroy(MidAirStage.transform.GetChild(0).gameObject);
            }
        }*/

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
