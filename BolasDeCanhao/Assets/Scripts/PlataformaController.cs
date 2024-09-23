using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaController : MonoBehaviour
{
    [SerializeField] private float caminho;
    private Vector3 posicaoOriginal;
    // Start is called before the first frame update
    void Start()
    {
        posicaoOriginal = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var movimento = Mathf.PingPong(Time.time, 2);
        transform.position = posicaoOriginal + new Vector3(0,movimento*caminho,0);
    }
}
