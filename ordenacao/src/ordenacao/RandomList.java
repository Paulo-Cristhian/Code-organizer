package ordenacao;

public class RandomList extends algoritmoOrdenacao{
	//String saudacao = "Saudações!";
	double pregenerate = Math.random();
	double generate = ((double) pregenerate *10);
	//int[] myNum = {10, 20, 30, 40};
	
	int tam; // [10 || 50 || 100 || 500 || 1000] * 1000
	public int[] vetorUnico;
	public void settam(int param) { 
		this.tam = param;
		this.vetorUnico = geraArray(param*1000);
		//System.out.println("Vetor Setado e inicializado a primeira vez ");
		//mostraVetor(vetorUnico);
		/*for(int i = 0; i < vetorUnico.length; i++) {
			System.out.print(vetorUnico[i]+", ");
		}*/

		ordena(vetorUnico);
	}
	// Atribui variável de vetor unica para todas as comparações seguintes
	
	public int[] geraArray(int tam) {
		
		int arr[] = new int[tam];
		for (int i = 0; i<tam; i++ ) {
			int generate = (int)((Math.random()*tam));
			//int generate = tam -i;
			/*
			if(i == 0 || i == 1 || i == tam-1 || i == tam) {
				System.out.println("arr "+i+" : "+generate);
			}*/
			arr[i] = generate;
		}
		return arr;
	}
	public void reverseArray(int tam) {
			/*int arr[] = new int[tam];
			int arr5[] = new int[tam/2];*/
			int arr1[] = new int[tam/10];
			/*for (int i = 0; i<tam; i++ ) {
				int generate = tam - i;
				arr[i] = generate;
			}
			for (int i = 0; i<tam/2; i++ ) {
				int generate = tam/2 - i;
					arr5[i] = generate;
				}*/
			for (int i = 0; i<tam/100; i++ ) {
				int generate = tam/100 - i;
					arr1[i] = generate;
				}
			this.vetorUnico = arr1;
			ordena(arr1);
			//ordena(arr5);
			//ordena(arr);
			
		}
	
	public void ordena(int[] vetorUnico) {
		String algoritmo[] = {"BubbleSort", "InsertSort", "SelectSort", "QuickSort"};
		algoritmoOrdenacao sort = new algoritmoOrdenacao();
		for(int etapa=0; etapa<algoritmo.length; etapa++) {
			long tempoInicial = System.currentTimeMillis();
			
			int[] vetorClone = vetorUnico.clone();
			System.out.println("\nVetor inicializado... ");
			//mostraVetor(vetorClone);
			System.out.println("\nOrdenando em "+algoritmo[etapa]+" ...");
			
			/*
		    sort.bubbleSort(vetorUnico);
		    sort.insertionSort(vetorUnico);
		    sort.selectionSort(vetorUnico);*/
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
		    	//sort.bubbleSort(vetorClone);
		    	sort.quickSort(vetorClone,0,vetorClone.length-1);
		    	break;
		    }
		    // algoritmo[j], unique);

		    long tempoFinal = System.currentTimeMillis();
		    
		    System.out.println("No sistema de ordenação "+ algoritmo[etapa] + " o vetor final foi: ");
		    //mostraVetor(vetorClone);
		    System.out.println("\nExecutado em = " + (tempoFinal - tempoInicial) + " ms\n");
		}
	}	
	public static void mostraVetor(int vetor[]) {
		//System.out.println("Mostrando o Vetor: ");
		for(int i = 0; i < 10; i++) {
			System.out.print(vetor[i]+", ");
		}
	}
}
/* Abort
public class OtherClass {
	String otherString = "OtherString";
}*/