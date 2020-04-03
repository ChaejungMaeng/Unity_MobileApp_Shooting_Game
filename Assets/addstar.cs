using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addstar : MonoBehaviour
{
    float now;

    public GameObject stars;
    // Start is called before the first frame update
    void Start()
    {
        now = Time.time;
    }

    // Update is called once per frame
    void Update()
    {   
        TestRoutine();
        
        GameObject s = Instantiate(stars, new Vector3(Random.Range(-3, 3), 7, 0), Quaternion.identity);
        s.GetComponent<Enew5>().Add(transform.position.x, transform.position.y, transform.position.z);  //Enew5

        s.transform.localScale = new Vector3(1f, 1f, 1f);
    }

    IEnumerator TestRoutine()
    {
        
            Debug.Log("Run TestRoutine");
            yield return new WaitForSeconds(7f);
            //  yield return new WaitForSeconds(3f);
            Debug.Log("Finish TestRoutine");
      

    }
}
