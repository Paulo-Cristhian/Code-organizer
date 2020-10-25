package ordenacao;

public class RandomList extends algoritmoOrdenacao{
	public static int tam; // [10 || 50 || 100 || 500 || 1000] * 1000
	public int[] vetorUnico;
	public int[] vetorInverso = ;
	public void settam(int param) { 
		this.tam = param;
		this.vetorUnico = geraArray(param*1000);
		ordena(vetorUnico);
	}
	// Atribui vari�vel de vetor unica para todas as compara��es seguintes
	
	public int[] geraArray(int tam) {
		
		int arr[] = new int[tam];
		for (int i = 0; i<tam; i++ ) {
			int generate = (int)((Math.random()*tam));
			arr[i] = generate;
		}
		return arr;
	}
	
	public void ordena(int[] vetorUnico) {
		String algoritmo[] = {"BubbleSort", "InsertSort", "SelectSort", "QuickSort"};
		algoritmoOrdenacao sort = new algoritmoOrdenacao();
		for(int etapa=0; etapa<algoritmo.length; etapa++) {
			long tempoInicial = System.currentTimeMillis();
			
			int[] vetorClone = vetorUnico.clone();
			System.out.println("\nVetor inicializado... ");
			mostraVetor(vetorClone);
			System.out.println("\nOrdenando em "+algoritmo[etapa]+" ...");
		    switch (etapa) {
		    case 0:
		    	sort.bubbleSort(vetorClone);
		    	break;
		    case 1:
		    	sort.insertionSort(vetorClone);
		    	break;
		    case 2:
		    	sort.selectionSort(vetorClone);
		    	break;
		    case 3:
		    	sort.quickSort(vetorClone,0,vetorClone.length-1);
		    	break;
		    }

		    long tempoFinal = System.currentTimeMillis();
		    
		    System.out.println("No sistema de ordena��o "+ algoritmo[etapa] + " o vetor final foi: ");
			mostraVetor(vetorClone);
			vetorClone = new int[0];
			System.out.println("\nExecutado em = " + (tempoFinal - tempoInicial) + " ms");
			
		}
	}	
	public static void mostraVetor(int vetor[]) {
		System.out.println("Mostrando o Vetor: ");
		for(int i = 0; i < 10; i++) {
			System.out.print(vetor[i]+", ");
		}
	}
}