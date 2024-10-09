using UnityEngine;

public class CharacterBehavior : MonoBehaviour
{
    public Animator animator;
    public float detectionRadius = 0.25f;


    void Start()
    {
        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }
    }


    void Update()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, detectionRadius);
        bool isAttacking = false;

        foreach (var hitCollider in hitColliders)
        {
            Debug.Log("Detected: " + hitCollider.gameObject.name);

            if (hitCollider.gameObject != gameObject) 
            {
                isAttacking = true; 
                break;
            }
        }

        if (isAttacking)
        {
            Debug.Log("Character is attacking");
            animator.SetBool("isAttacking", true);
        }
        else
        {
            animator.SetBool("isAttacking", false);
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRadius);
    }
}
