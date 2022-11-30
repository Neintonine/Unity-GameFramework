using System;
using UnityEngine;

namespace GameFramework.Health
{
    [AddComponentMenu("GameFramework/Health/Health")]
    public class Health : MonoBehaviour, IDamageReciever
    {
        public float CurrentHealth => _currentHealth;
        [field: SerializeField] public float MaxHealth { get; private set; }
        
        private float _currentHealth;

        private void Start()
        {
            _currentHealth = MaxHealth;
        }

        public void Damage(DamageContext context)
        {
            _currentHealth -= context.Damage;
        }
    }
}