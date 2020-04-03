using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

    // Use this for initialization
    float xpos;
    float ypos;
    float zpos;

    float xspeed;
    float yspeed;

    public Text countT;
    public Text winText; 
    public Camera myCamera; //카메라     Vector3 cameraDist; //공에서 카메라까지 거리 

    public Canvas endGame; // 종료 메세지        public Canvas winGame; 


    public static int count;

    void Start()
    {
        xpos = transform.position.x;
        ypos = transform.position.y;
        zpos = transform.position.z;


        xspeed = Random.Range(-0.01f, 0.01f);
        yspeed = Random.Range(0.05f, 0.08f);

     //   count = 0;      //   SetCountText();

        winText.text = "";  
    }

    // Update is called once per frame
    void Update()
    {
        xpos = xpos + xspeed; //emeny 내려오게
        ypos = ypos - yspeed;
        transform.position = new Vector3(xpos, ypos, zpos);

        if (ypos < -5f)//화면밖으로 가면 없어지게
        {
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {

            Debug.Log("hit");
            Destroy(gameObject);
            Destroy(other.gameObject);

         //   SetCountText();
            count = count + 50;
 
        }

        if (other.tag == "Air")
        {
            Debug.Log("game over"); //enemy랑 air 붙이치면
            Destroy(gameObject); //enemy 죽고
            Destroy(other.gameObject); //Air 자기도 죽고

        }
    }



    public void Add(float x, float y, float z)
    {
        xpos = x;
        ypos = y;
        zpos = z;

    } 
}
