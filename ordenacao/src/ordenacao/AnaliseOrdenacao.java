package ordenacao;

import java.io.IOException;
import java.util.Scanner;

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
		RandomList initRandom = new RandomList();
		switch (opcao) {
		case "1":
			initRandom.settam(10);
			break;
		case "2":
			initRandom.settam(50);
			break;
	 
		case "3":
			initRandom.settam(100);
			break;
		case "4":
			initRandom.settam(500);
			break;
		case "5":
			initRandom.settam(1000);
			break;
	   default:
			System.out.println ("O valor da variavel não é nenhum dos anteriores");
	 }
	}

}
// Pontos que podem ser incrementados: Adicionar mais coment�rios explicativos
// Limpar c�digos inutilizados
// reduzir instancias desnecessarias e vars redundantes
// tornar numeros gerados unicos e diferentes de 0
// possibilitar teste com hyperthreads
// setar um vetor default pra compara��o entre m�quinas
// nomear melhor cada var
