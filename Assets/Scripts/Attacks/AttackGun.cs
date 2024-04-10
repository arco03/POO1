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
            Object.Instantiate(_bulletPrefab, _spawnPosition.position, Quaternion.identity);
        }
    }
}