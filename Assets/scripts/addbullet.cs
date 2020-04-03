using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addbullet : MonoBehaviour {

    float nowTime;
    public GameObject bullet;

    public ShotButton shot; //무기버튼 추가

	// Use this for initialization
	void Start () {
        nowTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if(shot.Pressed && Time.time-nowTime>0.3f){
            GameObject b = Instantiate(bullet, transform.position, Quaternion.identity);
            b.GetComponent<Bullet>().AddBullet(transform.position.x, transform.position.y, transform.position.z);
            // Bullet 컴포넌트에 접근해서 (public)AddBullet의 x,y,z 좌표 가져옴
            nowTime = Time.time;
        }
	}
}
