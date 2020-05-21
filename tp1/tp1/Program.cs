/*
 * Created by SharpDevelop.
 * User: maxim
 * Date: 11/5/2020
 * Time: 18:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;


namespace tp1
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArbolGeneral<int> arbol1 = new ArbolGeneral<int>(1);
			ArbolGeneral<int> arbol2 = new ArbolGeneral<int>(2);
			ArbolGeneral<int> arbol3 = new ArbolGeneral<int>(3);
			ArbolGeneral<int> arbol4 = new ArbolGeneral<int>(4);
			ArbolGeneral<int> arbol5 = new ArbolGeneral<int>(5);
			ArbolGeneral<int> arbol6 = new ArbolGeneral<int>(6);
			ArbolGeneral<int> arbol7 = new ArbolGeneral<int>(7);
			ArbolGeneral<int> arbol8 = new ArbolGeneral<int>(8);
			ArbolGeneral<int> arbol9 = new ArbolGeneral<int>(9);
			ArbolGeneral<int> arbol10 = new ArbolGeneral<int>(10);
			ArbolGeneral<int> arbol11 = new ArbolGeneral<int>(11);
	
			arbol1.agregarHijo(arbol2);
			arbol1.agregarHijo(arbol3);
			arbol1.agregarHijo(arbol4);
			arbol2.agregarHijo(arbol5);
			arbol2.agregarHijo(arbol6);
			arbol5.agregarHijo(arbol7);
			arbol5.agregarHijo(arbol8);
			arbol4.agregarHijo(arbol9);
			arbol9.agregarHijo(arbol10);
			arbol10.agregarHijo(arbol11);
			
			Console.WriteLine("La altura del arbol es: ");
			Console.WriteLine(arbol1.altura());
			
			Console.WriteLine("\nPREORDEN");
			arbol1.preorden();
			
			Console.WriteLine("\nPOSTORDEN");
			arbol1.postorden();
			
			Console.WriteLine("\nPOR NIVELES");
			arbol1.porniveles();
			
			Console.WriteLine("\nENTRENIVELES: ");
			arbol1.niveles(0,4);
			
			Console.WriteLine("\nNIVEL: ");
			Console.WriteLine(arbol1.nivel(12));
		
			Console.WriteLine("\nANCHO: ");
			Console.WriteLine(arbol1.ancho());
				
			Console.Write("\nPresione una tecla para concluir la ejecucion . . . ");
			Console.ReadKey(true);
		}
	}
}