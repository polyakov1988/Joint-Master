using System;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public event Action CatapultReady;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Catapult catapult))
        {
            CatapultReady?.Invoke();
        }
    }
}
