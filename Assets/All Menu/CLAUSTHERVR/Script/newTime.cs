using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class newTime : MonoBehaviour
{
    static string timesLeft;
    float timer=0;
    [SerializeField] private Text TextMins = default;
    [SerializeField] private Text TextMinsPrint = default;
    [SerializeField] private Text TextMinsPrintKe2 = default;

    void Start(){
        printTime();
    }
    public void getText(){
        timesLeft = TextMins.text;
    }

    public void printTime(){
        timer = float.Parse(timesLeft);
        timer = 120 - timer;
        TextMinsPrint.text = timer.ToString();
        TextMinsPrintKe2.text = timer.ToString();
    }
}
