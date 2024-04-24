using System;
using Configurations;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

namespace Instantiate
{
    public class GameInstaller : MonoBehaviour
    {
        [SerializeField] private PlayerConfiguration configuration;
        [SerializeField] private Transform positionPlayer1;
        [SerializeField] private Transform positionPlayer2;
        private void Start()
        {
            if (CompareTag("Player") == false)
            {
                Instantiate(configuration.playerSelections[1].characterPrefab,positionPlayer1.position,quaternion.identity);
                if (CompareTag("Player2")== false)
                {
                    Instantiate(configuration.playerSelections[2].characterPrefab,positionPlayer2.position, Quaternion.Euler(0, 180, 0));
                }
            }
             
            
        }
    }
}