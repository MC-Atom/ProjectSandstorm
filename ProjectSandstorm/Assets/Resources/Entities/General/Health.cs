using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int health = 100;

    private bool invisibilityFrames = false;
    private float timeToBeInvinsible = 0.25f;
    private float timer = 0f;

    private int MAX_HEALTH = 100;

    // Update is called once per frame
    void Update()
    {
        if(invisibilityFrames){
            timer += Time.deltaTime;

            if (timer >= timeToBeInvinsible){
                timer = 0;
                invisibilityFrames = false;
            }
        }
    }

    public void Damage(int amount)
    {
        if(!invisibilityFrames){
            if(amount < 0)
            {
                throw new System.ArgumentOutOfRangeException("Cannot have negative Damage");
            }

            this.health -= amount;

            if(health <= 0)
            {
                Die();
            }
        }
    }

    public void Heal(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative healing");
        }

        bool wouldBeOverMaxHealth = health + amount > MAX_HEALTH;

        if (wouldBeOverMaxHealth)
        {
            this.health = MAX_HEALTH;
        }
        else
        {
            this.health += amount;
        }
    }

    private void Die()
    {
        Debug.Log("I am Dead!");
        Destroy(gameObject);
    }
}