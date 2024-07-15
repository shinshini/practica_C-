/*
 * Created by SharpDevelop.
 * User: CONTROL
 * Date: 03/04/2024
 * Time: 08:16 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proyecto_celular
{
	/// <summary>
	/// Description of celular.
	/// </summary>
	public class celular
	{
		public string marca;
		public string modelo;
		public string Color;
		public double precio;
		public int almacenamiento;
		public bool encendido;
		public int x;
		
		public celular(int x,string marca,string modelo,string 
		               Color,double precio,int almacenamiento)
		{
			this.marca=marca;
			this.modelo=modelo;
			this.Color=Color;
			this.precio=precio;
			this.almacenamiento=almacenamiento;
			this.x=x;
			this.encendido=(x==0);
			
		}
		public void leer()
		{
			Console.WriteLine("Leyendo nformacion del celular.... ");
			Console.WriteLine("ingrese marca");
			marca=Console.ReadLine();
			Console.WriteLine("ingrese modelo");
			modelo=Console.ReadLine();
			Console.WriteLine("ingrese color");
			Color=Console.ReadLine();
			Console.WriteLine("ingrese precio");
			precio=Double.Parse(Console.ReadLine());
			Console.WriteLine("ingrese el alamacenamiento");
			almacenamiento=int.Parse(Console.ReadLine());
			
			
		}
		
		public void mostrar(){
			Console.WriteLine("INFORMACION DEL CELULAR");
			Console.WriteLine("Marca: "+marca);
			Console.WriteLine("Modelo: "+modelo);
			Console.WriteLine("color: "+Color);
			Console.WriteLine("precio: "+precio);
			Console.WriteLine("almacenamiento: "+almacenamiento+ "GB");
			Console.WriteLine("encendido: "+ (encendido ? "si" : "no"));
		}
		public void encender()
		{
			Console.WriteLine("ingrese numero");
			x=int.Parse(Console.ReadLine());
			if(x==0){
				encendido = true;
        Console.WriteLine("El celular ha sido encendido.");
			}
			else{
			  encendido = false;
        Console.WriteLine("El celular ha sido apagado.");
			}
		}
	}
}
