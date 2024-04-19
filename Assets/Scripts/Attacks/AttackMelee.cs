using System;
using Playable;
using UnityEngine;

namespace Attacks
{
    public class AttackMelee : IAttack
    {
        [SerializeField] private Transform controladorAtaque;
        [SerializeField] private float radio;
        [SerializeField] private string tagPlayer;
        [SerializeField] private KeyCode teclaAtaque;


        private void Update()
        {
            if (Input.GetKeyDown(teclaAtaque))
            {
                Attack();
            }
        }

        public void Attack()
        {
            Collider2D[] objeto = Physics2D.OverlapCircleAll(controladorAtaque.position, radio);
            foreach (var colisionador in objeto)
            {
                if (colisionador.CompareTag(tagPlayer))
                {
                    Debug.Log("me pegaste");
                }
            }
        }

        public void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(controladorAtaque.position,radio);
        }
    }
}

