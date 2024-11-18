using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField] List<Material> materials;
    [SerializeField] MeshRenderer meshRenderer;
    private Rigidbody rb;
    public float jumpForce = 5.0f;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Jump()
    {
        rb.AddForce(transform.up * jumpForce,ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        int rnd = Random.Range(0, materials.Count - 1);
        if (collision.collider.CompareTag("Ground"))
        {
            Jump();
            meshRenderer.material = materials[rnd];
        }
        
    }
}
