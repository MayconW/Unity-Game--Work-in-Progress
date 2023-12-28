using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator playerAnimator;
    float input_x = 0;
    float input_y = 0;
    public float speed = 2.5f;
    bool isWalking = false;
    bool isCasting = false; // Adicionando a variável isCasting

    void Start()
    {
        isWalking = false;
        isCasting = false;
    }

    void Update()
    {
        input_x = Input.GetAxisRaw("Horizontal");
        input_y = Input.GetAxisRaw("Vertical");
        isWalking = (input_x != 0 || input_y != 0);

        if (isWalking)
        {
            var move = new Vector3(input_x, input_y, 0).normalized;
            transform.position += move * speed * Time.deltaTime;
            playerAnimator.SetFloat("input_x", input_x);
            playerAnimator.SetFloat("input_y", input_y);
        }

        playerAnimator.SetBool("isWalking", isWalking);

        if (Input.GetButtonDown("Fire1"))
            playerAnimator.SetTrigger("attack");

        // Verifica se a tecla de espaço foi pressionada
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isCasting = true; // Define isCasting como true
            playerAnimator.SetBool("isCasting", isCasting); // Ativa a animação "Cast"
        }
        // Verifica se a tecla de espaço foi solta
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            isCasting = false; // Define isCasting como false
            playerAnimator.SetBool("isCasting", isCasting); // Desativa a animação "Cast"
        }
    }
}
