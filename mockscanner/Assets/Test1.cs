using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Test1: MonoBehaviour
{
    Canvas mycanvas; 

    // Update is called once per frame
    void Update(){
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo))
        {
            
            Debug.DrawLine(ray.origin, hitInfo.point, Color.red);
        }
        else
        {
           
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * 100, Color.green);
        }



        if (Physics.Raycast(ray, hitInfo.point))
        {
            mycanvas = true; 
        }
        }
        
    
       

}
