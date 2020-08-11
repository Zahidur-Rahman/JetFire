using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgScrolling : MonoBehaviour
{
    public float speed;
    public float endX;
    private float length;

 // Use this for initialization
 void Start () {
        length = GetComponent<SpriteRenderer>().bounds.size.x *2;
    }
 
 // Update is called once per frame
 void Update () {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < endX )
        {
            transform.position = new Vector2(transform.position.x + length, transform.position.y);
        }
 } }