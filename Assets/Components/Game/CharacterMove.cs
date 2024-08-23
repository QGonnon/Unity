using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public int moveSpeed = 10;
    public float rotationSpeed = 2f; // Vitesse de rotation ajustable
    private bool canMove = true;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void StopMovement()
    {
        canMove = false;
    }

    public void ResumeMovement()
    {
        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            // Calcul du mouvement basé sur les entrées de l'utilisateur
            Vector3 movementV = transform.forward * Input.GetAxis("Vertical");
            Vector3 movementH = transform.right * Input.GetAxis("Horizontal");
            Vector3 movement = (movementV + movementH).normalized;

            if (movement.magnitude > 0)
            {
                animator.SetBool("isRunning", true);

                Quaternion targetRotation = Quaternion.LookRotation(movement);
                transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

                // Déplacement du personnage
                transform.position += movement * moveSpeed * Time.deltaTime;
            }
            else
            {
                animator.SetBool("isRunning", false);
            }
        }
        
    }
}
