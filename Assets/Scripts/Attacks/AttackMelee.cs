using System;
using UnityEngine;

namespace Attacks
{
    public class AttackMelee : IAttack
    {
        private Transform _attackPointA, _attackPointB;
        
        public void Attack()
        {
            Collider2D[] results = new Collider2D[2];
            Physics2D.OverlapAreaNonAlloc(_attackPointA.position, _attackPointB.position,results);

            foreach (Collider2D coll in results)
            {
                if (!coll) continue;
                if (coll.CompareTag("Player"))
                {
                    Debug.Log("Ataque Melee gg");
                }


            }
        }
    }
}

