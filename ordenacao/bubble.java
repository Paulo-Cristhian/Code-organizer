package ordenacao;

public class bubble {
	// Passa como parâmetro o vetor a ser ordenado
		static void bubbleSort(int vetor[]){
			// Verificação se a troca de posição dos elementos deve ser realizada
	        boolean troca = true;
	        int aux;
	        // Enquanto houver troca a ser realizada, o algoritmo irá seguir
	        while (troca) {
	        	// Reseta a variável para o preset padrão
	            troca = false;
	            for (int i = 0; i < vetor.length - 1; i++) {
	            	// Se o vetor na posição atual for maior que o elemento do vetor na posição
	                if (vetor[i] > vetor[i + 1]) {
	                    aux = vetor[i];
	                    vetor[i] = vetor[i + 1];
	                    vetor[i + 1] = aux;
	                    troca = true;
	                }
	            }
	        }/*
	        System.out.println("final da ordenação!");
	        for(int i = 0; i < vetor.length; i++) {
				System.out.print(vetor[i]+", ");
			}*/
	}

}
