using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    public float jumpforce; // quarda a força do pulo
    public Rigidbody2D rig; // componente do player na unity

    float direction;  // quarda a posição do player
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // checa se o player moveu para esquerda ou direita
        // direita = 1 | esquerda = -1 | sem mover = 0
        direction = Input.GetAxis("Horizontal");

        // faz o player pular
        if(Input.GetKeyDown(KeyCode.Space)){
            rig.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
        }
    }

    // meche na fisica do jogo
    void FixedUpdate() {
        // faz o player se mover
        rig.velocity = new Vector2(direction * speed, rig.velocity.y);
    }
}
