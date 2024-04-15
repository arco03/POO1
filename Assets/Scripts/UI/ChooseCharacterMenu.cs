using System.Linq;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class ChooseCharacterMenu : MonoBehaviour
    {
        private int _index;
        private GameManager _gameManager;
        [SerializeField] private Image image;
        [SerializeField] private TextMeshProUGUI name;

        private void Start()
        {
            _gameManager = GameManager.Instance;
            _index = PlayerPrefs.GetInt("PlayerIndex");
            if (_index > _gameManager.characters.Count - 1) _index = 0;
            ChangeScreen();
        }

        private void ChangeScreen()
        {
            PlayerPrefs.SetInt("PlayerIndex", _index);
            image.sprite = _gameManager.characters[_index].characterSprite;
            name.text = _gameManager.characters[_index].name;
        }

        public void AfterCharacter()
        {
            if (_index == _gameManager.characters.Count - 1) _index += 1;
            else _index += 1;
            ChangeScreen();
        }
        public void BeforeCharacter()
        {
            if (_index == 0) _index = _gameManager.characters.Count - 1;
            else _index -= 1;
            ChangeScreen();
        }
        public void PlayGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}