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
public class AnaliseOrdenacao {
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		RandomList aNomear = new RandomList();
		// RandomList other = new OtherClass(); // Abort
		System.out.println(aNomear.saudacao);
		System.out.println("Randon: "+  aNomear.pregenerate + ", "+ (int) aNomear.generate);
		System.out.println(aNomear.myNum[0]);
		aNomear.tam = 10;
		System.out.println(aNomear.unique[0]);
	}

}
