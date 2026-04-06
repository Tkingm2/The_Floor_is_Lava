using System.Collections;
using UnityEngine;

public class StopFalll : MonoBehaviour
{
    public float fallDelay = 1.0f; // Time before the platform falls
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        // Ensure only the player triggers the fall
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Fall());
        }
    }

    IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        rb.isKinematic = false; // Enables gravity so the platform falls
       
    }
}