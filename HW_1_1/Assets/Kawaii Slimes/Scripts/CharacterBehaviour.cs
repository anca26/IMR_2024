using UnityEngine;

public class CharacterBehavior : MonoBehaviour
{
    public Animator animator;
    public GameObject target; 
    public float detectionRadius = 0.25f;


    void Update()
    {

        if (target)
        {

            float distance = Vector3.Distance(target.transform.position, transform.position);
            bool isAttacking = distance <= detectionRadius;

            animator.SetBool("isAttacking", isAttacking);

            if (isAttacking)
            {
                Debug.Log("Attack initiated: Targets are close.");
            }
        }
    }
}
