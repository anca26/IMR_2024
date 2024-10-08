using UnityEngine;

public class CharacterBehavior : MonoBehaviour
{
    public Animator animator;
    public float detectionRadius = 0.25f; 

    void Update()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, detectionRadius);
        bool isAttacking = false;

        foreach (var hitCollider in hitColliders)
        {
            if (hitCollider.gameObject != gameObject) 
            {
                isAttacking = true; 
                break;
            }
        }

        if (isAttacking)
        {
            animator.SetBool("isAttacking", true);
        }
        else
        {
            animator.SetBool("isAttacking", false);
        }
    }
}
