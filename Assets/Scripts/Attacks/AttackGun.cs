using System;
using Interactable;
using UnityEngine;

namespace Attacks
{
    public class AttackGun : IAttack
    {
        [SerializeField] private Bullet _bulletPrefab;
        [SerializeField] private Transform _spawnPosition;
        public void Attack()
        {
            Debug.Log("Entro A attack");
        }
    }
}