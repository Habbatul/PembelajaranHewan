using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTukan: MonoBehaviour
{
    public void TekanTukan()
    {
        GetComponent<Animator>().Play("fly fast");
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
