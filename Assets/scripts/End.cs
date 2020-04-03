using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class End : MonoBehaviour
{

    Vector3 character_pos;     Vector3 pos;    // GameObject Rocket;
    Texture2D texture;

  //  bool gameStart = false;

    public static int coin1;

    public static Text end;
    public Canvas ending2;
    public Canvas intro;

    public Camera myCamera; //카메라     Vector3 cameraDist; //공에서 카메라까지 거리      void Awake()     {      }

    // Start is called before the first frame update
    void Start()
    {
   //     endGame.enabled = false; //처음엔 끄고(비활성화) // 안끄면 처음부터 game over        //종료화면끄기        
   //     winG.enabled = false;

   //     gameStart = true;

        ending2.enabled = false; //처음엔 끄고(비활성화) // 안끄면 처음부터 game over        //종료화면끄기        
  


    }

    // Update is called once per frame
    void Update()
    {
    //    ball = GameObject.FindGameObjectWithTag("viper");

        if (Input.GetMouseButton(0))
        {
            intro.enabled = false;
            pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z - Camera.main.transform.position.z)); 
        }
        character_pos.x = Mathf.Lerp(character_pos.x, pos.x, 0.1f); //0.1f를 조절함에 따라 속도 차이 생긴다
      // character_pos.y = Mathf.Lerp(character_pos.y, pos.y, 0.1f); 
        transform.position = new Vector3(character_pos.x, transform.position.y, transform.position.z); //삼각함수 계산해서 좌표 가저오는거지 
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "1gem")
        {
            coin1 = coin1 + 30;
            Debug.Log("game over"); //enemy랑 air 붙이치면

            var distance = Vector3.Distance(GameObject.FindGameObjectWithTag("viper").transform.position, transform.position);
            //   ending2.enabled = true; //game over 활성화 true  
            //endGame.enabled = true; //game over 활성화 true  //gameStart = false; 
            //Rocket.SetActive(false); //Destroy(gameObject); //Air 죽고
           //Destroy(other.gameObject); //Enemy 자기도 죽고
        }

        if (other.tag == "2gem")
        {
            coin1 = coin1 + 70;
            Debug.Log("game over"); //enemy랑 air 붙이치면

        }

        if (other.tag == "3gem")
        {
            coin1 = coin1 + 120;
            Debug.Log("game over"); //enemy랑 air 붙이치면
        }

        if (other.tag == "4gem")
        {
            coin1 = coin1 + 180;
            Debug.Log("game over"); //enemy랑 air 붙이치면
        }

        if (other.tag == "5gem")
        {
            coin1 = coin1 + 250;
            Debug.Log("game over"); //enemy랑 air 붙이치면

        }
    }

    //void OnTriggerEnter(Collider other)
    //{

    //    if (other.tag == "Enemy")
    //    {
    //        Debug.Log("game over"); //enemy랑 air 붙이치면

    ////        endGame.enabled = true; //game over 활성화 true            
    //        gameStart = false;

    //        //Destroy(gameObject); //enemy 죽고
    //        //Destroy(other.gameObject); //Air 자기도 죽고

    //    }
    //}

    public void Restart3()
    {
        Enew5.count2 = 0;

        ending2.enabled = false; //endgame을 비활성화 한다        //박스 초기화 
                                 //  Rocket.SetActive(true);

        SceneManager.LoadScene("CJ");

        Debug.Log("bring back");

    }



}
