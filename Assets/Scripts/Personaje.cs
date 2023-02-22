using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    //Movimiento del jugador
    [Range(1,10)]public float velocidad;
    Rigidbody2D rigidbody2;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        float movimientoH = Input.GetAxisRaw("Horizontal");
        rigidbody2.velocity=new Vector2 (movimientoH*velocidad, rigidbody2.velocity.y);
    }
}
