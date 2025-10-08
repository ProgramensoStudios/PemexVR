using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.XR.Interaction.Toolkit.Utilities;

public class Fuego : MonoBehaviour
{
    public ParticleSystem fireParticles;
    public float extinguishRate = 1f; 
    public bool isBeingExtinguished = false;
    public BoxCollider boxCollider;
   

    private ParticleSystem.EmissionModule emission;

    void Start()
    {
        emission = fireParticles.emission;
    }

    void Update()
    {
        if (isBeingExtinguished && emission.rateOverTime.constant > 0)
        {
            float newRate = emission.rateOverTime.constant - extinguishRate * Time.deltaTime;
            emission.rateOverTime = Mathf.Max(newRate, 0);
        }
        if (emission.rateOverTime.constant <= 0)
        {
            fireParticles.Stop();
            boxCollider.enabled = false;
            //Destroy(gameObject);
        }
    }
    
    public void StartExtinguishing()
    {
        isBeingExtinguished = true;
    }
    

}
