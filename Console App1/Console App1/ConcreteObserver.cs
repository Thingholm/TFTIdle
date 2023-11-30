using System;
namespace Console_App1
{
	public class ConcreteObserver : Observer
	{
        private ConcreteSubject subject;
        public int State = 0;

        public ConcreteObserver(ConcreteSubject subject)
        {
            this.subject = subject;
        }

        public override void Update()
        {
            State = subject.State;
        }
    }
}

