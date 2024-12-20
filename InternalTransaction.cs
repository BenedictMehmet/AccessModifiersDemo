using System;

namespace AccessModifiersDemo
{
    internal class InternalTransaction
    {
        public void ProcessTransaction()
        {
            Console.WriteLine("Transaktion wird verarbeitet.");
        }
    }
}
