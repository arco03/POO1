using UnityEngine;

namespace Playable
{
    public class CharacterAnimator : MonoBehaviour
    {
        private Animator _animator;
        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        public void ResetAnimation()
        {
            _animator.SetBool("isWalking", false);
        }

        public void Idle()
        {
            ResetAnimation();
            _animator.SetTrigger("idle");
        }

        public void Attack1()
        {
            ResetAnimation();
            _animator.SetTrigger("attack1");
        }

        public void Attack2()
        {
            ResetAnimation();
            _animator.SetTrigger("attack2");
        }

        public void Walk()
        {
            ResetAnimation();
            _animator.SetBool("isWalking", true);
        }

    }
}