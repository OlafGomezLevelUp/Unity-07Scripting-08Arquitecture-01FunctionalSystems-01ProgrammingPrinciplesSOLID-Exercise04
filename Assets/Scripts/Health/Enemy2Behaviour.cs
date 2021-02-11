
public class Enemy2Behaviour : HealthBehaviour
{
   protected override void ApplyDamage(float value) => base.ApplyDamage(value / 2);
}
