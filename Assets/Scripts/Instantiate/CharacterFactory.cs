using Configurations;
using Playable;
using Unity.Mathematics;


namespace Instantiate
{
    public class CharacterFactory
    {
        private readonly PlayerConfiguration _config;
        
        public CharacterFactory(PlayerConfiguration config)
        {
            _config = config;
        }

        public Character Create(int playerNumber, bool rotate=true)
        {
            Character instantiateCharacter = _config.playerSelections[playerNumber].characterPrefab;
            return UnityEngine.Object.Instantiate(instantiateCharacter);
           
        }

    }
}