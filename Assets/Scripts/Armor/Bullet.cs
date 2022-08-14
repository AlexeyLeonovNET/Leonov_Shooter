using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float Speed = 10f;
        [SerializeField] private float damage = 5f;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        }
        public void OnCollisionEnter(Collision collision)
        {
            Hit(collision.gameObject);
        }
        public void OnTriggerEnter(Collision other)
        {
            Hit(other.gameObject);
        }
        public void Hit(GameObject collisionGameObject)
        {
            if (collisionGameObject.TryGetComponent(out HealthManager health))
            {
                health.Hit(damage);
            }
            Destroy(gameObject);
        }
    }
}