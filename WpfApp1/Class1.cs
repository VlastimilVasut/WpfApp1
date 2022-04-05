using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Kostka
    {
        private int hodnota;

        public int Hodnota { get => hodnota; }
        public void Hod()
        {
            Random random = new Random();
            hodnota = random.Next(1, 7);
        }
    public Kostka()
        {
            Hod();
        }
 
    
    }
 

}

