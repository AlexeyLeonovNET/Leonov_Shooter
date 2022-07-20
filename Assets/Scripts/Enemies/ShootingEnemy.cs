using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class ShootingEnemy : MonoBehaviour
    {
        [SerializeField] private GameObject bulletPrefab; // поле для префаба
        [SerializeField] private Transform BulletPoint; // поле для трансформы
        [SerializeField] private float spawnStep = 1f; // частота спавна
        [SerializeField] private float angularSpeed = 0.5f;
        private float nextSpawnTime; // шаг спавна
        private Transform player;

        void Start()
        {
            player = FindObjectOfType<Player.PlayerMovement>().transform;
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