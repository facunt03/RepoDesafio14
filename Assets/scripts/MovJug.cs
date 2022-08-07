using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovJug : MonoBehaviour
{
        
    public float speed = 2f;
    public float rotateSpeed = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveMent();
    }
    void PlayerMoveMent()
    {
        float ver = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 0, ver) * speed * Time.deltaTime);

        float hor = Input.GetAxis("Horizontal");
        transform.Rotate(new Vector3(0, hor, 0) * rotateSpeed * Time.deltaTime);
    }
    
    
        
    
}
