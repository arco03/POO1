using UnityEngine;

namespace Characters
{
    [CreateAssetMenu(menuName = "CreateCharacter", fileName = "Character")]
    public class Character : ScriptableObject
    {
        public string characterName;
        public Sprite characterSprite;
        public Animator animatorController;
    }
}