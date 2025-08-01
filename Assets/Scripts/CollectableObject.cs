using System;
using UnityEngine;

public class CollectableObject : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") )
        {
            ScoreManager.instance.AddScore(2f);
            
            Destroy(this.gameObject);
        }
    }
}
