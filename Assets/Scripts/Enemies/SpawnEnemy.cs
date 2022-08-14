using UnityEngine;

namespace Shooter
{
    public class SpawnEnemy : MonoBehaviour
    {
        [SerializeField] private Enemy enemyPrefab;
        [SerializeField] private float spawnStep = 1f;
        private float nextSpawnTime;
        private const float LifeTime = .5f;

        private void Update()
        {
            if (Time.time > nextSpawnTime)
            {
                var enemy = Instantiate(enemyPrefab, transform);
                nextSpawnTime = Time.time + spawnStep;
                Destroy(enemy.gameObject, LifeTime);
            }

        }
    }
}
