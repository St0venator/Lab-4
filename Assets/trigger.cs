using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public bool isJump;
    public bool isClimb;

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isClimb)
        {
            other.gameObject.GetComponent<Animator>().SetLayerWeight(1, 1);
        }
        else
        {
            other.gameObject.GetComponent<Animator>().SetLayerWeight(2, 0.5f);

            other.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 5);
        }

        StartCoroutine("endTrigger");
    }

    IEnumerator endTrigger()
    {
        yield return new WaitForSeconds(2);
        player.GetComponent<Animator>().SetLayerWeight(1, 0);
        player.GetComponent<Animator>().SetLayerWeight(2, 0);
    }
}
