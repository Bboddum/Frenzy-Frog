using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tramboline : MonoBehaviour
{
    public Animator anim;
    [SerializeField] private AudioSource Spring;

    public float jumpforce = 20;
    // Start is called before the first frame update
    void Start()
    {
        
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("Player"))
        {
            anim.SetBool("onspring", true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            anim.SetBool("onspring", false);
        }

        if(collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if(rb != null)
            {
                Spring.Play();
                Vector2 velocity = rb.velocity;
                velocity.y = jumpforce;
                rb.velocity = velocity;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
