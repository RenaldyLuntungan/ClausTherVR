using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class therapyInfo : MonoBehaviour
{
    //variabel static roomTherapyType untuk menampung nilai ruangan mana dan level berapa
    static int roomTherapyType;
    //variabel static languages untuk menampung nilai bahasa apa yang digunakan
    static int languages;

    [SerializeField] private GameObject panelEngKT4x4 = default;
    [SerializeField] private GameObject panelEngKT3x3 = default;
    [SerializeField] private GameObject panelEngKT2x3 = default;
    [SerializeField] private GameObject panelEngKT2x2 = default;
    [SerializeField] private GameObject panelEngKTFinish = default;
    [SerializeField] private GameObject panelEngKM2x3 = default;
    [SerializeField] private GameObject panelEngKM2x2 = default;
    [SerializeField] private GameObject panelEngKM15x15 = default;
    [SerializeField] private GameObject panelEngKM1x1 = default;
    [SerializeField] private GameObject panelEngKMFinish = default;
    [SerializeField] private GameObject panelEngLift2x3 = default;
    [SerializeField] private GameObject panelEngLift2x2 = default;
    [SerializeField] private GameObject panelEngLift15x15 = default;
    [SerializeField] private GameObject panelEngLift1x1 = default;
    [SerializeField] private GameObject panelEngLiftFinish = default;

    [SerializeField] private GameObject panelIndoKT4x4 = default;
    [SerializeField] private GameObject panelIndoKT3x3 = default;
    [SerializeField] private GameObject panelIndoKT2x3 = default;
    [SerializeField] private GameObject panelIndoKT2x2 = default;
    [SerializeField] private GameObject panelIndoKTFinish = default;
    [SerializeField] private GameObject panelIndoKM2x3 = default;
    [SerializeField] private GameObject panelIndoKM2x2 = default;
    [SerializeField] private GameObject panelIndoKM15x15 = default;
    [SerializeField] private GameObject panelIndoKM1x1 = default;
    [SerializeField] private GameObject panelIndoKMFinish = default;
    [SerializeField] private GameObject panelIndoLift2x3 = default;
    [SerializeField] private GameObject panelIndoLift2x2 = default;
    [SerializeField] private GameObject panelIndoLift15x15 = default;
    [SerializeField] private GameObject panelIndoLift1x1 = default;
    [SerializeField] private GameObject panelIndoLiftFinish = default;
     

    
    // Start is called before the first frame update

    void Start(){
        hidePanel();
        checkRoom();
    }

    public void kt4x4(){
        roomTherapyType=1;
    }
    public void kt3x3(){
        roomTherapyType=2;
    }
    public void kt2x3(){
        roomTherapyType=3;
    }
    public void kt2x2(){
        roomTherapyType=4;
    }
    public void ktFinish(){
        roomTherapyType= 13;
    }
    public void km2x3(){
        roomTherapyType=5;
    }
    public void km2x2(){
        roomTherapyType=6;
    }
    public void km15x15(){
        roomTherapyType=7;
    }
    public void km1x1(){
        roomTherapyType=8;
    }
    public void kmFinish(){
        roomTherapyType = 14;
    }
    public void lift2x3(){
        roomTherapyType=9;
    }
    public void lift2x2(){
        roomTherapyType=10;
    }
    public void lift15x15(){
        roomTherapyType=11;
    }
    public void lift1x1(){
        roomTherapyType=12;
    }
    public void liftFinish(){
        roomTherapyType =15;
    }

    public void languagesss(){
       languages = 1;
    }
    public void bahasa(){
       languages = 2;
    }

    public void checkRoom(){
        if(roomTherapyType==1&&languages==1){
            panelEngKT4x4.gameObject.SetActive(true);
        }else if(roomTherapyType==2&&languages==1){
            panelEngKT3x3.gameObject.SetActive(true);
        }else if(roomTherapyType==3&&languages==1){
            panelEngKT2x3.gameObject.SetActive(true);
        }else if(roomTherapyType==4&&languages==1){
            panelEngKT2x2.gameObject.SetActive(true);
        }else if(roomTherapyType==5&&languages==1){
            panelEngKM2x3.gameObject.SetActive(true);
        }else if(roomTherapyType==6&&languages==1){
            panelEngKM2x2.gameObject.SetActive(true);
        }else if(roomTherapyType==7&&languages==1){
            panelEngKM15x15.gameObject.SetActive(true);
        }else if(roomTherapyType==8&&languages==1){
            panelEngKM1x1.gameObject.SetActive(true);
        }else if(roomTherapyType==9&&languages==1){
            panelEngLift2x3.gameObject.SetActive(true);
        }else if(roomTherapyType==10&&languages==1){
            panelEngLift2x2.gameObject.SetActive(true);
        }else if(roomTherapyType==11&&languages==1){
            panelEngLift15x15.gameObject.SetActive(true);
        }else if(roomTherapyType==12&&languages==1){
            panelEngLift1x1.gameObject.SetActive(true);
        }else if(roomTherapyType==13&&languages==1){
            panelEngKTFinish.gameObject.SetActive(true);
        }else if(roomTherapyType==14&&languages==1){
            panelEngKMFinish.gameObject.SetActive(true);
        }else if(roomTherapyType==15&&languages==1){
            panelEngLiftFinish.gameObject.SetActive(true);
        }


        else if(roomTherapyType==1&&languages==2){
            panelIndoKT4x4.gameObject.SetActive(true);
        }else if(roomTherapyType==2&&languages==2){
            panelIndoKT3x3.gameObject.SetActive(true);
        }else if(roomTherapyType==3&&languages==2){
            panelIndoKT2x3.gameObject.SetActive(true);
        }else if(roomTherapyType==4&&languages==2){
            panelIndoKT2x2.gameObject.SetActive(true);
        }else if(roomTherapyType==5&&languages==2){
            panelIndoKM2x3.gameObject.SetActive(true);
        }else if(roomTherapyType==6&&languages==2){
            panelIndoKM2x2.gameObject.SetActive(true);
        }else if(roomTherapyType==7&&languages==2){
            panelIndoKM15x15.gameObject.SetActive(true);
        }else if(roomTherapyType==8&&languages==2){
            panelIndoKM1x1.gameObject.SetActive(true);
        }else if(roomTherapyType==9&&languages==2){
            panelIndoLift2x3.gameObject.SetActive(true);
        }else if(roomTherapyType==10&&languages==2){
            panelIndoLift2x2.gameObject.SetActive(true);
        }else if(roomTherapyType==11&&languages==2){
            panelIndoLift15x15.gameObject.SetActive(true);
        }else if(roomTherapyType==12&&languages==2){
            panelIndoLift1x1.gameObject.SetActive(true);
        }else if(roomTherapyType==13&&languages==2){
            panelIndoKTFinish.gameObject.SetActive(true);
        }else if(roomTherapyType==14&&languages==2){
            panelIndoKMFinish.gameObject.SetActive(true);
        }else if(roomTherapyType==15&&languages==2){
            panelIndoLiftFinish.gameObject.SetActive(true);
        }
    }

    public void hidePanel(){
        
            panelEngKT4x4.gameObject.SetActive(false);       
            panelEngKT3x3.gameObject.SetActive(false);       
            panelEngKT2x3.gameObject.SetActive(false);        
            panelEngKT2x2.gameObject.SetActive(false); 
            panelEngKTFinish.gameObject.SetActive(false);     
            panelEngKM2x3.gameObject.SetActive(false);       
            panelEngKM2x2.gameObject.SetActive(false);      
            panelEngKM15x15.gameObject.SetActive(false);     
            panelEngKM1x1.gameObject.SetActive(false);  
            panelEngKMFinish.gameObject.SetActive(false);  
            panelEngLift2x3.gameObject.SetActive(false);        
            panelEngLift2x2.gameObject.SetActive(false);      
            panelEngLift15x15.gameObject.SetActive(false);    
            panelEngLift1x1.gameObject.SetActive(false);

     
            panelIndoKT4x4.gameObject.SetActive(false);     
            panelIndoKT3x3.gameObject.SetActive(false);      
            panelIndoKT2x3.gameObject.SetActive(false);      
            panelIndoKT2x2.gameObject.SetActive(false);
            panelIndoKTFinish.gameObject.SetActive(false); 
            panelIndoKM2x3.gameObject.SetActive(false);      
            panelIndoKM2x2.gameObject.SetActive(false);       
            panelIndoKM15x15.gameObject.SetActive(false);       
            panelIndoKM1x1.gameObject.SetActive(false);
            panelIndoKMFinish.gameObject.SetActive(false);      
            panelIndoLift2x3.gameObject.SetActive(false);       
            panelIndoLift2x2.gameObject.SetActive(false);       
            panelIndoLift15x15.gameObject.SetActive(false);       
            panelIndoLift1x1.gameObject.SetActive(false);
            panelIndoLiftFinish.gameObject.SetActive(false);
        
    }
}
