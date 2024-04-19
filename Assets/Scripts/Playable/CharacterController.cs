using Attacks;
using Interactable;
using UnityEngine;
using Variables;

namespace Playable
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class CharacterController : MonoBehaviour, IDamageable
    {
        // Dependencies
        private VariableInt _hp;
        private float _jumpForce;
        private float _speed;
        private float _attackRange;
        private Transform _attackPointA;
        private Transform _attackPointB;
        private Bullet _bulletPrefab;
        private Transform _spawnPosition;

        private Rigidbody2D _rb;
        private bool _onGround;
        public AttackGun _attackGun;
        private AttackMelee _attackMelee;

        // SetUp Method that inject dependencies.
        public void SetUp(VariableInt hp, float jumpForce, float speed, float attackRange, Bullet bulletPrefab, Transform spawnPosition)
        {
            _hp = hp;
            _jumpForce = jumpForce;
            _speed = speed;
            _attackRange = attackRange;
            _bulletPrefab = bulletPrefab;
            _spawnPosition = spawnPosition;
        }
        public void AttackGun()
        {
             Instantiate(_bulletPrefab, _spawnPosition.position, Quaternion.identity);
             IAttack iattackGun = new AttackGun();
             iattackGun.Attack();
        }

        public void AttackMelee()
        {
            IAttack iattackMelee = new AttackMelee();
            iattackMelee.Attack();
        }

        public void Jump()    
        {
            if (!_onGround) return;

            _rb.velocity = new Vector2(_rb.velocity.x, _jumpForce);
            _onGround = false;
        }

        public void Move(float x)
        {
            Vector2 xMovement = new Vector2(x, 0);
            _rb.velocity = new Vector2(xMovement.x * _speed, _rb.velocity.y);
        }

        public void Damage(int damage)
        {
            
        }

        public void KnockBack()
        {

        }

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
            _onGround = true;
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Ground"))
            {
                _onGround = true;
            }
        }
    }
}
