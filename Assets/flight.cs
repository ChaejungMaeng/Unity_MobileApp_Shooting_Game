using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flight : MonoBehaviour
{
    private CharacterController controller;

    private float baseSpeed = 10.0f;
    private float rotSpeedX = 3.0f;
    private float rotSpeedY = 1.5f;
                               
    // Start is called before the first frame update
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 moveVector = transform.forward * baseSpeed;

        //
     /*   Vector3 inputs = Manager.
        Vector3 yaw = inputs.x * transform.right * rotSpeedX * Time.deltaTime;
        Vector3 pitch = inputs.y * transform.up * rotSpeedY * Time.deltaTime;
        Vector3 dir = yaw + pitch;

*/
    }
}
