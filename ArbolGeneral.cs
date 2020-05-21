using System;
using System.Collections.Generic;

namespace tp1
{
	public class ArbolGeneral<T>
	{
		
		private NodoGeneral<T> raiz;
		public int alt;

		public ArbolGeneral(T dato) {
			this.raiz = new NodoGeneral<T>(dato);
		}
	
		private ArbolGeneral(NodoGeneral<T> nodo) {
			this.raiz = nodo;
		}
	
		private NodoGeneral<T> getRaiz() {
			return raiz;
		}
	
		public T getDatoRaiz() {
			return this.getRaiz().getDato();
		}
	
		public List<ArbolGeneral<T>> getHijos() {
			List<ArbolGeneral<T>> temp= new List<ArbolGeneral<T>>();
			foreach (var element in this.raiz.getHijos()) {
				temp.Add(new ArbolGeneral<T>(element));
			}
			return temp;
		}
	
		public void agregarHijo(ArbolGeneral<T> hijo) {
			this.raiz.getHijos().Add(hijo.getRaiz());
		}
	
		public void eliminarHijo(ArbolGeneral<T> hijo) {
			this.raiz.getHijos().Remove(hijo.getRaiz());
		}
	
		public bool esVacio() {
			return this.raiz == null;
		}
	
		public bool esHoja() {
			return this.raiz != null && this.getHijos().Count == 0;
		}
	
		public int altura() {
			int altMax=0;
			if (this.esHoja()){
                return 0;
            }
            else {
				foreach (var element in this.getHijos())	{
					altMax=Math.Max(altMax, element.altura());
                   	element.altura();
            		}
			}
			return  altMax+1;
		}
	
		
		public void preorden(){
			if (!this.esVacio()){
				Console.Write(this.getDatoRaiz() + " ");
				if (!this.esHoja()){
				foreach (var hijo in this.getHijos()){
					hijo.preorden();
					}
				}
			}
		}
		
		public void postorden(){
			if (!this.esVacio()){
				foreach (var hijo in this.getHijos()){
					hijo.postorden();
				}
				Console.Write(this.getDatoRaiz() + " ");
			}
		}
		
		public void porniveles(){
			Cola<ArbolGeneral<T>> cola=new Cola<ArbolGeneral<T>>();
			ArbolGeneral<T> temp;
			cola.encolar(this);
			if (!this.esVacio()){
				while(!cola.esVacia()){
					temp=cola.desencolar();
					Console.Write(temp.getDatoRaiz() + " ");
					foreach (var hijo in temp.getHijos())
							cola.encolar(hijo);
				}
			}
		}
		
		public void niveles(int a, int b){

			Cola<ArbolGeneral<T>> cola=new Cola<ArbolGeneral<T>>();
			ArbolGeneral<T> temp;
			int contNivel=0;
			cola.encolar(this);
			cola.encolar(null);
	
			while(!cola.esVacia()){
				temp=cola.desencolar();
				if (temp != null){
					if (contNivel >= a && contNivel <= b)
						Console.Write(temp.getDatoRaiz() + " ");
					foreach (var hijo in temp.getHijos()){
						cola.encolar(hijo);
					}
				}
				else{
					contNivel++;
					if (!cola.esVacia())
						cola.encolar(null);
				}
			}
		}
	
		public int nivel(T dato){
			
			Cola<ArbolGeneral<T>> cola=new Cola<ArbolGeneral<T>>();
			ArbolGeneral<T> temp;
			int contNivel=0;
			//string data= dato.ToString();
			cola.encolar(this);
			cola.encolar(null);
	
			while(!cola.esVacia()){
				temp=cola.desencolar();
				
				if (temp != null){
					//string tempDato= temp.getDatoRaiz().ToString();
					if (temp.getDatoRaiz().Equals(dato))
						return contNivel;
					foreach (var hijo in temp.getHijos()){
						cola.encolar(hijo);
					}
				}
				else{
					contNivel++;
					if (!cola.esVacia())
						cola.encolar(null);
				}
			}
			return -1;
		}
		
		public int ancho(){

			Cola<ArbolGeneral<T>> cola=new Cola<ArbolGeneral<T>>();
			ArbolGeneral<T> temp;
			//int contNivel=0;
			int anchoNivel=0;
			int anchura=0;
			cola.encolar(this);
			cola.encolar(null);
	
			while(!cola.esVacia()){
				temp=cola.desencolar();
				if (temp != null){
					anchoNivel++;
					foreach (var hijo in temp.getHijos()){
						cola.encolar(hijo);
					}
				}
				else{
					//contNivel++;
					if (anchoNivel > anchura)
						anchura=anchoNivel;
					anchoNivel=0;
					if (!cola.esVacia())
						cola.encolar(null);
				}
			}
			return anchura;
		}
	
	}

}
