using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject bullet;
    public GameObject turret;

    private void Update() 
    {
        if (Input.GetKeyDown("space"))
        {
            Fire();
        }   
    }

    public void Fire()
    {
        GameObject b = Instantiate (bullet, turret.transform.position, turret.transform.rotation); 
        b.GetComponent<Rigidbody>().AddForce(turret.transform.forward* 500);
    }
}
