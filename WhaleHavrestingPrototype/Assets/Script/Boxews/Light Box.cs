using UnityEngine;

public class LightBox : MonoBehaviour
{

    private Light lightsource;
    
    void Start()
    {
        lightsource = GetComponent<Light>();
        if (lightsource == null) Debug.LogError("There is no lightsource component attached to this object");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        lightsource.enabled = !lightsource.enabled;
    }
}
