using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float hInput;
    public float speed;
    private float xRange = 17.0f;

    public GameObject lazerBolt; //GameObject projectile to shoot
    public Transform blaster; //

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Set horizontal input to recieve values from the keyboard keymap horizontal
        hInput = Input.GetAxis("Horizontal");

        //Move the player left and right
        transform.Translate(Vector3.right * hInput * speed * Time.deltaTime);

        //Keep player within set bounds

        //Keep player inside right wall at set xRange
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //Keep player within left wall at set xRange 
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation); //instatiate lazerBolt GameObject as blaster postion
        }
    }
}