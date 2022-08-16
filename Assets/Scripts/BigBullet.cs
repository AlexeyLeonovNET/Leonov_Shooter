using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class BigBullet : MonoBehaviour
    {
        public int speed = 25;
        void Update()
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime); //�����������
            Destroy(gameObject, 0.5f);
        }
    }
}