using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    // Start is called before the first frame update
    //Maak een variabele aan voor je animator component
    private Animator ani;

    void Start()
    {
        //Pak het animator component en sla die op in de variabele
        ani = GetComponent<Animator>();
    }
    void Update()
    {
        //Check voor verticale input
        if (Input.GetAxis("Vertical") > 0)
        {
            //is de waarde groter dan 0 dan heb je een knop naar boven ingedrukt
            //Roep de juiste trigger aan!
            ani.SetTrigger("run");
            //SetTrigger is trigger activeren
            ani.ResetTrigger("Run exit");
            ani.ResetTrigger("RunR");
            ani.ResetTrigger("run-jump");
            //ResetTrigger is Trigger de-activeren
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            //is de waarde kleiner dan 0 dan heb je een knop naar beneden ingedrukt
            //Roep de juiste trigger aan
            ani.SetTrigger("RunR");
            ani.ResetTrigger("Run exit");
            ani.ResetTrigger("run");
            ani.ResetTrigger("run-jump");
        }
        else
        {
            //is de waarde 0 dan heb je niets ingedrukt
            //Roep de juiste trigger aan
            ani.SetTrigger("Run exit");
            ani.ResetTrigger("run");
            ani.ResetTrigger("RunR");

        }
    }
}