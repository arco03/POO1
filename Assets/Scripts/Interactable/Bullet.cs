using System;
using UnityEngine;

namespace Interactable
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Bullet : MonoBehaviour
    {
        private Rigidbody2D _rigidBody2D;

        private void Awake()
        {
            _rigidBody2D = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            _rigidBody2D.velocity = Vector2.right;
        }
    }
}