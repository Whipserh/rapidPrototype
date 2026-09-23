using StarterAssets;
using System;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public LayerMask maskHits;
    public bool catchBall = false;
    [SerializeField]
    private StarterAssetsInputs playerInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (playerInput == null) Debug.LogError("Player Input has not been assigned");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer ==maskHits) // if something registers a hit off of the paddle then we perform the following response
        {
            
        }
    }
}
