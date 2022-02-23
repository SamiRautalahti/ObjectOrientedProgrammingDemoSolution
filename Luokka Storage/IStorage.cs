using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luokka_Storage
{
    interface IStorage {

        // lisää varastoon parametrin ilmoittaman määrän tavaroita
        string AddItems(int amount);
        // palauttaa varastossa olevan vapaan tilan määrän
        int GetFreeSpace();
        // poistaa varastosta parametrin ilmoittaman määrän tavaroita
        string RemoveItems(int amount);
        // tyhjentää varaston
        void ClearStorage();
    }
}
