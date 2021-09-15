using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void OnMove(InputValue momentValue)
    {
        Vector2 momentVector = momentValue.Get<Vector2>();
    }

    void  FixedUpdate()
    {
        
    }
}
