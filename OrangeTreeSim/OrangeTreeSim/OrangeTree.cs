﻿using System;
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

        public int GetAge() 
        { 
            return age; 
        }
        public void SetAge(int age) 
        { 
            this.age = age; 
        }
        public int GetHeight() 
        { 
            return height; 
        }
        public void SetHeight(int height) 
        { 
            this.height = height; 
        }
        public bool GetTreeAlive() 
        { 
            return treeAlive; 
        }
        public void SetTreeAlive(bool treeAlive) 
        { 
            this.treeAlive = treeAlive; 
        }
        public int GetNumOranges() 
        { 
            return numOranges; 
        }
        public int GetOrangesEaten() 
        { 
            return orangesEaten; 
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
