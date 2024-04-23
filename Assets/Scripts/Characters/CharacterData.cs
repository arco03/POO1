using Playable;
using UnityEngine;

namespace Characters
{
    [CreateAssetMenu(menuName = "CreateCharacter", fileName = "Character")]
    public class CharacterData : ScriptableObject
    {
        public string characterName;
        public Sprite characterSprite;
        public Character characterPrefab;
    }
}