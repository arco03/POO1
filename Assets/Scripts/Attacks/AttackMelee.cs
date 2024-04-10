using UnityEngine;

namespace Attacks
{
    public class AttackMelee : IAttack
    {
        public void Attack()
        {
            Collider2D[] results = new Collider2D[3];
            // Physics2D.OverlapBoxNonAlloc(_attackPoint.position, _attackRange, results);
        
            foreach(Collider2D coll in results)
            {
                if (!coll) continue;
                
            }
        }
    }
}