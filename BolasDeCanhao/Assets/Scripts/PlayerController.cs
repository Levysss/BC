using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float forcaPulo;
    private Rigidbody2D rb;
    private bool vivo = true;
    private bool pulou= false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movimentaco();
        
    }
    private void Update()
    {
        pulo();
    }

    void movimentaco()
    {
        Vector3 movimento = new Vector3(Input.GetAxis("Horizontal"),0);
        transform.position += movimento * Time.fixedDeltaTime * speed;
    }
    void pulo()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Era pra pular");
            rb.AddForce(new Vector2(0f,forcaPulo), ForceMode2D.Impulse);
            pulou = true;
        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        pulou= false;
    }
}
