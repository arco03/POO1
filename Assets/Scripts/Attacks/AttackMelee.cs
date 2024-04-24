using System;
using Playable;
using UnityEngine;

namespace Attacks
{
    
        public class AttackMelee : IAttack
        {
            private Transform _attackController;
            private float _radius;
            private string _tagPlayer; 

           
            public AttackMelee(Transform attackController, float radius, string tagPlayer)
            {
                
                _attackController = attackController;
                _radius = radius;
                _tagPlayer = tagPlayer;
            }

            public void Attack()
            {
                
                Collider2D[] objects = new Collider2D[2];
                int numColliders = Physics2D.OverlapCircleNonAlloc(_attackController.position, _radius, objects);
               
                for (int i = 0; i < numColliders; i++)
                {
                    Collider2D coll = objects[i];
                    if (coll != null)
                    {
                        if (coll.CompareTag(_tagPlayer))
                        {
                            Debug.Log("me pegaste");
                        }
                    }
                }
            }




        }

}

