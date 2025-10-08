using System;
using UnityEngine;

public class Extintor : MonoBehaviour
{
     private void OnParticleCollision(GameObject other)
        {
            other.GetComponent<Fuego>().StartExtinguishing();
        }

}
