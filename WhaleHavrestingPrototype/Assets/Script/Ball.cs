using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;
    public int maxHitCounter = 5;
    private int hitCounter;
    public float maxTimeOutBounce;
    private float hitTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //preset counter to maximum hits
        hitCounter = maxHitCounter;

        rb = GetComponent<Rigidbody>();
        if (rb == null) Debug.LogError("rb is not attached to ball");
    }

    // Update is called once per frame
    void Update()
    {
        //increase the time the ball has been in air for
        hitTime += Time.deltaTime;

        //if the ball hits the max counter hits then it destroys itself
        if(isDeadBall() || hitTime >= maxTimeOutBounce) Destroy(gameObject); 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "MainCamera") // if the ball gets hit by the paddle it resets the counter
            hitCounter = maxHitCounter;    
        else //else we bounce off of something else and we lose a bit of power
            hitCounter--;
        hitTime = 0;
    }

    public bool isDeadBall()
    {
        return hitCounter <= 0;
    }
}
