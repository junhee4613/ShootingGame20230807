using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.parent != null)
        {
            Debug.Log("π›¿¿");
            rb.bodyType = RigidbodyType2D.Kinematic;
            //rb.simulated = true;
        }
        else
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            transform.parent = null;
        }
    }
}
