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
        //���o�Z�� 
     
       float dist = Vector3.Distance(transform.position, target.position);
        Vector3 targetpos;

        if(dist < 8)
        {
            //�Z����� 
            targetpos = new Vector3(transform.position.x, 0, transform.position.z);
        }
        else
        {
            //�Z������ 
            targetpos = new Vector3(transform.position.x, -3, transform.position.z);
        }

        transform.position = Vector3.Lerp(transform.position, targetpos, 0.01f);
    }
}
