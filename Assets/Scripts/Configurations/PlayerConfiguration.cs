using System.Collections.Generic;
using Characters;
using UnityEngine;

namespace Configurations
{
    [CreateAssetMenu(fileName = "Configuration/Player", menuName = "PlayerConfiguration")]
    public class PlayerConfiguration : ScriptableObject
    {
        public List<Character> characters;
        public Dictionary<int, Character> playerSelections = new Dictionary<int, Character>();
    }
}