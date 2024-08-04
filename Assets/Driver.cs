using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float speed=5f;
    [SerializeField] float rotationSpeed=0.8f;    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmout = Input.GetAxis("Horizontal")*rotationSpeed;
        float accelaration = Input.GetAxis("Vertical")*speed*Time.deltaTime;

        transform.Rotate(0,0,-steerAmout);
        transform.Translate(0, accelaration,0);
    }
}
