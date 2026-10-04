using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class PlayerController : MonoBehaviour 
{
    private Rigidbody rb;
    public float velocidade;
    private int count;
    
    public GameObject winTextObject;
void Start () 
{
    count = 0;
    rb = GetComponent<Rigidbody>();
    winTextObject.SetActive(false);
}
void Update () 
{
    float movimentoHorizontal = Input.GetAxis("Horizontal");
    float movimentoVertical = Input.GetAxis("Vertical");
    Vector3 movimento = new Vector3(movimentoHorizontal, 0.0f, movimentoVertical);
    rb.AddForce(movimento * velocidade);
    setCountText();
}
public TextMeshProUGUI counText;
    public void setCountText()
    {
         counText.text = "Count: " + count.ToString();
        if (count == 4)
        {
            winTextObject.SetActive(true);
        }
    }
    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "PickUp")
        { 
            other.gameObject.SetActive(false);
            count = count + 1;
            setCountText();
        }
    }
}