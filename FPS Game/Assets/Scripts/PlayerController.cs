using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Movement")]
    public float moveSpeed;
    public float jumpForce;
    [Header("Camera")]
    public float lookSensitivity;
    public float maxLookX;
    public float minLookX;
    private float rotX;
    private Camera camera;
    private Rigidbody rb;

    void Awake()
    {
        // Get Componets
        camera = Camera.main;
        rb = GetComponent<Rigidbody>();


    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CameraLook();
        
        if(Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed; // Getting input for left and right movement
        float z = Input.GetAxis("Vertical") * moveSpeed; //Getting input for up and down movement

        //rb.velocity = new Vector3(x, rb.velocity.y, z); // Appying velocity to x-axis and the z-axis to drive the player movement
        
        Vector3 dir = transform.right * x + transform.forward * z; // Allows to move with the direction of the camera
        dir.y = rb.velocity.y;
        rb.velocity = dir;
    }

    void CameraLook()
    {
        float y = Input.GetAxis("Mouse X") * lookSensitivity; // Look up and down sens
        rotX += Input.GetAxis("Mouse Y") * lookSensitivity; // Look right and left sens

        //Restrict rotation on the X-Axis between maxLookX to minLookX
        //rotX = Mathf.Clamp(rotX, minLookX, maxLookX);

        // Drives Camera Rotation
        camera.transform.localRotation = Quaternion.Euler(-rotX, 0, 0);
        transform.eulerAngles += Vector3.up * y;
    }

    void Jump()
    {
        Ray ray = new Ray(transform.position, Vector3.down);

        if(Physics.Raycast(ray, 1.1f))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
