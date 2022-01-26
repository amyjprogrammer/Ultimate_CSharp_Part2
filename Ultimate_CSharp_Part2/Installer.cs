using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_CSharp_Part2
{
    public class Installer
    {
        private readonly Composition composition;

        public Installer(Composition composition)
        {
            this.composition = composition;
        }

        public void Install()
        {
            composition.Log("We are installing the app.");
        }
    }
}
