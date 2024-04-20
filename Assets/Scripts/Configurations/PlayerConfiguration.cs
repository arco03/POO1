using System.Collections.Generic;
using Characters;
using UnityEngine;

namespace Configurations
{
    [CreateAssetMenu(fileName = "Configuration/Player", menuName = "PlayerConfiguration")]
    public class PlayerConfiguration : ScriptableObject
    {
        public List<CharacterData> characters;
        public Dictionary<int, CharacterData> playerSelections = new Dictionary<int, CharacterData>();
    }
}