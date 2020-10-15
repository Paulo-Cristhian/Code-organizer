package ordenacao;

public class RandomList {
	String saudacao = "Saudações!";
	double pregenerate = Math.random();
	double generate = ((double) pregenerate *10);
	int[] myNum = {10, 20, 30, 40};
	int tam; // [10 || 50 || 100 || 500 || 1000] * 1000
	int[] unique = geraArray(10);
	public static int[] geraArray(int tam) {
		int arr[] = new int[tam];
		for (int n = 0; n<tam; n++ ) {
			int generate = (int)((double) Math.random() * 100);
			arr[n] = generate;
		}
		return arr;
	}

}
/* Abort
public class OtherClass {
	String otherString = "OtherString";
}*/