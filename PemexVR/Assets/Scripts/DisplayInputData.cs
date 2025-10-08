using UnityEngine;
using UnityEngine.XR;

[RequireComponent(typeof(InputData))]
public class DisplayInputData : MonoBehaviour
{
    private InputData _inputData;
    
    [SerializeField] private ExtintorGrab extintor;
    
    private void Start()
    {
        _inputData = GetComponent<InputData>();
    }

    public void Update()
    {
        if (!_inputData._rightController.TryGetFeatureValue(CommonUsages.primaryButton, out var button))return;
        {
            if (button & extintor.isHoldingExtintor)
            {
                Debug.unityLogger.Log("Particulas!");
            }
            
        }
    }
   
}