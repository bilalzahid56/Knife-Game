using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Knife : MonoBehaviour
{
    private BoxCollider2D box;
    private Rigidbody2D rb;
    // public Vector2 throwForce;
    [SerializeField]
    private Vector2 throwForce;
    public GameObject knife;
    public GameObject area;
    public int count = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(throwForce,ForceMode2D.Impulse);
            rb.gravityScale = 1;
           // Instantiate(knife, area.transform.position, area.transform.rotation);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("log"))
        {
            rb.velocity = new Vector2(0, 0);
            //  rb.velocity = new Vector2(0, 0);
            rb.bodyType = RigidbodyType2D.Kinematic;
            transform.SetParent(collision.collider.transform);
            box.offset = new Vector2(box.offset.x, 0.5f);
            box.size = new Vector2(box.size.x, 1.5f);
        }
        else if(collision.gameObject.CompareTag("Knife"))
        {
          
            
                rb.velocity = new Vector2(rb.velocity.x, -3);
            // Destroy(this.gameObject);
            rb.gravityScale = 10;
            SceneManager.LoadScene(0);


        }
    }
   
}
