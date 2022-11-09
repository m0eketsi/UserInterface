using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int pointValue = 1;
    public float minSpeed = 6;
    public float maxSpeed = 14;
    public float MaxTorque = 40;
    private Rigidbody2D _targetRb;
    // Start is called before the first frame update
    void Start()
    {
        _targetRb = GetComponent<Rigidbody2D>();
        _targetRb.AddForce(Vector2.up * RandomizeForce(), ForceMode2D.Impulse);
        _targetRb.AddTorque(RandomizeTorque());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private float RandomizeForce()
    {
        return Random.Range(minSpeed, maxSpeed);
    }
    private float RandomizeTorque()
    {
        return Random.Range(-MaxTorque, MaxTorque);
    }
}
