﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsurancesDemo
{
    class Insurance
    {
        private String species;
        private String name;
        private bool neutered;
        private double fee;

        public Insurance(String animal, String name, bool isNeutered, double payment)
        {
            this.species = animal;
            this.name = name;
            this.neutered = isNeutered;
            this.fee = payment;
        }

        public String GetNeuteredInfo()
        {
            if (neutered)
            {
                return "leikattu";
            }
            else
            {
                return "leikkaamaton";
            }
        }

        public String GetSpecies()
        {
            return this.species;
        }

        public String GetName()
        {
            return this.name;
        }

        public override String ToString()
        {
            return this.species + ": " + this.name + ", " + this.GetNeuteredInfo();
        }
    }
}
