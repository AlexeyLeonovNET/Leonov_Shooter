using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class HealthManager : MonoBehaviour
    {
        [SerializeField] private float maxHealth = 100f;
        [SerializeField] private float curHealth;
        public float health;

        public void Awake()
        {
            curHealth = maxHealth;
        }

        public void Hit(float damage)
        {
            curHealth -= damage;
            if (curHealth <= 0)
            {
                Time.timeScale = 0;
            }
        }

        public void SetHealth(int bonusHealth)
        {
            health += bonusHealth;
            if (health > maxHealth)
            {
                health = maxHealth;
            }
        }
    }
}