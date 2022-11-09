using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public ScoreManager scoreManager;
    public AudioClip oofSound;
    private AudioSource enemyAudio;
    public int scoreToGive;

    void Start()
    {
        enemyAudio = GetComponent<AudioSource>();
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        scoreManager.IncreaseScore(scoreToGive);
        Destroy(gameObject);
        Destroy(other.gameObject);
        enemyAudio.PlayOneShot(oofSound, 1.0f);
    }
}
