using UnityEngine;

namespace GameFramework.Health
{
    public struct DamageContext
    {
        public readonly float Damage;
        public readonly Object From;
        
        public DamageContext(float damage, Object from)
        {
            Damage = damage;
            From = from;
        }
    }
}