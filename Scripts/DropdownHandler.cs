using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropdownHandler : MonoBehaviour
{
    //public List<AstronomicalObjct> astrosList;
    [SerializeField] private  TMP_Dropdown dropdown;
    // Start is called before the first frame update
    void Start()
    {
        //dropdown = dropdownGO.transform.GetComponent<Dropdown>();
    }

    public void AppendAstro(){
        Debug.Log("ddwn value: "+dropdown.value);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
