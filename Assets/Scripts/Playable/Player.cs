using UnityEngine;
using Variables;

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
        [SerializeField] private Transform attackPointA;
        [SerializeField] private Transform attackPointB;
        [SerializeField] private VariableInt hp;
        
        [SerializeField] private Character _character;
        
        private float _x;
        private void Start()
        {
            _character.SetUp(hp,jumpForce, speed, attackRange, attackPointA, attackPointB);
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
