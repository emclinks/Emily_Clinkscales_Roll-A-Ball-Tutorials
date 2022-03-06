using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    //Connectors make the world go round~
    private Rigidbody rb;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    //floatie boys
    public float speed = 0;
    private float movementX;
    private float movementY;
    //Int Bin
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //Fresh Count
        count = 0;
        SetCountText();
        //Setting ending properties
        winTextObject.SetActive(false);
    }

    //Tracking player input to create movement.
    void OnMove (InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            //Add to that count!
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        //Setting win conditional
        if (count >= 12)
        {
            winTextObject.SetActive(true);
        }
    }
}
