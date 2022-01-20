using System;
using LuckySpin.Models;
using System.Collections.Generic;

namespace LuckySpin.Services
{
    public class RepoService
    {
        private List<Spin> spins = new List<Spin>();

       //Property
       public IEnumerable<Spin> PlayerSpins {

            get { return spins; }
       }

        //Access method
        public void AddSpin(Spin s)
        {
            spins.Add(s);
        }
    }
}
