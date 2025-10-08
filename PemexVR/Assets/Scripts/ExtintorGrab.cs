using UnityEngine;

public class ExtintorGrab : MonoBehaviour
{
    public bool isHoldingExtintor;

    public void Pick()
    {
        isHoldingExtintor = true;
    }

    public void Release()
    {
        isHoldingExtintor = false;
    }
}
