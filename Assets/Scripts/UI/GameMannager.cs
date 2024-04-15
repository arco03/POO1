using System.Collections.Generic;
using Characters;
using UnityEngine;

namespace UI
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;
        public List<Character> characters;

        private void Awake()
        {
            if (GameManager.Instance == null)
            {
                GameManager.Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}