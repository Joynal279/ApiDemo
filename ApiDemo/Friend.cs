using System;
namespace ApiDemo
{
	public class Friend
	{

		public string firstname { get; set; }
		public string lastname { get; set; }
		public string location { get; set; }

		public Friend()
		{
		}

        public Friend(string firstname, string lastname, string location)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.location = location;
        }
    }
}

