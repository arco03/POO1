using System;
using Playable;
using UnityEngine;

namespace Attacks
{
    public class AttackMelee : IAttack
    {
        //Dependencies
        private Transform _attackController;
        private float _radius;
        private string _tagPlayer;

        //public void SetAttack(Transform attackController, float radius, string tagPlayer)
        //{
        //_attackController = attackController;
        //_radius = radius;
        //_tagPlayer = tagPlayer;
        //}
        public void Attack()
        {
            Collider2D[] objects = new Collider2D[2];
            Physics2D.OverlapCircleNonAlloc(_attackController.position, _radius, objects);
            foreach (var coll in objects)
            {
                if (coll.CompareTag(_tagPlayer))
                {
                    Debug.Log("me pegaste");
                }

               
            }
        }
    }
}

