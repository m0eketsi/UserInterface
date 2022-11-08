using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int pointValue = 1;
    public float minSpeed = 10;
    public float maxSpeed = 20;
    public float MaxTorque = 10;
    private Rigidbody2D _targetRb;
    // Start is called before the first frame update
    void Start()
    {
        _targetRb = GetComponent<Rigidbody2D>();
        _targetRb.AddForce(Vector2.up * minSpeed, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
