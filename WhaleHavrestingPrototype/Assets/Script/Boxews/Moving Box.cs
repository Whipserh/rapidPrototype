using UnityEngine;

public class MovingBox : MonoBehaviour
{

    public Transform [] positions = new Transform [4];

    private int index = 0;

    void Start()
    {
        transform.position = positions[0].position;
    }



    void Update()
    {
        
    }//edn update

    private void OnCollisionEnter(Collision collision)
    {
        if (index == positions.Length - 1) return;

        //increase the size but clamp it so we don't go out of bounds
        index = Mathf.Clamp(index + 1, 0, positions.Length - 1);

        transform.position = positions[index].position;  
    }
}
