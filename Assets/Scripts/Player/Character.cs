using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private Transform AttackPoint;
    [SerializeField] private float AttackRange;
    [SerializeField] private float AttackDamage;
    //[SerializeField] DynamicVar dynamicVar;
    public void Attack()
    {
        Collider2D[] Objects = Physics2D.OverlapCircleAll(AttackPoint.position, AttackRange);
        //foreach(Collider2D Collider in Objects)
        //{
            //if (Collider.CompareTag("Player"))
            //{
            //   Collider.transform.GetComponent<Character>().Damage(AttackDamage);
            //}
        //}
    }
    public void Damage()
    {

    }
    public void OnDrawGizmos()
    {
        if (AttackPoint == null) return;
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(AttackPoint.position, AttackRange);
    }
}   
