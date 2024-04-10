using UnityEngine;

namespace Playable
{
    public class Player : MonoBehaviour
    {
        [Header("Control Settings")]
        [SerializeField] private string horizontal;
        [SerializeField] private string jumpKey;

        [Header("Settings")]
        [SerializeField] private float jumpForce;
        [SerializeField] private float speed;
        [SerializeField] private float attackRange;
        [SerializeField] private Transform attackPoint;
        
        [SerializeField] private Character _character;
        
        private float _x;
        private void Start()
        {
            _character.SetUp(jumpForce, speed, attackRange, attackPoint, attackPoint);
        }
        
        private void FixedUpdate()
        {
            _character.Move(_x);
        }
        
        private void Update()
        {
            _x = Input.GetAxisRaw(horizontal);
            if  (Input.GetKeyDown(jumpKey))
            {
                _character.Jump();
            }
        }

    }
}
