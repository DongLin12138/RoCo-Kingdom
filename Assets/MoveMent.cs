using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMent : MonoBehaviour
{
    public float speed;
    public bool up, down, left, right;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
    }
    public void Up() { up = true; }
    public void Down() { down = true; }
    public void Left() { left = true; }
    public void Right() { right = true; }
}
