using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmExperiment.Models
{
    public class Person
    {
        private int AgeOfDeath;
        private int YearOfDeath;

        public Person(int AgeOfDeath, int YearOfDeath)
        {
            this.AgeOfDeath = AgeOfDeath;
            this.YearOfDeath = YearOfDeath;
        }

        public bool IsValid()
        {
            // rules:
            // ~ value must be above 0
            // ~ must born after the witch took control
            if (AgeOfDeath > 0 && YearOfDeath > 0)
            {
                return GetBornYear() > 0;
            }
            return false;
        }

        public int GetBornYear()
        {
            return YearOfDeath - AgeOfDeath;
        }
    }
}
