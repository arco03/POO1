using Attacks;
using Interactable;
using UnityEngine;
using Variables;

namespace Playable
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Character : MonoBehaviour, IDamageable
    {
        // Dependencies
        private VariableInt _hp;
        private float _jumpForce;
        private float _speed;
        private Bullet _bulletPrefab;
        private Transform _spawnPosition;
        private Transform attackController;
        private static float radius;
        private static string tagPLayer;
        
        private Rigidbody2D _rb;
        private bool _onGround;
        IAttack iattackGun = new AttackGun();
        IAttack iattack = new AttackMelee();

        // SetUp Method that inject dependencies.
        public void SetUp(VariableInt hp, float jumpForce, float speed, float attackRange,
            Bullet bulletPrefab, Transform spawnPosition)
        {
            _hp = hp;
            _jumpForce = jumpForce;
            _speed = speed;
            _bulletPrefab = bulletPrefab;
            _spawnPosition = spawnPosition;
        }
        
        public void AttackGun()
        {
            Instantiate(_bulletPrefab, _spawnPosition.position, Quaternion.identity);
            iattackGun.Attack();
        }

        public void AttackMelee()
        {
            iattack.Attack();
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
        //public void OnDrawGizmos()
        //{
          //  Gizmos.color = Color.red;
            //Gizmos.DrawWireSphere(_attackController.position,_radius);
        //}
    }
}