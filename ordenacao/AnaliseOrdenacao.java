package ordenacao;
	
	/*
	 * Objetivo: Fazer  compara��es  sobre  o  tempo  gasto  para  a 
classifica��o de vetores utilizando os quatro m�todos estudos em sala de aula:
		* Bubble sort, 
		* Selection sort, 
		* Insertion sort, 
		* Quick sort.
	 * Dever� ser feita a ordena��o de vetores de inteiros rad�micos com diferentes 
tamanhos: 
		* 10.000, 
		* 50.000, 
		* 100.000, 
		* 500.000, 
		* 1.000.000 de posi��es.

	 */

import java.util.Scanner;


public class AnaliseOrdenacao {
	
	public static void main(String[] args) {
		

 

    
		

		
		

		Scanner scanner = new Scanner(System.in);
		System.out.println("Qual tamanho deve ter o vetor?");
		System.out.println("[1] = 10.000");
		System.out.println("[2] = 50.000");
		System.out.println("[3] = 100.000");
		System.out.println("[4] = 500.000");
		System.out.println("[5] = 1.000.000");

		String nome = scanner.next();
		System.out.println("Seja bem vindo " + nome + "!");

		RandomList aNomear = new RandomList();

		
		switch (nome) {
			case "1":
				aNomear.settam(10);
				break;
		 
			case "2":
			aNomear.settam(50);
				break;
		 
			case "3":
			aNomear.settam(100);
				break;
			case "4":
			aNomear.settam(500);
				break;
			case "5":
			aNomear.settam(1000);
				break;
		   default:
					System.out.println ("O valor da variavel não é nenhum dos anteriores");
		 
		 
		 }
		
		// TODO Auto-generated method stub
		
		// RandomList other = new OtherClass(); // Abort
		
		
		
		System.out.println(aNomear.saudacao);
		System.out.println("Randon: "+  aNomear.pregenerate + ", "+ (int) aNomear.generate);
		
		// aNomear.settam(10);
		System.out.println(aNomear.unique.length);
	}

}
