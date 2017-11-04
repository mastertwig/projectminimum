using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    public Image damageImage;
    public AudioClip deathClip;
        
    AudioSource playerAudio;
    PlayerMovement playerMovement;
    bool isDead;
    bool damaged;


    void Awake ()
    {
        playerAudio = GetComponent <AudioSource> ();
        playerMovement = GetComponent <PlayerMovement> ();
        currentHealth = startingHealth;
    }


    public void TakeDamage (int amount)
    {
        damaged = true;

        currentHealth -= amount;

        playerAudio.Play ();

        if(currentHealth <= 0 && !isDead)
        {
            Death ();
        }
    }


    void Death ()
    {
        isDead = true;

        playerAudio.clip = deathClip;
        playerAudio.Play ();

        playerMovement.enabled = false;

        RestartLevel();
    }


    public void RestartLevel ()
    {
        SceneManager.LoadScene (0);
    }
}
