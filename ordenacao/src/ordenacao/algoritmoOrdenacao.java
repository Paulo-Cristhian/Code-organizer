package ordenacao;

public class algoritmoOrdenacao {
		// Passa como par�metro o vetor a ser ordenado
		public void bubbleSort(int[] vetor){
			// Verifica��o se a troca de posi��o dos elementos deve ser realizada
	        boolean troca = true;
			int aux;
			int p = 25;
			int n = (vetor.length/100)*p;
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
					if(vetor[i]>n){
						System.out.println("Progresso em... "+p+"%");
						p += 25;
						n = (vetor.length/100)*p;
					}
	            }
	        }
	}
		
		static void insertionSort(int[] vetor) {
		    int j;
		    int key;
		    int i;
			int p = 25;
			int n = (vetor.length/100)*p;

		    for (j = 1; j < vetor.length; j++)
		    {
		      key = vetor[j];
		      for (i = j - 1; (i >= 0) && (vetor[i] > key); i--)
		      {
		         vetor[i + 1] = vetor[i];
		       }
				vetor[i + 1] = key;
				if(vetor[j]>n){
					System.out.println("Progresso em... "+p+"%");
					p += 25;
					n = (vetor.length/100)*p;
				}
		    }
		}
		
		public static void selectionSort(int[] vetor) {
			  for (int fixo = 0; fixo < vetor.length - 1; fixo++) {
			    int menor = fixo;

			    for (int i = menor + 1; i < vetor.length; i++) {
			       if (vetor[i] < vetor[menor]) {
					  menor = i;
			       }
			    }
			    if (menor != fixo) {
			      int t = vetor[fixo];
			      vetor[fixo] = vetor[menor];
			      vetor[menor] = t;
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
