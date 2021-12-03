/* >>> CLASSE ACCOUNT <<< */
namespace Aula127_UpcastingDowncasting.Entities
{
    class Account
    {
        public int Number { get; private set; } // Private nao permite alteracao da variavel, somente acesso
        public string Holder { get; private set; }
        public double Balance { get; protected set; } // Protected permite alteracao dentro da Classe e suas Subclasses

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
