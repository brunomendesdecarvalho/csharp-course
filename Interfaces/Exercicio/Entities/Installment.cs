using System;

namespace Exercicio.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment()
        {
        }

        public Installment(DateTime dueDate)
        {
            DueDate = dueDate;
        }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }
    }
}
