using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starmove : MonoBehaviour
{
    float xpos;
    float ypos;
    float zpos;

    float xspeed;
    float yspeed;

    // Start is called before the first frame update
    void Start()
    {
        xpos = transform.position.x;
        ypos = transform.position.y;
        zpos = transform.position.z;


        xspeed = Random.Range(-0.01f, 0.01f);
        yspeed = Random.Range(0.02f, 0.04f);

    }

    // Update is called once per frame
    void Update()
    {
        xpos = xpos + xspeed; //emeny 내려오게
        ypos = ypos - yspeed;
        transform.position = new Vector3(xpos, ypos + 10f, zpos);

        if (ypos < -10f)//화면밖으로 가면 없어지게
        {
            Destroy(gameObject);
        }
    }
   /* public void Add(float x, float y, float z)
    {
        xpos = x;
        ypos = y;
        zpos = z;

    }*/

}
