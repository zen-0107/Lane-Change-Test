using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class Form_Menu : MonoBehaviour
{
    private static string Person_ID;
    public static int rep;

    public void PlayGame()
    {
       if( Person_ID !=null){
         
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       }
    }

    public void String_reader_1(string ID){
        Person_ID = ID;
       
    }

    public void String_reader_2(string repetition){
        try{
             rep = int.Parse(repetition);

            rep = rep > 30 ? 30 : rep;
            rep = rep < 1  ? 1  : rep;  
        }
        catch(Exception e)
        {
            print("Error: " +e);
        }
    }

    public void QuitGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
