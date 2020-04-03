using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enew5 : MonoBehaviour
{

    // Use this for initialization
    float xpos;
    float ypos;
    float zpos;

    float xspeed;
    float yspeed;

    //public Transform objectToFollow;
    //public Vector3 offset;

    //bool gameStart = false; 

    //public Text countT;

    //public Text winText;

    //public Camera myCamera; //카메라
    //Vector3 cameraDist; //공에서 카메라까지 거리


    //public Canvas endGame; // 종료 메세지   
    //public Canvas winGame;

    //public Canvas ending2;

    public static int count2;

    private GameObject plChar;

    //  public float dangerDistance = 4f;

    //float detRange;
    //float speed; 
    public Transform mTarget;

    float mSpeed = 10.0f;
    Vector3 mLookDirection;

    const float EPSILON = 0.1f;

    void Awake()     {      }

    void Start()
    {
     //   count2 = 0;

        //gameStart = true;

        //ending2.enabled = false; //처음엔 끄고(비활성화) // 안끄면 처음부터 game over        //종료화면끄기        

        xpos = transform.position.x;
        ypos = transform.position.y;
        zpos = transform.position.z;


        xspeed = Random.Range(-0.01f, 0.01f);
        yspeed = Random.Range(0.025f, 0.04f);


        //winGame.enabled = false;         //endGame.enabled = false; //처음엔 끄고(비활성화) // 안끄면 처음부터 game over        //종료화면끄기        
         ////SetCountText();         //winText.text = ""; 

    }

    // Update is called once per frame
    void Update()
    {

        //SetCountText();
        plChar = GameObject.FindGameObjectWithTag("viper");

        xpos = xpos + xspeed; //emeny 내려오게
        ypos = ypos - yspeed;
        transform.position = new Vector3(xpos, ypos+10f, zpos);

      /*  transform.LookAt(mTarget.position);
    
        if ((transform.position - mTarget.position).magnitude > EPSILON)
        {
            transform.Translate(0.0f, 0.0f, mSpeed * Time.deltaTime);
        }*/

        if (ypos < -15f)//화면밖으로 가면 없어지게
        {
            Destroy(gameObject);
        }


        /*
        if ((plChar.transform.position - transform.position).magnitude < 1) //&& (plChar.transform.position - transform.position).magnitude < detRange)
        {
            transform.LookAt(plChar.transform.position);
            transform.Translate(Vector3.forward * speed);
        }*/
    }
    void OnTriggerEnter(Collider other)
    {
       /* if (other.tag == "Bullet")
        {

            Debug.Log("hit");

            count2 = count2 + 50;
            // SetCountText();

            Debug.Log(count2);

            Destroy(gameObject);
            Destroy(other.gameObject);
        }*/
    //    var distance = Vector3.Distance(ball.transform.position, transform.position);
        // Activate if distance is more than dangerDistance
      
        //float distance = Vector3.Distance(bolt.transform.position + Vector3.down * 100, person.transform.position);

        if (other.tag == "viper")
        {

            mLookDirection = (mTarget.position - transform.position).normalized;
            transform.Translate(mLookDirection * Time.deltaTime * mSpeed);

          /*  transform.LookAt(mTarget.position);

            if ((transform.position - mTarget.position).magnitude > EPSILON)
            {
                transform.Translate(0.0f, 0.0f, mSpeed * Time.deltaTime);
            }*/
           // transform.position = objectToFollow.position + offset;
        }
            //endGame.enabled = true; //game over 활성화 true                         //ending2.enabled = true; //game over 활성화 true  
            //gameStart = false;
         /*   var distance = Vector3.Distance(ball.transform.position, transform.position);
            // Activate if distance is more than dangerDistance
            if (distance > dangerDistance)
            {
                ball = (GameObject)Instantiate(ball, transform.position, transform.rotation);
            }

            Debug.Log("game over"); //enemy랑 air 붙이치면
            Destroy(gameObject); //enemy 죽고
          //  Destroy(other.gameObject); //Air 자기도 죽고
*/
        }

/*
void SetCountText()
{
    countT.text = "SCORE : " + count2.ToString();
    if (count2 >= 1000)
    {
        winText.text = "You Win!";
        winGame.enabled = true;
        endGame.enabled = false;
    }
}*/

    public void Add(float x, float y, float z)
    {
    xpos = x;
    ypos = y;
    zpos = z;

    }


}
