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

        if(dist < 6)
        {
            //�Z�����
            transform.localScale= new Vector3(3, 3, 3);
        }
        else
        {
            //�Z������
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
