using System;

namespace AccessModifiersDemo
{
    internal class InternalTransaction
    {
        internal void ProcessTransaction()
        {
            Console.WriteLine("Transaktion wird verarbeitet.");
        }
    }
}
