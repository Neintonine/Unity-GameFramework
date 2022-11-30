using UnityEngine;
using UnityEngine.Events;

namespace GameFramework.Health
{
    [AddComponentMenu("GameFramework/Health/Damage Event Handler")]
    public class DamageEventHandler : MonoBehaviour, IDamageReciever
    {
        [SerializeField] private UnityEvent<DamageContext> _damaged;
        
        public void Damage(DamageContext context)
        {
            _damaged.Invoke(context);
        }
    }
}