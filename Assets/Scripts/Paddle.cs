using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed =20.0f;  // Speed change 20 instead of 10
    protected Rigidbody2D _rigidbody;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    public void ResetPosition()
    {
        GetComponent<Rigidbody>().position = new Vector2(GetComponent<Rigidbody>().position.x, 0.0f);
        _rigidbody.velocity = Vector2.zero;
    }
}