using System;
namespace Console_App1
{
	public class ConcreteSubject : Subject
	{
        private int state = 0;
        public int State
        {
            get { return state; }
            set
            {
                state = value;
                Notify();
            }
        }
    }
}

