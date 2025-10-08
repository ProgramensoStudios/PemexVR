using UnityEngine;
using UnityEngine.XR;

[RequireComponent(typeof(InputData))]
public class DisplayInputData : MonoBehaviour
{
    private InputData _inputData;
    
    [SerializeField] private ExtintorGrab extintor;
    [SerializeField] private ParticleSystem particle;
    
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
                particle.Play();
            }

            if (!button & extintor.isHoldingExtintor)
            {
                particle.Stop();
            }
        }
    }
   
}