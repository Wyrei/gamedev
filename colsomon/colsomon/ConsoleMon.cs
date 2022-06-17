﻿using System.Collections.Generic;

namespace colsomon
{
    class ConsoleMon
    {

        List<Skill> skills = new List<Skill>();
        string name;
        int health = 7;
        int Energy = 10;
        elements weakness = elements.fire;
        
        
        public void TakeDamage(int damage)
        {
            health -= damage;
        }
        public void DepleteEnergy(int Energycost)
        {
            Energy -= Energycost;
            
        }
        internal ConsoleMon()
        {

        }

        internal ConsoleMon(ConsoleMon copyfrom)
        {
            this.health = copyfrom.health;
            this.Energy = copyfrom.Energy;

        }
    }
    


}
