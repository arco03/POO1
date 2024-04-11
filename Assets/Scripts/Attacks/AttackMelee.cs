using Playable;
using UnityEngine;

namespace Attacks
{
    public class AttackMelee : IAttack
    {
        [SerializeField] private Transform _attackPointA;
        [SerializeField] private Transform _attackPointB;

        public void Attack()
        {
            Collider2D[] results = new Collider2D[2];
            Physics2D.OverlapAreaNonAlloc(_attackPointA.position, _attackPointB.position, results);

            foreach (Collider2D coll in results)
            {
                if (!coll) continue;
                if (coll.CompareTag("Player"))
                {
                    coll.transform.GetComponent<Character>().Damage(20);
                }


            }
        }
    }
}

