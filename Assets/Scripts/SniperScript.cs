using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperScript : MonoBehaviour
{
    public GameObject sniperObject;
    RaycastHit rayHit;					//射線碰到的物件
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out rayHit, 100f)){
            sniperObject.transform.position = rayHit.point;
        }
        else{
            sniperObject.transform.position = Vector3.zero - Vector3.up * 100;
        }
    }
}
