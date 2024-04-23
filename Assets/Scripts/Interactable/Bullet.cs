using UnityEngine;

namespace Interactable
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float speed;
        private Rigidbody2D _rigidBody2D;
        //private float _damage = 20f;
        private void Awake()
        {
            _rigidBody2D = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            _rigidBody2D.velocity = Vector2.right * speed;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                Debug.Log("Colisionó");
            }
        }
    }
}