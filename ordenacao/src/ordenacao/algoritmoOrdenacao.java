package ordenacao;

public class algoritmoOrdenacao {
		// Passa como parâmetro o vetor a ser ordenado
		public void bubbleSort(int[] vetor){
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
		
		static void insertionSort(int[] vetor) {
		    int j;
		    int key;
		    int i;

		    for (j = 1; j < vetor.length; j++)
		    {
		      key = vetor[j];
		      for (i = j - 1; (i >= 0) && (vetor[i] > key); i--)
		      {
		         vetor[i + 1] = vetor[i];
		       }
		        vetor[i + 1] = key;
		    }
		}
		
		public static void selectionSort(int[] array) {
			  for (int fixo = 0; fixo < array.length - 1; fixo++) {
			    int menor = fixo;

			    for (int i = menor + 1; i < array.length; i++) {
			       if (array[i] < array[menor]) {
			          menor = i;
			       }
			    }
			    if (menor != fixo) {
			      int t = array[fixo];
			      array[fixo] = array[menor];
			      array[menor] = t;
			    }
			  }
		}
		
		static void quickSort(int[] vetor, int inicio, int fim) {
            if (inicio < fim) {
                   int posicaoPivo = separar(vetor, inicio, fim);
                   // System.out.println("Qck "+ inicio+" : "+fim+" : "+posicaoPivo);
                   quickSort(vetor, inicio, posicaoPivo - 1);
                   quickSort(vetor, posicaoPivo + 1, fim);
            }
		}
		private static int separar(int[] vetor, int inicio, int fim) {
            int pivo = vetor[inicio];
            int i = inicio + 1, f = fim;
            while (i <= f) {
            	//System.out.println(vetor[i]);
                   if (vetor[i] <= pivo)
                          i++;
                   else if (pivo < vetor[f])
                          f--;
                   else {
                          int troca = vetor[i];
                          vetor[i] = vetor[f];
                          vetor[f] = troca;
                          i++;
                          f--;
                   }
            }
            vetor[inicio] = vetor[f];
            vetor[f] = pivo;
            return f;
      }
}
