using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject laser;
    public KeyCode shoot;
    double cooldown;
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        cooldown = 0;
        audio = GetComponent<AudioSource>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(shoot) && cooldown < 0)
        {
            laser.SetActive(true);
            cooldown = 0.5;
             audio.PlayOneShot(audio.clip);
        }
        else if  (cooldown < 1)
        {
            laser.SetActive(false);
        }
        cooldown -= Time.deltaTime;
    }
}
