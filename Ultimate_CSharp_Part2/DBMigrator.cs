using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_CSharp_Part2
{
    public class DBMigrator
    {
        private readonly Composition composition;

        public DBMigrator(Composition composition)
        {
            this.composition = composition;
        }

        public void Migrate()
        {
            composition.Log("We are migrating...");
        }
    }
}
