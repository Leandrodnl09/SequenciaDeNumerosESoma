// Exercício de site URI "Sequência de Numeros e Soma"
// Leia um conjunto não determinado de pares de valores M e N (parar quando algum dos valores for menor ou igual a zero). Para cada par lido,
// mostre a sequência do menor até o maior e a soma dos inteiros consecutivos entre eles (incluindo o N e M).
// O arquivo de entrada contém um número não determinado de valores M e N. A última linha de entrada vai conter um número nulo ou negativo.
// Para cada dupla de valores, imprima a sequência do menor até o maior e a soma deles, conforme exemplo abaixo.


string[] Num = Console.ReadLine().Split(' ');
int N = int.Parse(Num[0]);
int M = int.Parse(Num[1]);

while (N > 0 && M > 0)
{
    if (N > M)
    {
        int Troca = N;
        N = M;
        M = Troca;
    }
    int Sum = 0;
    for (int i = N; i <= M; i++)
    {
        Console.Write(i + " ");
        Sum = Sum + i;
    }
    Console.WriteLine("Sum=" + Sum);
    Num = Console.ReadLine().Split(' ');
    N = int.Parse(Num[0]);
    M = int.Parse(Num[1]);
}
