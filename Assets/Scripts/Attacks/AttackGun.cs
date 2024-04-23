using System;
using Interactable;
using UnityEngine;

namespace Attacks
{
    public class AttackGun : IAttack
    {
        private Bullet _bulletPrefab;
        private Transform _spawnPosition;
        public void Attack()
        {
            Debug.Log("Entro A attack");
        }
    }
}