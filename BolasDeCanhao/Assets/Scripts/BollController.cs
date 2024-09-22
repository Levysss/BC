using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BollController : MonoBehaviour
{
    
    private Rigidbody2D myRB;
    [SerializeField] private float speed;
    [SerializeField] private float tempoDeVida;
    // Start is called before the first frame update
    void Start()
    {
        
        myRB = GetComponent<Rigidbody2D>();
        Destroy(gameObject,tempoDeVida);
        

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(transform.up* speed * Time.fixedDeltaTime,Space.World);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Bolinha") == gameObject.CompareTag("Bolinha"))
        {
            
            Destroy(gameObject);
        }
    }
}
