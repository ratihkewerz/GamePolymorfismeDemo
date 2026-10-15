using System;

namespace GamePolymorfismeDemo
{
    public class Knight : Hero
    {
        public int bonusArmor;

        public override void UseSkill()
        {
            base.UseSkill();
            Console.WriteLine("BASE DAMAGE = " + bonusArmor);
        }
    }
}