using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
        {
         Health health = other.GetComponent<Health>();
         if (health != null)
          {
           health.TakeDamage();
          }
        }
}
