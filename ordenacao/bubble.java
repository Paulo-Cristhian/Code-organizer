package ordenacao;

public class bubble {
	// Passa como par�metro o vetor a ser ordenado
		static void bubbleSort(int vetor[]){
			// Verifica��o se a troca de posi��o dos elementos deve ser realizada
	        boolean troca = true;
	        int aux;
	        // Enquanto houver troca a ser realizada, o algoritmo ir� seguir
	        while (troca) {
	        	// Reseta a vari�vel para o preset padr�o
	            troca = false;
	            for (int i = 0; i < vetor.length - 1; i++) {
	            	// Se o vetor na posi��o atual for maior que o elemento do vetor na posi��o
	                if (vetor[i] > vetor[i + 1]) {
	                    aux = vetor[i];
	                    vetor[i] = vetor[i + 1];
	                    vetor[i + 1] = aux;
	                    troca = true;
	                }
	            }
	        }/*
	        System.out.println("final da ordena��o!");
	        for(int i = 0; i < vetor.length; i++) {
				System.out.print(vetor[i]+", ");
			}*/
	}

}
