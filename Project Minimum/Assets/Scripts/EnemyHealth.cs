﻿using UnityEngine;

namespace CompleteProject
{
    public class EnemyHealth : MonoBehaviour
    {
        public int startingHealth = 100;            // The amount of health the enemy starts the game with.
        public int currentHealth;                   // The current health the enemy has.
        
        public AudioClip deathClip;                 // The sound to play when the enemy dies.

        AudioSource enemyAudio;                     // Reference to the audio source.
        ParticleSystem hitParticles;                // Reference to the particle system that plays when the enemy is damaged.
        CapsuleCollider capsuleCollider;            // Reference to the capsule collider.
        bool isDead;                                // Whether the enemy is dead.
        //bool isSinking;                             // Whether the enemy has started sinking through the floor.


        void Awake ()
        {
            // Setting up the references.
            enemyAudio = GetComponent <AudioSource> ();
            hitParticles = GetComponentInChildren <ParticleSystem> ();
            capsuleCollider = GetComponent <CapsuleCollider> ();

            // Setting the current health when the enemy first spawns.
            currentHealth = startingHealth;
        }


        public void TakeDamage (int amount, Vector3 hitPoint)
        {
            // If the enemy is dead...
            if(isDead)
                // ... no need to take damage so exit the function.
                return;

            // Play the hurt sound effect.
            // enemyAudio.Play ();

            // Reduce the current health by the amount of damage sustained.
            currentHealth -= amount;
            
            // Set the position of the particle system to where the hit was sustained.
            // hitParticles.transform.position = hitPoint;

            // And play the particles.
            // hitParticles.Play();

            // If the current health is less than or equal to zero...
            if(currentHealth <= 0)
            {
                // ... the enemy is dead.
                Death ();
            }
        }


        void Death ()
        {
            // The enemy is dead.
            isDead = true;

            // Turn the collider into a trigger so shots can pass through it.
            capsuleCollider.isTrigger = true;

            // Change the audio clip of the audio source to the death clip and play it (this will stop the hurt clip playing).
            //enemyAudio.clip = deathClip;
            //enemyAudio.Play ();

            // After 2 seconds destroy the enemy.
            Destroy(gameObject, 0.5f);
        }
                       
    }
}