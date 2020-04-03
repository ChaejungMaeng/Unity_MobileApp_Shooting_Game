using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            float r = Time.time; //시작부터 시간을 초로 반환한다 Time.time다 //특정 각도와 특정 속도 회전속도가 점점 빨라진
             Debug.Log(r);
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, r * 15));                                          //그냥 돌린거 회전 제어하거나 // 특정 이벤트에서 회전을 설정해줄때
                                                                           //transform.Rotate와 차

        }
    }