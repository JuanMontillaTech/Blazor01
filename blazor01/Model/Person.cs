using System;
namespace blazor01.Model
{
	public class Person
	{
		public string Name { get; set; }

		private int Edad { get; set; }

		public string LastName { get; set; }

		 public void SetEdad( int NewEdad)
		{

			this.Edad = NewEdad;

		}
		public int GetEdad() =>this.Edad;
		 
		public string GetNombreCompleto() => this.Name + this.LastName;

	}
}

