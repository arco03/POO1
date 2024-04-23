using Attacks;
using Interactable;
using UnityEngine;
using Variables;

namespace Playable
{
    public class Player : MonoBehaviour
    {
        [Header("Control Settings")]
        [SerializeField] private string horizontal;
        [SerializeField] private string jumpKey;
        [SerializeField] private string attackMeleeKey;
        [SerializeField] private string attackGunKey;


        [Header("Settings")]
        [SerializeField] private float jumpForce;
        [SerializeField] private float speed;
        [SerializeField] private float attackRange;
        [SerializeField] private Transform attackController;
        [SerializeField] private float radius;
        [SerializeField] private string tagPlayer;
        [SerializeField] private VariableInt hp;
        [SerializeField] private Bullet bulletPrefab;
        [SerializeField] private Transform spawnPosition;
        [SerializeField] private CharacterAnimator characterAnimator;
        [SerializeField] private Character character;
        private AttackMelee _attackMelee;
        private float _x;
        
        
        private void Start()
        {
            character.SetUp(hp,jumpForce, speed, attackRange, bulletPrefab, spawnPosition,
                attackController,radius,tagPlayer);
            // _attackMelee.SetAttack(attackController,radius,tagPlayer);
        }

        private void FixedUpdate()
        {
            character.Move(_x);
            characterAnimator.Walk();
        }

        private void Update()
        {
            _x = Input.GetAxisRaw(horizontal);
            if (Input.GetKeyDown(jumpKey))
            {
                character.Jump();
            }

            if (Input.GetKeyDown(attackMeleeKey))
            {
                character.AttackMelee();
                characterAnimator.Attack1();
            }

            if (Input.GetKeyDown(attackGunKey))
            {
                character.AttackGun();
                characterAnimator.Attack2();
            }
        }

        public void OnDrawGizmos()
            { 
                Gizmos.color = Color.red;
                Gizmos.DrawWireSphere(attackController.position,radius);
            }
    }
}

