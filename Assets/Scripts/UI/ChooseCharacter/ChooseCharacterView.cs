using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.ChooseCharacter
{
    public class ChooseCharacterView : MonoBehaviour
    {
        public Action<int> OnButtonPress;
        
        [SerializeField] private Image characterImage;
        [SerializeField] private TextMeshProUGUI characterName;
        [SerializeField] private Button next;
        [SerializeField] private Button prev;

        public void Subscribe()
        {
            next.onClick.AddListener( () => OnButtonPress?.Invoke(1) );
            prev.onClick.AddListener( () => OnButtonPress?.Invoke(-1) );
        }

        public void ChangeCharacter(Sprite sprite, string newName)
        {
            characterImage.sprite = sprite;
            characterName.text = newName;
        }

        public void UnSubscribe()
        {
            next.onClick.RemoveAllListeners();
            prev.onClick.RemoveAllListeners();
        }
    }
}