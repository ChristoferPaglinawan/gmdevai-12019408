using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMovement : MonoBehaviour
{
    //public GameObject[] wayPoints;
    public Transform goal;
    public float speed = 0;
    public float rotSpeed = 1;

    public float acceleration = 5;
    public float deceleration = 5;

    public float minSpeed = 0;
    public float maxSpeed = 10;

    public float brakeAngle = 20;
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        Vector3 lookAtGoal = new Vector3(goal.transform.position.x, 
                                        this.transform.position.y, 
                                        goal.transform.position.z);

        Vector3 direction = lookAtGoal - this.transform.position;

        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, 
                                                    Quaternion.LookRotation(direction), 
                                                    Time.deltaTime * rotSpeed);
        
        //speed = Mathf.Clamp(speed + (acceleration * Time.deltaTime), minSpeed, maxSpeed);

        if(Vector3.Angle(goal.forward, this.transform.forward) > brakeAngle && speed > 2)
        {
            speed = Mathf.Clamp(speed - (deceleration * Time.deltaTime), minSpeed, maxSpeed);
        }
        else
        {
            speed = Mathf.Clamp(speed + (acceleration * Time.deltaTime), minSpeed, maxSpeed);
        }

        this.transform.Translate(0, 0, speed * Time.deltaTime);
    }
}