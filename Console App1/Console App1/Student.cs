using System;
namespace Console_App1
{
	public class Student : Observer
	{
		private Academy Academy;
		public string Message { get; set; }

		private string name;
		public string Name { get { return name; } }

		public Student(Academy subject, string name)
		{
			this.Academy = subject;
			this.name = name;
		}

        public override void Update()
        {
			Message = Academy.Message;
			Console.WriteLine($"Studernede {Name} modtog nyheden {Message} fra akademiet {Academy.Name}");
        }
    }
}

