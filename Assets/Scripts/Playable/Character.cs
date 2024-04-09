using UnityEngine;

namespace Playable
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Character : MonoBehaviour
    {
        private float _jumpForce;
        private float _speed;
        private float _attackRange;
        private Transform _attackPoint;
        
        private Rigidbody2D _rb;
        private bool _onGround;

        public void SetUp(float jumpForce, float speed, float attackRange, Transform attackPoint)
        {
            _jumpForce = jumpForce;
            _speed = speed;
            _attackRange = attackRange;
            _attackPoint = attackPoint;
        }

        public void Jump()
        {
            if (!_onGround) return;

            _rb.velocity = new Vector2(_rb.velocity.x, _jumpForce);
            _onGround = false;
        }

        public void Move(float x)
        {
            Vector2 xMovement = new Vector2 (x, 0);
            _rb.velocity = new Vector2 (xMovement.x*_speed, _rb.velocity.y);
        }
    
        public void Attack()
        {
            Collider2D[] results = new Collider2D[2];
            Physics2D.OverlapCircleNonAlloc(_attackPoint.position, _attackRange, results);
        
            //foreach(Collider2D coll in results)
            //{
                
            //}
        }
        
        public void Damage()
        {

        }
        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
            _onGround = true;
        }
        
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if(collision.gameObject.CompareTag("Ground"))
            {
                _onGround = true;
            }
        }
        
        public void OnDrawGizmos()
        {
            if (_attackPoint == null) return;
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(_attackPoint.position, _attackRange);
        }

        
    }
}   
