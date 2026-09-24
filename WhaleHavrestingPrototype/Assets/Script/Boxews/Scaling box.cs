using System.Collections;
using UnityEngine;

public class Scalingbox : MonoBehaviour
{


    public int [] scaleOrder = new int[3];
    public int scaleIndex = -1;
    public float animationLength;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    

    private void OnCollisionEnter(Collision collision)
    {
        if (scaleIndex == scaleOrder.Length - 1) return;

        //increase the size but clamp it so we don't go out of bounds
        scaleIndex = Mathf.Clamp(scaleIndex + 1, 0, scaleOrder.Length - 1);
        
        transform.localScale = new Vector3(1, 1, 1) * scaleOrder[scaleIndex];
    }

}
