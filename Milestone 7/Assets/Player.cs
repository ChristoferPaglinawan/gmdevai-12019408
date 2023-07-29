using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float health = 100;

    void OnCollisionEnter(Collision col)
    {
    	Bullet bullet = col.gameObject.GetComponent<Bullet>();

        if(col != null)
        {
            health -= 20;

            if(health <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
