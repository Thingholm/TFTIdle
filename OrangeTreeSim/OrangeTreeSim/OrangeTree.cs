using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeTreeSim
{
    public class OrangeTree
    {

        private int age;
        private int height;
        private bool treeAlive;
        private int numOranges;
        private int orangesEaten;

        public int Age 
        { 
            get 
            { 
                return age;
            } 
            set 
            {  
                age = value; 
            } 
        }
        public int Height
        { 
            get 
            { 
                return height; 
            } 
            set 
            { 
                height = value; 
            } 
        }
        public bool TreeAlive
        { 
            get
            { 
                return treeAlive;
            }
            set 
            { 
                treeAlive = value; 
            }
        }
        public int NumOranges
        {
            get
            {
                return numOranges;
            }
        }
        public int OrangesEaten
        {
            get
            {
                return orangesEaten;
            }
        }
            
        public void OneYearPasses()
        {
            age++;
            if (age < 80)
            {
                height = height + 2;
                numOranges = (age - 1) * 5;
            }
            else
            {
                treeAlive = false;
                numOranges = 0;
            }
            orangesEaten = 0;
        }
        public void EatOrange(int count)
        {
            if (count < numOranges)
            {
                numOranges -= count;
                orangesEaten += count;

            }
        }


    }
}
