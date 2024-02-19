== primeiro codigo no unity

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int score;
    protected int experience;
    public Rigidbody2D rb;
public BoxCollider2D boxCollider;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("O jogo começou!");
        rb = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (score >= 100)
        {
            print("Pontuação ótima!");
        }
        else if (score >= 20 && score < 50)
        {
            print("Pontuação boa");
        }
        rb.velocity = new Vector2(0,0);
        // Código para atualizar o comportamento do jogador vai aqui
    }
}

===============================================================================

exercicio 2 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float a = Input.GetAxis("Horizontal");
        float b = Input.GetAxis("Vertical");
    }
}
