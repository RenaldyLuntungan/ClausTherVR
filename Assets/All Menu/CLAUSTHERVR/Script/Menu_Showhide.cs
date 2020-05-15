using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Showhide : MonoBehaviour
{
    static int languageShow;

    public GameObject BahasaPanel;
    public GameObject MenuEngPanel;
    public GameObject MenuIndPanel;
    public GameObject StartEngPanel;
    public GameObject TherapyEngPanel;
    public GameObject SelfDiagEngPanel;
    public GameObject AboutEngPanel;
    public GameObject HelpEngPanel;
    public GameObject StartIndPanel;
    public GameObject TherapyIndPanel;
    public GameObject SelfDiagIndPanel;
    public GameObject AboutIndPanel;
    public GameObject HelpIndPanel;

    public GameObject SureEngPanel;
    public GameObject SureIndPanel;


    // Start is called before the first frame update
    void Start()
    {
       checkLanguage();
    }

    void checkLanguage(){
        if(languageShow==1){
            BtnEngClicked();
        }
        else if(languageShow==2){
            BtnIndClicked();
        }
    }

    public void languagesss(){
       languageShow = 1;
    }
    public void bahasa(){
       languageShow = 2;
    }

    /*public void Btn_EnId_Clicked()
    {
        BahasaPanel.SetActive(true);
        MenuEngPanel.SetActive(false);
        StartEngPanel.SetActive(false);
        TherapyEngPanel.SetActive(false);
        SelfDiagEngPanel.SetActive(false);
        AboutEngPanel.SetActive(false);
        HelpEngPanel.SetActive(false);

        MenuIndPanel.SetActive(false);
        StartIndPanel.SetActive(false);
        TherapyIndPanel.SetActive(false);
        SelfDiagIndPanel.SetActive(false);
        AboutIndPanel.SetActive(false);
        HelpIndPanel.SetActive(false);

        SureEngPanel.SetActive(false);
        SureIndPanel.SetActive(false);
    }*/

    public void BtnEngClicked()
    {
        BahasaPanel.SetActive(false);

        MenuEngPanel.SetActive(true);
        StartEngPanel.SetActive(false);
        TherapyEngPanel.SetActive(false);
        SelfDiagEngPanel.SetActive(false);
        AboutEngPanel.SetActive(false);
        HelpEngPanel.SetActive(false);

        MenuIndPanel.SetActive(false);
        StartIndPanel.SetActive(false);
        TherapyIndPanel.SetActive(false);
        SelfDiagIndPanel.SetActive(false);
        AboutIndPanel.SetActive(false);
        HelpIndPanel.SetActive(false);

        SureEngPanel.SetActive(false);
        SureIndPanel.SetActive(false);
    }

    public void BtnIndClicked()
    {
        BahasaPanel.SetActive(false);

        MenuEngPanel.SetActive(false);
        StartEngPanel.SetActive(false);
        TherapyEngPanel.SetActive(false);
        SelfDiagEngPanel.SetActive(false);
        AboutEngPanel.SetActive(false);
        HelpEngPanel.SetActive(false);

        MenuIndPanel.SetActive(true);
        StartIndPanel.SetActive(false);
        TherapyIndPanel.SetActive(false);
        SelfDiagIndPanel.SetActive(false);
        AboutIndPanel.SetActive(false);
        HelpIndPanel.SetActive(false);

        SureEngPanel.SetActive(false);
        SureIndPanel.SetActive(false);
    }

    public void Btn_Start_Eng_Clicked()
    {
        BahasaPanel.SetActive(false);

        MenuEngPanel.SetActive(false);
        StartEngPanel.SetActive(true);
        TherapyEngPanel.SetActive(false);
        SelfDiagEngPanel.SetActive(false);
        AboutEngPanel.SetActive(false);
        HelpEngPanel.SetActive(false);

        MenuIndPanel.SetActive(false);
        StartIndPanel.SetActive(false);
        TherapyIndPanel.SetActive(false);
        SelfDiagIndPanel.SetActive(false);
        AboutIndPanel.SetActive(false);
        HelpIndPanel.SetActive(false);

        SureEngPanel.SetActive(false);
        SureIndPanel.SetActive(false);
    }

    public void Btn_Therapy_Eng_Clicked()
    {
        BahasaPanel.SetActive(false);

        MenuEngPanel.SetActive(false);
        StartEngPanel.SetActive(false);
        TherapyEngPanel.SetActive(true);
        SelfDiagEngPanel.SetActive(false);
        AboutEngPanel.SetActive(false);
        HelpEngPanel.SetActive(false);

        MenuIndPanel.SetActive(false);
        StartIndPanel.SetActive(false);
        TherapyIndPanel.SetActive(false);
        SelfDiagIndPanel.SetActive(false);
        AboutIndPanel.SetActive(false);
        HelpIndPanel.SetActive(false);

        SureEngPanel.SetActive(false);
        SureIndPanel.SetActive(false);
    }

    public void Btn_SlfDiag_Eng_Clicked()
    {
        BahasaPanel.SetActive(false);

        MenuEngPanel.SetActive(false);
        StartEngPanel.SetActive(false);
        TherapyEngPanel.SetActive(false);
        SelfDiagEngPanel.SetActive(true);
        AboutEngPanel.SetActive(false);
        HelpEngPanel.SetActive(false);

        MenuIndPanel.SetActive(false);
        StartIndPanel.SetActive(false);
        TherapyIndPanel.SetActive(false);
        SelfDiagIndPanel.SetActive(false);
        AboutIndPanel.SetActive(false);
        HelpIndPanel.SetActive(false);

        SureEngPanel.SetActive(false);
        SureIndPanel.SetActive(false);
    }

    public void Btn_About_Eng_Clicked()
    {
        BahasaPanel.SetActive(false);

        MenuEngPanel.SetActive(false);
        StartEngPanel.SetActive(false);
        TherapyEngPanel.SetActive(false);
        SelfDiagEngPanel.SetActive(false);
        AboutEngPanel.SetActive(true);
        HelpEngPanel.SetActive(false);

        MenuIndPanel.SetActive(false);
        StartIndPanel.SetActive(false);
        TherapyIndPanel.SetActive(false);
        SelfDiagIndPanel.SetActive(false);
        AboutIndPanel.SetActive(false);
        HelpIndPanel.SetActive(false);

        SureEngPanel.SetActive(false);
        SureIndPanel.SetActive(false);
    }

    public void Btn_Help_Eng_Clicked()
    {
        BahasaPanel.SetActive(false);

        MenuEngPanel.SetActive(false);
        StartEngPanel.SetActive(false);
        TherapyEngPanel.SetActive(false);
        SelfDiagEngPanel.SetActive(false);
        AboutEngPanel.SetActive(false);
        HelpEngPanel.SetActive(true);

        MenuIndPanel.SetActive(false);
        StartIndPanel.SetActive(false);
        TherapyIndPanel.SetActive(false);
        SelfDiagIndPanel.SetActive(false);
        AboutIndPanel.SetActive(false);
        HelpIndPanel.SetActive(false);

        SureEngPanel.SetActive(false);
        SureIndPanel.SetActive(false);
    }

    public void Btn_BackMain_Eng_Clicked()
    {
        BahasaPanel.SetActive(false);

        MenuEngPanel.SetActive(true);
        StartEngPanel.SetActive(false);
        TherapyEngPanel.SetActive(false);
        SelfDiagEngPanel.SetActive(false);
        AboutEngPanel.SetActive(false);
        HelpEngPanel.SetActive(false);

        MenuIndPanel.SetActive(false);
        StartIndPanel.SetActive(false);
        TherapyIndPanel.SetActive(false);
        SelfDiagIndPanel.SetActive(false);
        AboutIndPanel.SetActive(false);
        HelpIndPanel.SetActive(false);

        SureEngPanel.SetActive(false);
        SureIndPanel.SetActive(false);
    }

    public void Btn_BackStart_Eng_Clicked()
    {
        BahasaPanel.SetActive(false);

        MenuEngPanel.SetActive(false);
        StartEngPanel.SetActive(true);
        TherapyEngPanel.SetActive(false);
        SelfDiagEngPanel.SetActive(false);
        AboutEngPanel.SetActive(false);
        HelpEngPanel.SetActive(false);

        MenuIndPanel.SetActive(false);
        StartIndPanel.SetActive(false);
        TherapyIndPanel.SetActive(false);
        SelfDiagIndPanel.SetActive(false);
        AboutIndPanel.SetActive(false);
        HelpIndPanel.SetActive(false);

        SureEngPanel.SetActive(false);
        SureIndPanel.SetActive(false);
    }


    //-------------------------------------------

    public void Btn_Start_Ind_Clicked()
    {
        BahasaPanel.SetActive(false);

        MenuEngPanel.SetActive(false);
        StartEngPanel.SetActive(false);
        TherapyEngPanel.SetActive(false);
        SelfDiagEngPanel.SetActive(false);
        AboutEngPanel.SetActive(false);
        HelpEngPanel.SetActive(false);

        MenuIndPanel.SetActive(false);
        StartIndPanel.SetActive(true);
        TherapyIndPanel.SetActive(false);
        SelfDiagIndPanel.SetActive(false);
        AboutIndPanel.SetActive(false);
        HelpIndPanel.SetActive(false);

        SureEngPanel.SetActive(false);
        SureIndPanel.SetActive(false);
    }

    public void Btn_Therapy_Ind_Clicked()
    {
        BahasaPanel.SetActive(false);

        MenuEngPanel.SetActive(false);
        StartEngPanel.SetActive(false);
        TherapyEngPanel.SetActive(false);
        SelfDiagEngPanel.SetActive(false);
        AboutEngPanel.SetActive(false);
        HelpEngPanel.SetActive(false);

        MenuIndPanel.SetActive(false);
        StartIndPanel.SetActive(false);
        TherapyIndPanel.SetActive(true);
        SelfDiagIndPanel.SetActive(false);
        AboutIndPanel.SetActive(false);
        HelpIndPanel.SetActive(false);

        SureEngPanel.SetActive(false);
        SureIndPanel.SetActive(false);
    }

    public void Btn_SlfDiag_Ind_Clicked()
    {
        BahasaPanel.SetActive(false);

        MenuEngPanel.SetActive(false);
        StartEngPanel.SetActive(false);
        TherapyEngPanel.SetActive(false);
        SelfDiagEngPanel.SetActive(false);
        AboutEngPanel.SetActive(false);
        HelpEngPanel.SetActive(false);

        MenuIndPanel.SetActive(false);
        StartIndPanel.SetActive(false);
        TherapyIndPanel.SetActive(false);
        SelfDiagIndPanel.SetActive(true);
        AboutIndPanel.SetActive(false);
        HelpIndPanel.SetActive(false);

        SureEngPanel.SetActive(false);
        SureIndPanel.SetActive(false);
    }

    public void Btn_About_Ind_Clicked()
    {
        BahasaPanel.SetActive(false);

        MenuEngPanel.SetActive(false);
        StartEngPanel.SetActive(false);
        TherapyEngPanel.SetActive(false);
        SelfDiagEngPanel.SetActive(false);
        AboutEngPanel.SetActive(false);
        HelpEngPanel.SetActive(false);

        MenuIndPanel.SetActive(false);
        StartIndPanel.SetActive(false);
        TherapyIndPanel.SetActive(false);
        SelfDiagIndPanel.SetActive(false);
        AboutIndPanel.SetActive(true);
        HelpIndPanel.SetActive(false);

        SureEngPanel.SetActive(false);
        SureIndPanel.SetActive(false);
    }

    public void Btn_Help_Ind_Clicked()
    {
        BahasaPanel.SetActive(false);

        MenuEngPanel.SetActive(false);
        StartEngPanel.SetActive(false);
        TherapyEngPanel.SetActive(false);
        SelfDiagEngPanel.SetActive(false);
        AboutEngPanel.SetActive(false);
        HelpEngPanel.SetActive(false);

        MenuIndPanel.SetActive(false);
        StartIndPanel.SetActive(false);
        TherapyIndPanel.SetActive(false);
        SelfDiagIndPanel.SetActive(false);
        AboutIndPanel.SetActive(false);
        HelpIndPanel.SetActive(true);

        SureEngPanel.SetActive(false);
        SureIndPanel.SetActive(false);
    }

    public void Btn_BackMain_Ind_Clicked()
    {
        BahasaPanel.SetActive(false);

        MenuEngPanel.SetActive(false);
        StartEngPanel.SetActive(false);
        TherapyEngPanel.SetActive(false);
        SelfDiagEngPanel.SetActive(false);
        AboutEngPanel.SetActive(false);
        HelpEngPanel.SetActive(false);

        MenuIndPanel.SetActive(true);
        StartIndPanel.SetActive(false);
        TherapyIndPanel.SetActive(false);
        SelfDiagIndPanel.SetActive(false);
        AboutIndPanel.SetActive(false);
        HelpIndPanel.SetActive(false);

        SureEngPanel.SetActive(false);
        SureIndPanel.SetActive(false);
    }

    public void Btn_BackStart_Ind_Clicked()
    {
        BahasaPanel.SetActive(false);

        MenuEngPanel.SetActive(false);
        StartEngPanel.SetActive(false);
        TherapyEngPanel.SetActive(false);
        SelfDiagEngPanel.SetActive(false);
        AboutEngPanel.SetActive(false);
        HelpEngPanel.SetActive(false);

        MenuIndPanel.SetActive(false);
        StartIndPanel.SetActive(true);
        TherapyIndPanel.SetActive(false);
        SelfDiagIndPanel.SetActive(false);
        AboutIndPanel.SetActive(false);
        HelpIndPanel.SetActive(false);

        SureEngPanel.SetActive(false);
        SureIndPanel.SetActive(false);
    }

    public void Btn_Exit_Eng_Clicked()
    {
        BahasaPanel.SetActive(false);

        MenuEngPanel.SetActive(false);
        StartEngPanel.SetActive(false);
        TherapyEngPanel.SetActive(false);
        SelfDiagEngPanel.SetActive(false);
        AboutEngPanel.SetActive(false);
        HelpEngPanel.SetActive(false);

        MenuIndPanel.SetActive(false);
        StartIndPanel.SetActive(false);
        TherapyIndPanel.SetActive(false);
        SelfDiagIndPanel.SetActive(false);
        AboutIndPanel.SetActive(false);
        HelpIndPanel.SetActive(false);

        SureEngPanel.SetActive(true);
        SureIndPanel.SetActive(false);
    }

    public void Btn_Exit_Ind_Clicked()
    {
        BahasaPanel.SetActive(false);

        MenuEngPanel.SetActive(false);
        StartEngPanel.SetActive(false);
        TherapyEngPanel.SetActive(false);
        SelfDiagEngPanel.SetActive(false);
        AboutEngPanel.SetActive(false);
        HelpEngPanel.SetActive(false);

        MenuIndPanel.SetActive(false);
        StartIndPanel.SetActive(false);
        TherapyIndPanel.SetActive(false);
        SelfDiagIndPanel.SetActive(false);
        AboutIndPanel.SetActive(false);
        HelpIndPanel.SetActive(false);

        SureEngPanel.SetActive(false);
        SureIndPanel.SetActive(true);
    }

    public void Btn_Yes_Clicked()
    {

        Application.Quit();
    }




}
