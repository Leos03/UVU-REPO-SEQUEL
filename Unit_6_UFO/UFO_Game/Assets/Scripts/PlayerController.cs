using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 25;
    public float xRange = 30;
    public Transform pewPew;
    public AudioClip shootSound;
    private AudioSource playerAudio;
    public GameObject laser;
    public GameManager gameManager;


    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        // Set horizontal input to get values from the noisy letter button board
        horizontalInput = Input.GetAxis("Horizontal");
        // Player go L & R
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        // THERE IS NO ESCAPE  ;  Stay in the zone, AutoZone
        // Slide to the left 
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        // Slide to the right
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false)
        {
            Instantiate(laser, pewPew.transform.position, laser.transform.rotation);
            playerAudio.PlayOneShot(shootSound, 1.0f);
        }
    }

    /* private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
    */
}
