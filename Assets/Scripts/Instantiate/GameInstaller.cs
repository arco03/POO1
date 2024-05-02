using Configurations;
using Playable;
using UnityEngine;

namespace Instantiate
{
    public class GameInstaller : MonoBehaviour
    {
        [Header("Requeriments")]
        public Transform positionPlayer1;
        public Transform positionPlayer2;
        
        [Header("Factory configuration")] 
        public PlayerConfiguration configuration;

        private CharacterFactory _characterFactory;

        private void Awake()
        {
            _characterFactory = new CharacterFactory(configuration);
        }

        private void Start()
        {
            Character player1 = _characterFactory.Create(playerNumber:1);
            Character player2 = _characterFactory.Create(playerNumber:2);

            player1.transform.position = positionPlayer1.position;
            player2.transform.position = positionPlayer2.position;
        }
    }
}