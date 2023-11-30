using System;
namespace Console_App1
{
	public class Academy : Subject
	{
		private string name = "";
		public string Name { get { return name; }  }

		private string message = "";
		public string Message { get { return message; } set { message = value; Notify(); } }

		public Academy(string name)
		{
			this.name = name;
		}


	}
}

