using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class copyTime : MonoBehaviour
{
    //variabel static times untuk dapat melakukan passing nilai ke scene yang lainnya
    static float times; 

    //variabel remaining untuk durasi waktu yang dicapai
    int remaining;

    //variabel akan UI text
    [SerializeField] private Text TextMins = default;
    [SerializeField] private Text TextMinsPrint = default;
    [SerializeField] private Text TextMinsPrint1 = default;

    void Start(){

        rema();
        TextMinsPrint.text=remaining.ToString();
        TextMinsPrint1.text=remaining.ToString();
       
    }
    
    void Update(){
        countSize();
    }
   
    //fungsi countSize untuk mengcopy nilai waktu dari teks ke variabel times
    public void countSize()
    {
        times = float.Parse(TextMins.text);
       
    }

    //fungsi rema untuk mengcopy nilai hasil konversi variabel times ke integer dengan pembulatan nilai pada variabel remaining
    public void rema(){
        remaining = (int)Math.Round(times);
    }
    
}

//script copyTime ada pada scene di semua ruangan terapi dan scene QuitScene untuk menampilkan durasi waktu yang dicapai