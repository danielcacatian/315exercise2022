using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    public string collectibleTag;
    AudioSource pickupSound;

    // Start is called before the first frame update
    void Start()
    {
        pickupSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == collectibleTag)
        {
            pickupSound.Play(0);
            GameObject.Destroy(collision.gameObject);
        }
    }
}
