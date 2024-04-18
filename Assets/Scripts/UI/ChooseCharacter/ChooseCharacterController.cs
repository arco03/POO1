using Characters;
using Configurations;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI.ChooseCharacter
{
    public class ChooseCharacterController : MonoBehaviour
    {
        [SerializeField] private int playerNumber;
        [Header("View")]
        [SerializeField] private ChooseCharacterView characterView;
        [Header("Model")]
        [SerializeField] private PlayerConfiguration playerConfiguration;
        
        private int _currentIndex = 0;
        
        public void Subscribe()
        {
            characterView.OnButtonPress += ChangePlayer;
            
            characterView.Subscribe();

            Character character = playerConfiguration.characters[_currentIndex];
            Sprite characterSprite = character.characterSprite;
            string characterName = character.characterName;
            
            characterView.ChangeCharacter(characterSprite, characterName);
        }

        public void Initialize()
        {
            _currentIndex = 0;
            ChangePlayer(0);
        }

        private void ChangePlayer(int index)
        {
            _currentIndex += index;
            _currentIndex = Mathf.Clamp(_currentIndex, 0, playerConfiguration.characters.Count - 1);
            
            Character playerSelection = playerConfiguration.characters[_currentIndex];
            Sprite characterSprite = playerSelection.characterSprite;
            string characterName = playerSelection.characterName;

            playerConfiguration.playerSelections[playerNumber] = playerSelection;
            characterView.ChangeCharacter(characterSprite, characterName);
        }

        public void UnSubscribe()
        {
            characterView.UnSubscribe();
        }
        
    }
}