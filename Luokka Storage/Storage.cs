using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luokka_Storage
{
    class Storage : Place, IStorage
    {
        private string name;
        private int capasity;
        private int newItemAmount;
        List<int> varasto;

        public Storage(string nameValue, int capacityValue) : base(nameValue)
        {
            this.name = nameValue;
            this.capasity = capacityValue;
            this.varasto = new List<int>();
        }
        public string AddItems(int amount)
        {
            if (amount < 0)
            {
                return @"Varaston " + this.name + "tilaa ei muutettu";
            }
            else if (amount + varasto.Count > this.capasity)
            {
                if(this.varasto.Count==0)
                { 
                    for (int i = 0; i < this.capasity; i++)
                    {
                        this.varasto.Add(1);
                    }
                }
                int lisättyMäärä;

                lisättyMäärä = varasto.Count - this.capasity;

                for(int i = 0; i < amount; i++ )
                {
                    this.varasto.Add(1);
                }

                return $"Varastoon " + this.name + " lisättiin " + lisättyMäärä + " kpl tavaroita\n\nVaraston " + this.name + " varasto on täynnä\n\nVaraston kapasiteetti on: " + this.capasity;

            }
            else

            {
                for (int i = 0; i < amount; i++)
                {
                    this.varasto.Add(1);
                }

                return $"Varastoon " + this.name + " lisättiin " + amount + " kpl tavaroita";
            }

        }

        public void ClearStorage()
        {
            throw new NotImplementedException();
        }

        public int GetFreeSpace()
        {
            throw new NotImplementedException();
        }

        public string RemoveItems(int amount)
        {
            if (amount > 0)
            {
                return "Varaston " + this.name + "ei muutettu";
            }
            else if (this.varasto.Count - amount < 0)
            {
                int vähennettyMäärä;

                vähennettyMäärä = this.varasto.Count;

                varasto.Clear();
                
                return $"Varastoon " + this.name + " lisättiin " + vähennettyMäärä + " kpl tavaroita\n\nVarasto" + this.name + "on täynnä\n\nVaraston kapasiteetti on: " + this.capasity;

            }
            else
            {
                int määrä;
                määrä=this.varasto.Count - amount;

                this.varasto.Clear();

                for (int i = 0; i < amount; i++)
                {
                    this.varasto.Add(1);

                    }

                return $"Varastosta " + this.name+ " poistettiin" + amount+ " kpl tuotteita";
            }

        }

        public override string ToString()
        {
            return $"varasto {this.name}: kapasiteetti:{this.capasity}, tavaraa: {this.varasto.Count}";
        }
    }
}
