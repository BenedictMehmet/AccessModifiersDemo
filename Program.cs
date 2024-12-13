using System;

namespace AccessModifiersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // PrivateAccount nutzen
            var privateAccount = new PrivateAccount(100);
            Console.WriteLine($"Kontostand: {privateAccount.GetBalance()} EUR");
            privateAccount.AddBalance(50);
            Console.WriteLine($"Neuer Kontostand: {privateAccount.GetBalance()} EUR");

            // PublicUser nutzen
            var publicUser = new PublicUser("Anna Müller");
            publicUser.DisplayUserInfo();

            // InternalTransaction nutzen
            var transaction = new InternalTransaction();
            transaction.ProcessTransaction();

            // DerivedClass nutzen
            var derived = new DerivedClass();
            derived.UseProtectedMethod();
        }
    }
}
