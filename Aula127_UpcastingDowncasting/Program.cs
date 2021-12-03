/* UPCASTING e o Casting da Subclasse para a Superclasse, usado em Polimorfismo.
 * 
 * DOWNCASTING e o Casting da Superclasse para a Subclasse:
    - Palavra "as";
    - Palavra "is";
    - Usado comumente em metodos que recebem parametros genericos (ex.: Equals) 
*/

/* >>> PROGRAMA PRINCIPAL <<< */
using System;
using Aula127_UpcastingDowncasting.Entities;
namespace Aula127_UpcastingDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Vinicius Coelho", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Juliane Midori", 0.0, 500.0);

            // UPCASTING - Conversao da Subclasse para Superclasse
            Account acc1 = bacc; // Variavel tipo Account recebe, naturalmente, um objeto de qualquer tipo de Subclasse dela
            Account acc2 = new BusinessAccount(1003, "Maria Aparecida", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Mochi Nori", 0.0, 0.01);

            // DOWNCASTING - Conversao da Superclasse para a Subclasse
            // BusinessAccount acc4 = (BusinessAccount)acc2; // (BusinessAccount) faz o Downcasting
            BusinessAccount acc4 = acc2 as BusinessAccount; // Uso do operador AS
            acc4.Loan(100.0);

            // BusinessAccount acc5 = (BusinessAccount)acc3; ERRO - acc3 e tipo SavingsAccount

            // PALAVRAS IS / AS
            if (acc3 is BusinessAccount) // Se acc3 for tipo BusinessAccount
            {
                // BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount; // Uso do operador AS
                acc5.Loan(200.0);
                Console.WriteLine("Loan");
            }
            if (acc3 is SavingsAccount)
            {
                // SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update");
            }
        }
    }
}
