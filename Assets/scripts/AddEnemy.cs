using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AddEnemy : MonoBehaviour {
    
    float nowTime1;
    float nowTime2;
    float nowTime3;
    float nowTime4;
    float nowTime5;
    //public Text countT;

    //private int count;

    public GameObject gem1;
    public GameObject gem2;
    public GameObject gem3;
    public GameObject gem4;
    public GameObject gem5;



	// Use this for initialization
	void Start () {
        
        nowTime1 = Time.time;
        nowTime2= Time.time; 
        nowTime3 = Time.time;
        nowTime4 = Time.time;
        nowTime5 = Time.time;


        //count = 0;
        //SetCountText();
	}

    // Update is called once per frame
    void Update()
    {
        
        if ((Time.time - nowTime1 > 1f) && (Time.time - nowTime1 < 3.0f))
        {
            
         //   gem1 = GameObject.FindGameObjectWithTag("1gem");
            GameObject a = Instantiate(gem1, new Vector3(Random.Range(-3, 3), 7, 0), Quaternion.identity);
            a.GetComponent<Enew5>().Add(transform.position.x, transform.position.y, transform.position.z);  //Enew5

            a.transform.localScale = new Vector3(1f, 1f, 1f);
           // a.transform.localRotation = Quaternion.Euler(new Vector3(3, 0, 0));

            nowTime1 = Time.time;

        }

        StartCoroutine(TestRoutine()); /////////

        if ((Time.time - nowTime2 > 0.5f) && (Time.time - nowTime2 < 3f))
        {
         //   gem2 = GameObject.FindGameObjectWithTag("2gem");
            GameObject b = Instantiate(gem2, new Vector3(Random.Range(-3, 3), 7, 0), Quaternion.identity);
            b.GetComponent<Enew5>().Add(transform.position.x, transform.position.y, transform.position.z);  //Enew5

            b.transform.localScale = new Vector3(1f, 1f, 1f);
            // a.transform.localRotation = Quaternion.Euler(new Vector3(3, 0, 0));

            nowTime2 = Time.time;
        }

        StartCoroutine(TestRoutine());

        if ((Time.time - nowTime3 > 1f) && (Time.time - nowTime3 < 3f))
        {
         //   gem3 = GameObject.FindGameObjectWithTag("3gem");
            GameObject c = Instantiate(gem3, new Vector3(Random.Range(-3, 3), 7, 0), Quaternion.identity);
            c.GetComponent<Enew5>().Add(transform.position.x, transform.position.y, transform.position.z);  //Enew5

            c.transform.localScale = new Vector3(1f, 1f, 1f);
            // a.transform.localRotation = Quaternion.Euler(new Vector3(3, 0, 0));

            nowTime3 = Time.time;
        }

        StartCoroutine(TestRoutine());

        if ((Time.time - nowTime4 > 1f) && (Time.time - nowTime4 < 3f))
        {
         //   gem4 = GameObject.FindGameObjectWithTag("4gem");
            GameObject d = Instantiate(gem4, new Vector3(Random.Range(-3, 3), 7, 0), Quaternion.identity);
            d.GetComponent<Enew5>().Add(transform.position.x, transform.position.y, transform.position.z);  //Enew5

            d.transform.localScale = new Vector3(1f, 1f, 1f);
            // a.transform.localRotation = Quaternion.Euler(new Vector3(3, 0, 0));

            nowTime4 = Time.time;
        }

        StartCoroutine(TestRoutine());

        if ((Time.time - nowTime5 > 1f) && (Time.time - nowTime5 < 3f))
        {
        //    gem5 = GameObject.FindGameObjectWithTag("5gem");
            GameObject e = Instantiate(gem5, new Vector3(Random.Range(-3, 3), 7, 0), Quaternion.identity);
            e.GetComponent<Enew5>().Add(transform.position.x, transform.position.y, transform.position.z);  //Enew5

            e.transform.localScale = new Vector3(1f, 1f, 1f);
            // a.transform.localRotation = Quaternion.Euler(new Vector3(3, 0, 0));

            nowTime5 = Time.time;
        } 

       // nowTime = Time.time;
    }
    /*
    IEnumerator TimeDelay(float hereTime)
    {

      
        GameObject e = Instantiate(k, new Vector3(Random.Range(-3, 3), 7, 0), Quaternion.identity);
        e.GetComponent<Enew5>().Add(transform.position.x, transform.position.y, transform.position.z);  //Enew5

        e.transform.localScale = new Vector3(1f, 1f, 1f);
        // a.transform.localRotation = Quaternion.Euler(new Vector3(3, 0, 0));

        nowTime5 = Time.time;
        yield return new WaitForSecondsRealtime(1f);

    }*/

    IEnumerator TestRoutine()
    {
        int n = 0;
        while (n < 1)
        {
            Debug.Log("Run TestRoutine");
            yield return new WaitForSeconds(3f);
            //  yield return new WaitForSeconds(3f);
            Debug.Log("Finish TestRoutine");
            n++;
        }

    }

   // StartCoroutine(TimeDelay( () => { Instantiate(/*parameters*/) }, 2));

	/*
    private void OnTriggerEnter(Collider other)
    {
       if (other.tag == "Bullet")
        {

            Debug.Log("hit");
            Destroy(gameObject);
            Destroy(other.gameObject);

            //SetCountText();
            //count = count + 50;


        }
        if (other.tag == "Air")
        {
            Debug.Log("game over"); //enemy랑 air 붙이치면
            Destroy(gameObject); //enemy 죽고
            Destroy(other.gameObject); //Air 자기도 죽고

        }
    }
*/
    //void SetCountText()
    //{
    //    countT.text = "SCORE : " + count.ToString();
    //  /*  if (count >= 1000)
    //    {
    //        winText.text = "You Win!";
    //        winGame.enabled = true;

    //        endGame.enabled = false;
    //    }*/
    //}
  
}
