using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class playerController : MonoBehaviour
{

    public TextMeshProUGUI countText;

    public float speed = 0;
    private Rigidbody rb;

    private int cont;
    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cont = 0;
        SetCountText();
    }

    void SetCountText()
	{
		countText.text = "Count: " + cont.ToString();
	}

    // Update is called once per frame
    void OnMove(InputValue momentValue)
    {
        Vector2 momentVector = momentValue.Get<Vector2>();

        movementX = momentVector.x;
        movementY = momentVector.y;
    }

    void  FixedUpdate()
    {
        Vector3 movement = new Vector3 (movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            cont += 1;
            SetCountText();
        }
    }
}
