using UnityEngine;

public class Switchbox : MonoBehaviour
{
    //if this is true then the box takes multiple hits to register to activate something
    public bool multipleHits = false;
    public bool switchState = false;
    public Material switchMaterialOn;
    public Material switchMaterialOff;
    private int hitCounter = 0;
    public int maxHitCount = 0;

    void Start()
    {
        hitCounter = 0;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (multipleHits)
        {
            hitCounter++;
            if(hitCounter >= maxHitCount)
            {
                switchState = !switchState;
                hitCounter = 0;
            }
        } else switchState = ! switchState; //make the state the opposite of what it is

        if (switchState) gameObject.GetComponent<Renderer>().material = switchMaterialOn;
        else gameObject.GetComponent<Renderer>().material = switchMaterialOff;
    }
}
