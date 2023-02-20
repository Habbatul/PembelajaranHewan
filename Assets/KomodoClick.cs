using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KomodoClick : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            GetComponent<Animator>().Play("bite");
        }
    }
}
