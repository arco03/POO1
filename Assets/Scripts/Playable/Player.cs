using Interactable;
using UnityEngine;
using UnityEngine.Serialization;
using Variables;

namespace Playable
{
    public class Player : MonoBehaviour
    {
        [Header("Control Settings")]
        [SerializeField] private string horizontal;
        [SerializeField] private string jumpKey;
        [SerializeField] private KeyCode teclaAtaque;
        [SerializeField] private string attackGunKey;


        [Header("Settings")]
        [SerializeField] private float jumpForce;
        [SerializeField] private float speed;
        [SerializeField] private float attackRange;
        [SerializeField] private Transform controladorAtaque;
        [SerializeField] private float radio;
        [SerializeField] private VariableInt hp;
        [SerializeField] private Bullet bulletPrefab;
        [SerializeField] private Transform spawnPosition;
        [SerializeField] private CharacterAnimator characterAnimator;

        [FormerlySerializedAs("_character")][SerializeField] private CharacterController characterController;

        private float _x;
        private void Start()
        {

            

            characterController.SetUp(hp,jumpForce, speed, attackRange, bulletPrefab, spawnPosition,controladorAtaque, radio);

        }

        private void FixedUpdate()
        {
            characterController.Move(_x);
            characterAnimator.Walk();
        }

        private void Update()
        {
            _x = Input.GetAxisRaw(horizontal);
            if (Input.GetKeyDown(jumpKey))
            {
                characterController.Jump();
                
            }

            if (Input.GetKeyDown(attackGunKey))
            {
                characterController.AttackGun();
                characterAnimator.Attack2();
            }
            
            if (Input.GetKeyDown(teclaAtaque))
            {
                characterController.AttackMelee();
                characterAnimator.Attack1();
            }

        }
    }
}

