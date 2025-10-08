using UnityEngine;

public class Extintor : MonoBehaviour
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
