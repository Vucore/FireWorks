using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWorks : MonoBehaviour
{
    [SerializeField] private ParticleSystem fireWorks;
    
    void Start()
    {
       fireWorks.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            fireWorks.Play();
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            fireWorks.Stop();
        }
    }
}
