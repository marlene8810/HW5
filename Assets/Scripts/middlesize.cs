using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middlesize : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //取得距離 
     
       float dist = Vector3.Distance(transform.position, target.position);
        Vector3 targetpos;

        if(dist < 8)
        {
            //距離近時 
            targetpos = new Vector3(transform.position.x, 0, transform.position.z);
        }
        else
        {
            //距離遠時 
            targetpos = new Vector3(transform.position.x, -3, transform.position.z);
        }

        transform.position = Vector3.Lerp(transform.position, targetpos, 0.01f);
    }
}
