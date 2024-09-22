using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanhaoController : MonoBehaviour
{
    public Vector3 direcao;
    [SerializeField] private GameObject bala;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        Vector3 posicaoMouse = Input.mousePosition;
        posicaoMouse = Camera.main.ScreenToWorldPoint(posicaoMouse);

        direcao = new Vector2(posicaoMouse.x - transform.position.x,posicaoMouse.y - transform.position.y);

        transform.up = direcao;
        meteBala();
    }
    void meteBala()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bala, transform.position, transform.rotation);
        }
        
    }
    Vector3 getDirecao() {  return direcao; }
    
}
