using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class times : MonoBehaviour
{
    int countDownStartValue = 120;
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        countDownTimer();
    }

    // Update is called once per frame
    void countDownTimer()
    {
        if(countDownStartValue > 0){
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
            timerText.text = spanTime.Minutes + ":"+spanTime.Seconds;
            countDownStartValue--;
            Invoke("countDownTimer",1.0f);
        }
        else{
            timerText.text = "0:0";
        }
        
    }
}
