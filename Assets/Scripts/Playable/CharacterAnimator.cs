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

        public void AnimateTrigger(string nameAnimation)
        {
            ResetAnimation();
            _animator.SetTrigger(nameAnimation);
            
        }
        

    }
}