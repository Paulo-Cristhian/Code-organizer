package ordenacao;

public class RandomList {
	String saudacao = "Saudações!";
	double pregenerate = Math.random();
	double generate = ((double) pregenerate *10);
	//int[] myNum = {10, 20, 30, 40};
	
	//int tam; // [10 || 50 || 100 || 500 || 1000] * 1000
	public static int[] vetorUnico;
	public void settam(int param) { 
		//this.tam = param;
		this.vetorUnico = geraArray(param*1000);
		//System.out.println("Setado");
		ordena(vetorUnico);
	}
	// Atribui variável de vetor unica para todas as comparações seguintes
	
	public static int[] geraArray(int tam) {
		
		int arr[] = new int[tam];
		for (int i = 0; i<tam; i++ ) {
			int generate = (int)((Math.random()*tam));
			arr[i] = generate;
		}
		return arr;
	}
	public static void ordena(int[] vetorUnico) {
		//String algoritmo[] = {"bubbleSort", "insertSort"};
		//for(int j=0; j<algoritmo.length; j++) {
		long tempoInicial = System.currentTimeMillis();
		
		bubble objSort1 = new bubble();
	    objSort1.bubbleSort(vetorUnico);
	    // algoritmo[j], unique);

	    long tempoFinal = System.currentTimeMillis();

	    System.out.println("Executado em = " + (tempoFinal - tempoInicial) + " ms");
		}
	//}	
	

}
/* Abort
public class OtherClass {
	String otherString = "OtherString";
}*/