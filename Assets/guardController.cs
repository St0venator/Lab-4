using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guardController : MonoBehaviour
{

    //public Animator anim;

    float animDist;
    // Start is called before the first frame update
    void Start()
    {
        //anim = GetComponent<Animator>();
        //anim.speed *= 1 + Vector3.Distance(transform.position, new Vector3(6, 0, -6));
        animDist = Vector3.Distance(transform.position, new Vector3(6, 0, -6));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0.1f, 0);
    }
}
