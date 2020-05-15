using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class languageChecker : MonoBehaviour
{
    //variabel static languages untuk mengecek bahasa yang dipakai
    static int languages;
     [SerializeField] private GameObject panelInggris = default;
     [SerializeField] private GameObject panelIndo = default;
     
   
   void Start(){
       check();
   }
   public void languagesss(){
       languages = 1;
   }
   public void bahasa(){
       languages = 2;
   }
   public void check(){
       if(languages==1){
          panelInggris.gameObject.SetActive(true);
       }
       else if(languages==2){
          panelIndo.gameObject.SetActive(true);
       }
   }
}
