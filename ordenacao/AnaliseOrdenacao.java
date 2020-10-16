package ordenacao;

import java.io.IOException;
import java.util.Scanner;

/*
	 * Objetivo: Fazer  comparações  sobre  o  tempo  gasto  para  a classificação 
	   de vetores utilizando os quatro métodos estudos em sala de aula:
		* Bubble sort, * Selection sort, * Insertion sort, * Quick sort.
	 * Deverá ser feita a ordenação de vetores de inteiros radômicos com diferentes 
	   tamanhos: 
		* 10.000, * 50.000, * 100.000, * 500.000, * 1.000.000 de posições.
*/

public class AnaliseOrdenacao {
	
	public static void main(String[] args) throws IOException {
		Scanner scanner = new Scanner(System.in);
		System.out.println("Qual tamanho deve ter o vetor?");
		System.out.println("[1] = 10.000");
		System.out.println("[2] = 50.000");
		System.out.println("[3] = 100.000");
		System.out.println("[4] = 500.000");
		System.out.println("[5] = 1.000.000");

		String opcao = scanner.next();
		System.out.println("Seja bem vindo! Foi Selecionado " + opcao + "!");
		RandomList aNomear = new RandomList();
		switch (opcao) {
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
			System.out.println ("O valor da variavel nÃ£o Ã© nenhum dos anteriores");
	 }
		//System.out.println("Randon: "+  aNomear.pregenerate + ", "+ (int) aNomear.generate);
		//System.out.println(aNomear.myNum[0]);
		//aNomear.tam = 10;
		//aNomear.settam(10);
		//System.out.println(aNomear.tam);
		//System.out.println(aNomear.vetorUnico[0]);
		System.out.println(aNomear.vetorUnico.length);
		for(int i = 0; i < aNomear.vetorUnico.length/1000; i++) {
			System.out.print(aNomear.vetorUnico[i]+", ");
		}
	}

}
