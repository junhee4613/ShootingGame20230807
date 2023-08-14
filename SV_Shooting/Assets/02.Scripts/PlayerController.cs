using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed;
    public Vector2 moveInput;
    Animator an;
    public Transform bulletPivot;
    public GameObject bulletPrefab;
    public float shotDelay = 0.2f;
    public float shotCounter;
    public Transform topLeft;
    public Transform bottomRight;
    /*public AudioSource audio;*/

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        an = GetComponent<Animator>();
        /*audio = GetComponent<AudioSource>();*/
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rb.velocity = moveInput * moveSpeed;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, topLeft.position.x, bottomRight.position.x),
            Mathf.Clamp(transform.position.y, bottomRight.position.y, topLeft.position.y), transform.position.z);

        an.SetFloat("Movement", rb.velocity.y);
        /*shotCounter += Time.deltaTime;*/
        /*if (Input.GetButton("Fire1") && shotCounter > shotDelay)
        {
            audio.Play();
            shotCounter = 0;
            Instantiate(bulletPrefab, bulletPivot.position, bulletPivot.rotation);
        }*/
        if (Input.GetButtonDown("Fire1"))
        {
            
            Instantiate(bulletPrefab, bulletPivot.position, bulletPivot.rotation);
            shotCounter = shotDelay;

        }
        if (Input.GetButton("Fire1"))
        {
            shotCounter -= Time.deltaTime;

            if(shotCounter <= 0)
            {
                Instantiate(bulletPrefab, bulletPivot.position, bulletPivot.rotation);
                shotCounter = shotDelay;
            }
            

        }
        /*if (Input.GetKeyDown(KeyCode.Z))
        {
            GameObject temp = Instantiate(bulletPrefab, bulletPivot.position, bulletPivot.rotation);
        }*/
    }
    public void Die()
    {
        Destroy(gameObject);
    }
}
