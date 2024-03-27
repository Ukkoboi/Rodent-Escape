using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float movementspeed;
    public float turningspeed;

    private Rigidbody rb;
    private AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {

    }

    void FixedUpdate()
    {

        Vector3 currentRotation = rb.rotation.eulerAngles;
        rb.rotation = Quaternion.Euler(0f, currentRotation.y, 0f);

        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");

        if (inputHorizontal != 0)
        {
            Vector3 turning = Vector3.up * inputHorizontal * turningspeed;
            rb.angularVelocity = turning;
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }

        if (inputVertical != 0)
        {
            Vector3 movement = transform.forward * inputVertical * movementspeed;
            rb.velocity = movement;
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
