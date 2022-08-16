using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class ShootingEnemy : MonoBehaviour
    {
        [SerializeField] private GameObject bulletPrefab; 
        [SerializeField] private Transform BulletPoint; 
        [SerializeField] private float spawnStep = 1f; 
        [SerializeField] private float angularSpeed = 0.5f;
        private float nextSpawnTime; 
        private Transform player;

        void Start()
        {
            player = FindObjectOfType<Shooter.PlayerMovement>().transform;
        }

        void Update()
        {
            LookAtPlayer();
            Shoot();

        }
        public void LookAtPlayer()
        {
            var direction = player.transform.position - transform.position;
            var rotation = Vector3.RotateTowards(transform.forward, direction, angularSpeed * Time.deltaTime, 0f);
            transform.rotation = Quaternion.LookRotation(rotation);
        }
        public void Shoot()
        {
            if (Time.time > nextSpawnTime)
            {
                Instantiate(bulletPrefab, BulletPoint.position, BulletPoint.rotation);
                nextSpawnTime = Time.time + spawnStep;
            }
        }
    }
}