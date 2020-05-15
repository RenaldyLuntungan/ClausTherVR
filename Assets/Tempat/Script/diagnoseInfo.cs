using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diagnoseInfo : MonoBehaviour
{
    //variabel static roomDiagnoseType untuk menampung nilai level ruangan diagnosa yang sedang berjalan
    static int roomDiagnoseType;

    //variabel static languages untuk mengecek bahasa yang dipakai , languages==1 inggris, languages==2 indonesia
    static int languages;

    //variabel gameobject akan panel bahasa inggris
    [SerializeField] private GameObject panelEngRK6x5 = default;
    [SerializeField] private GameObject panelEngRK5x5 = default;
    [SerializeField] private GameObject panelEngRK5x4 = default;
    [SerializeField] private GameObject panelEngRK4x4 = default;
    [SerializeField] private GameObject panelEngRK4x3 = default;
    [SerializeField] private GameObject panelEngRK3x3 = default;
    [SerializeField] private GameObject panelEngRK3x2 = default;
    [SerializeField] private GameObject panelEngRK2x2 = default;
    [SerializeField] private GameObject panelEngRK2x1 = default;
    [SerializeField] private GameObject panelEngRK1x1 = default;
    [SerializeField] private GameObject panelEngGejala = default;
    [SerializeField] private GameObject panelEngRKFinish = default;
    
    //variabel gameobject akan panel bahasa indonesia
    [SerializeField] private GameObject panelIndoRK6x5 = default;
    [SerializeField] private GameObject panelIndoRK5x5 = default;
    [SerializeField] private GameObject panelIndoRK5x4 = default;
    [SerializeField] private GameObject panelIndoRK4x4 = default;
    [SerializeField] private GameObject panelIndoRK4x3 = default;
    [SerializeField] private GameObject panelIndoRK3x3 = default;
    [SerializeField] private GameObject panelIndoRK3x2 = default;
    [SerializeField] private GameObject panelIndoRK2x2 = default;
    [SerializeField] private GameObject panelIndoRK2x1 = default;
    [SerializeField] private GameObject panelIndoRK1x1 = default;
    [SerializeField] private GameObject panelIndoGejala = default;
    [SerializeField] private GameObject panelIndoRKFinish = default;
    
     

    
    // Start is called before the first frame update

    void Start(){
        hidePanel();
        checkRoom();
        gejalaShow();

    }

    public void RK6x5(){
        roomDiagnoseType=1;
    }
    public void RK5x5(){
        roomDiagnoseType=2;
    }
    public void RK5x4(){
        roomDiagnoseType=3;
    }
    public void RK4x4(){
        roomDiagnoseType=4;
    }
    public void RK4x3(){
        roomDiagnoseType=5;
    }
    public void RK3x3(){
        roomDiagnoseType=6;
    }
    public void RK3x2(){
        roomDiagnoseType=7;
    }
    public void RK2x2(){
        roomDiagnoseType=8;
    }
    public void RK2x1(){
        roomDiagnoseType=9;
    }
    public void RK1x1(){
        roomDiagnoseType=10;
    }
    public void RKFinish(){
        roomDiagnoseType=11;
    }
    
    //fungsi languagesss untuk menggunakan bahasa inggris yang dipilih pada button english di menu awal
    public void languagesss(){
       languages = 1;
    }
    //fungsi bahasa untuk menggunakan bahasa indonesia yang dipilih pada button indonesia di menu awal
    public void bahasa(){
       languages = 2;
    }

    //fungsi checkRoom untuk menampilkan informasi diagnosa dengan kondisi level dan bahasa apa yang sedang diapakai
    public void checkRoom(){
        if(roomDiagnoseType==1&&languages==1){
            panelEngRK6x5.gameObject.SetActive(true);
        }else if(roomDiagnoseType==2&&languages==1){
            panelEngRK5x5.gameObject.SetActive(true);
        }else if(roomDiagnoseType==3&&languages==1){
            panelEngRK5x4.gameObject.SetActive(true);
        }else if(roomDiagnoseType==4&&languages==1){
            panelEngRK4x4.gameObject.SetActive(true);
        }else if(roomDiagnoseType==5&&languages==1){
            panelEngRK4x3.gameObject.SetActive(true);
        }else if(roomDiagnoseType==6&&languages==1){
            panelEngRK3x3.gameObject.SetActive(true);
        }else if(roomDiagnoseType==7&&languages==1){
            panelEngRK3x2.gameObject.SetActive(true);
        }else if(roomDiagnoseType==8&&languages==1){
            panelEngRK2x2.gameObject.SetActive(true);
        }else if(roomDiagnoseType==9&&languages==1){
            panelEngRK2x1.gameObject.SetActive(true);
        }else if(roomDiagnoseType==10&&languages==1){
            panelEngRK1x1.gameObject.SetActive(true);
        }else if(roomDiagnoseType==11&&languages==1){
            panelEngRKFinish.gameObject.SetActive(true);
        }

        else if(roomDiagnoseType==1&&languages==2){
            panelIndoRK6x5.gameObject.SetActive(true);
        }else if(roomDiagnoseType==2&&languages==2){
            panelIndoRK5x5.gameObject.SetActive(true);
        }else if(roomDiagnoseType==3&&languages==2){
            panelIndoRK5x4.gameObject.SetActive(true);
        }else if(roomDiagnoseType==4&&languages==2){
            panelIndoRK4x4.gameObject.SetActive(true);
        }else if(roomDiagnoseType==5&&languages==2){
            panelIndoRK4x3.gameObject.SetActive(true);
        }else if(roomDiagnoseType==6&&languages==2){
            panelIndoRK3x3.gameObject.SetActive(true);
        }else if(roomDiagnoseType==7&&languages==2){
            panelIndoRK3x2.gameObject.SetActive(true);
        }else if(roomDiagnoseType==8&&languages==2){
            panelIndoRK2x2.gameObject.SetActive(true);
        }else if(roomDiagnoseType==9&&languages==2){
            panelIndoRK2x1.gameObject.SetActive(true);
        }else if(roomDiagnoseType==10&&languages==2){
            panelIndoRK1x1.gameObject.SetActive(true);
        }else if(roomDiagnoseType==11&&languages==2){
            panelIndoRKFinish.gameObject.SetActive(true);
        }
    }

    //fungsi hidePanel untuk menhide semua panel pada scene FeedbackScene
    public void hidePanel(){
        
            panelEngRK6x5.gameObject.SetActive(false);       
            panelEngRK5x5.gameObject.SetActive(false);       
            panelEngRK5x4.gameObject.SetActive(false);        
            panelEngRK4x4.gameObject.SetActive(false);      
            panelEngRK4x3.gameObject.SetActive(false);       
            panelEngRK3x3.gameObject.SetActive(false);      
            panelEngRK3x2.gameObject.SetActive(false);     
            panelEngRK2x2.gameObject.SetActive(false);    
            panelEngRK2x1.gameObject.SetActive(false);        
            panelEngRK1x1.gameObject.SetActive(false);     
            panelEngGejala.gameObject.SetActive(false);
            panelEngRKFinish.gameObject.SetActive(false);  
            
     
            panelIndoRK6x5.gameObject.SetActive(false);     
            panelIndoRK5x5.gameObject.SetActive(false);      
            panelIndoRK5x4.gameObject.SetActive(false);      
            panelIndoRK4x4.gameObject.SetActive(false); 
            panelIndoRK4x3.gameObject.SetActive(false);      
            panelIndoRK3x3.gameObject.SetActive(false);       
            panelIndoRK3x2.gameObject.SetActive(false);       
            panelIndoRK2x2.gameObject.SetActive(false);      
            panelIndoRK2x1.gameObject.SetActive(false);       
            panelIndoRK1x1.gameObject.SetActive(false);   
            panelIndoGejala.gameObject.SetActive(false);  
            panelIndoRKFinish.gameObject.SetActive(false);         
        
    }

    //fungsi gejalaShow untuk menampilkan info gejala dengan kondisi bahasa apa yang digunakan
    public void gejalaShow(){
        if(languages==1){
            panelEngGejala.gameObject.SetActive(true);
        }
        else if(languages==2){
            panelIndoGejala.gameObject.SetActive(true);
        }
    }


}
