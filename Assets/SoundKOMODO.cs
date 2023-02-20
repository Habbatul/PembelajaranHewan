using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundKOMODO : MonoBehaviour
{
    public void TekanKomodo()
    {
        GetComponent<Animator>().Play("attack");
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
