using System;
using Configurations;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI.ChooseCharacter
{
    public class ChooseScreen : MonoBehaviour
    {
        [SerializeField] private ChooseCharacterController character1;
        [SerializeField] private ChooseCharacterController character2;
        [SerializeField] private PlayerConfiguration configuration;

        private void Start()
        {
            character1.Subscribe();
            character2.Subscribe();
            
            character1.Initialize();
            character2.Initialize();
        }

        public void Play()
        {
            Debug.Log( configuration.playerSelections[1].characterName );
            Debug.Log( configuration.playerSelections[2].characterName );
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        private void OnDestroy()
        {
            character1.UnSubscribe();
            character2.UnSubscribe();
        }
    }
}