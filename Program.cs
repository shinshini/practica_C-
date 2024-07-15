/*
 * Created by SharpDevelop.
 * User: CONTROL
 * Date: 03/04/2024
 * Time: 08:14 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proyecto_celular
{
	class Program
	{
		public static void Main(string[] args)
		{
			celular micelular =new celular(128,"Samsung", "Galaxy S21", "Negro", 800.7, 1);
			
		micelular.mostrar();
        micelular.leer();
        micelular.encender();
        micelular.mostrar();
        
        			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}