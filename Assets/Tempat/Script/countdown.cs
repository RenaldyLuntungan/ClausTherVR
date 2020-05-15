using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdown : MonoBehaviour
{
    //variabel static timeCount untuk dapat melakukan passing nilai ke scene yang lainnya
    static float timeCount;

    //variabel untuk gameObject yang ada pada scene
    [SerializeField] private Text uiText = default;
    [SerializeField] private Text TextMin = default;
    [SerializeField] private float mainTimer = default;
    [SerializeField] private Button buttonExit = default;
    [SerializeField] private Button buttonNext = default;
    [SerializeField] private Button buttonKeluar = default;
    [SerializeField] private Button buttonLanjut = default;
    

    private float timer;
    private bool canCount = true;
    private bool doOnce = false;
   
    void Start(){
        
        timer= mainTimer;
        buttonExit.onClick.AddListener(ClickExit);
        buttonKeluar.onClick.AddListener(ClickExit);
    
    }
    // Update is called once per frame
    void Update()
    {
       if (timer >=0.0f &&canCount){
           timer -= Time.deltaTime;
           uiText.text = timer.ToString("F");
       } 

       else if(timer <=0.0f && !doOnce){
           canCount =false;
           doOnce = true;
           uiText.text= "0.00";
           timer = 0.0f;
           buttonNext.gameObject.SetActive(true);
           buttonLanjut.gameObject.SetActive(true);
           timeCount = 120.00f;
           TextMin.text = timeCount.ToString();
       } 
    }

    //fungsi ClickExit dipanggil ketika user memilih tombol exit pada environment terapi
    void ClickExit(){
        canCount=false;
        timeCount = 120.00f - float.Parse(uiText.text);
        TextMin.text=timeCount.ToString();  
    }
    
    
}
