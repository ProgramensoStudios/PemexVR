using UnityEngine;

public class Extintor : MonoBehaviour
{
     private void OnParticleCollision(GameObject other)
        {
            if (other.CompareTag("Fire"))
            {
                other.GetComponent<Fuego>().StartExtinguishing();
            }
        }
}
