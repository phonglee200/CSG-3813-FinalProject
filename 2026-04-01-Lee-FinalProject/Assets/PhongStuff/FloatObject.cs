using UnityEngine;

public class FloatObject : MonoBehaviour {
    public Rigidbody rb;
    public float depthBeforeSubmerged = 1f;
    public float displacementAmount = 3f;
    public int floaterCount = 1;
    public float waterHeight = 0f; // Update this with your ocean's height sampling logic

    void FixedUpdate() {
        // Calculate buoyancy force based on depth
        if (transform.position.y < waterHeight) {
            float displacementMultiplier = Mathf.Clamp01((waterHeight - transform.position.y) / depthBeforeSubmerged) * displacementAmount;
            rb.AddForceAtPosition(new Vector3(0f, Mathf.Abs(Physics.gravity.y) * displacementMultiplier, 0f), transform.position, ForceMode.Acceleration);
            rb.AddForce(displacementMultiplier * -rb.linearVelocity * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }
    }
}