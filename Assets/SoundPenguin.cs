using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPenguin : MonoBehaviour
{
    public void TekanPenguin()
    {
        GetComponent<Animator>().Play("bite");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
