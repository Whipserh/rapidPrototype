using UnityEngine;

public class disapearingappearingblock : MonoBehaviour
{
    public GameObject switchBox;
    private Switchbox _blockSwitch;
    public GameObject disappearingBlock;

    public bool flipState;

    
    void Start()
    {
        _blockSwitch = switchBox.GetComponent<Switchbox>();
        disappearingBlock.SetActive(!flipState);
    }

    void Update()
    {

        Debug.Log(_blockSwitch.switchState);

        disappearingBlock.SetActive(flipState? !_blockSwitch.switchState : _blockSwitch.switchState);
        

        //draw line green
        Debug.DrawLine(transform.position, switchBox.transform.position, _blockSwitch.switchState ? Color.green: Color.red);
    }
}
