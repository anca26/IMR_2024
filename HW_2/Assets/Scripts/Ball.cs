using UnityEngine;

public class Ball : MonoBehaviour
{
    public float hitForceMultiplier = 10f; 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bat"))
        {
        
            Vector3 hitDirection = collision.relativeVelocity.normalized;
            float hitForce = collision.relativeVelocity.magnitude * hitForceMultiplier;

           
            Rigidbody ballRigidbody = GetComponent<Rigidbody>();
            ballRigidbody.AddForce(hitDirection * hitForce, ForceMode.Impulse);

            Debug.Log("Ball hit with force: " + hitForce);
        }
    }
}
