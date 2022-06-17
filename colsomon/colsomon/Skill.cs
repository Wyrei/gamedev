using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace colsomon
{
    class Skill
    {
        int Damage = 1;
        int Energycost = 1;
        string name;
        elements element = elements.fire;





        public void UseOn(ConsoleMon target,  ConsoleMon caster)
        {
            caster.TakeDamage(Damage);
            target.DepleteEnergy(Energycost);
        }


        
        
        internal Skill()
        {
            
        }
        
        internal Skill(Skill copyfrom)
        {
            this.Damage = copyfrom.Damage;
            this.Energycost = copyfrom.Energycost;
            

        }
        
    }
}
