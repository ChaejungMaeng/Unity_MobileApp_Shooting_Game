using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;


public class DIsta : MonoBehaviour
{
    public Text Dist;  //static 하면 안됨

    // public static int count;

    // Use this for initialization
    void Start()
    {
        //count = 0;
        SetDistaText();


    }

    private void Update()
    {
        SetDistaText();
    }

    void SetDistaText()
    {
        Dist.text = "SCORE : " + Enew5.count2.ToString();
        if (Enew5.count2 >= 300)
        {
         
            //  winGame.enabled = true;

            //  endGame.enabled = false;
        }
    }


    public void Restart2()
    {//gameover되고 다시 시작 //만들어서쓰면돼  

        Enew5.count2 = 0;

      //  wining.enabled = false;

        Dist.text = "SCORE : 0";

        SceneManager.LoadScene("CJ");

    }
}
