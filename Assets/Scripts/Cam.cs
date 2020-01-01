using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    private Vector3 offset;
    public Transform player; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
    void LateUpdate()
    {
        if (player.position.x < 4 && player.position.x > -16.5)
        {
            Vector3 temp = transform.position;

            temp.x = player.position.x;

            temp.x += offset.x;

            transform.position = temp;
        }
    }
   

}
