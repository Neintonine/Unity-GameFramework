namespace GameFramework.Health
{
    public interface IDamageReciever
    {
        void Damage(DamageContext context);
    }
}