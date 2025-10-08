using UnityEngine;

public class ExtintorGrab : MonoBehaviour
{
    public bool isHoldingExtintor;
    [SerializeField] private GameObject Ui;

    public void Pick()
    {
        isHoldingExtintor = true;
        Ui.SetActive(true);
    }

    public void Release()
    {
        isHoldingExtintor = false;
    }
}
