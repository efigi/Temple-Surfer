using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOtherOnCollision : MonoBehaviour
{
    public string tag; 
    // Start is called before the first frame update
    void Start()
    {
        if (tag == null)
        {
            tag = "Player";
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.tag == "Player")
        {
            //Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
