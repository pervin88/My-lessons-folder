using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Salamlama
			Console.WriteLine( "Salam xos gelmisiniz");
			Console.Write( "adinizi daxil edin");
			Console.ReadLine();
			#endregion

			#region task1
			var red = "qirmizi";
			var car = "avtomobil";
			var expensive = "bahali";
			var phone = "telefon";

			Console.WriteLine(red + " " + car);
			Console.WriteLine(expensive + " " +phone);
			#endregion

			#region deyisen teyini
			string reng = "sari";
			Console.WriteLine(reng);
			#endregion
			Console.ReadLine();

		}
	}
}
