using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int amount = 3;
    // Start is called before the first frame update

       public void TakeDamage()
       
       
    {
        amount -= 1;
        if (amount == 0)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }

}
