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
        private float _attackRange;
        private Transform _attackPointA;
        private Transform _attackPointB;

        private Rigidbody2D _rb;
        private bool _onGround;

        // SetUp Method that inject dependencies.
        public void SetUp(VariableInt hp, float jumpForce, float speed, float attackRange, Transform attackPointA,
            Transform attackPointB)
        {
            _hp = hp;
            _jumpForce = jumpForce;
            _speed = speed;
            _attackRange = attackRange;
            _attackPointA = attackPointA;
            _attackPointB = attackPointB;
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
            Debug.Log("gg");
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
