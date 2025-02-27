using System;

class Program
{
    static void Main()
    {
        // Pedir ao usuário para digitar o número a ser adivinhado
        Console.Write("Digite um número entre 1 e 100: ");
        int numeroAleatorio = int.Parse(Console.ReadLine());

        int palpite = 0;

        // Enquanto o usuário não adivinhar o número
        while (palpite != numeroAleatorio)
        {
            // Pedir ao usuário para digitar um palpite
            Console.Write("Tente adivinhar o número (entre 1 e 100): ");
            palpite = int.Parse(Console.ReadLine());

            // Dar dicas
            if (palpite < numeroAleatorio)
            {
                Console.WriteLine("O número é maior!");
            }
            else if (palpite > numeroAleatorio)
            {
                Console.WriteLine("O número é menor!");
            }
            else
            {
                Console.WriteLine("Parabéns! Você acertou o número!");
            }
        }
    }
}