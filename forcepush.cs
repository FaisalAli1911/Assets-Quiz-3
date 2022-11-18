using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class forcepush : MonoBehaviour
{
    public Transform firepoint;
    public GameObject cube;
    GameObject bullet;
    public float Force = 20f;
    Rigidbody rb;
    public bool fire=false;
   // private bool onlyone=true;
    // Start is called before the first frame update
    private void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            fire = true;
            shoot();
         
        }
        else
        {
            fire = false;
        }



    }
    void shoot()
    {
        if (fire)
        {
            Debug.Log("This is happening here");
            bullet = Instantiate(cube, firepoint.position, firepoint.rotation);
            rb = bullet.GetComponent<Rigidbody>();
            rb.AddForce(firepoint.forward * Force, ForceMode.Impulse);
            
        }   

    }


    
    void OnTriggerExit(Collider collision)
    {      
      
        Destroy(bullet);
        Destroy(bullet);
      
    }

}
   
