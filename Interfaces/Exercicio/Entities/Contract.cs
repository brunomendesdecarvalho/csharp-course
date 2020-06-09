using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        public List<Installment> installments = new List<Installment>();

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

        public override string ToString()
        {
            string s = "Installments:";
            foreach (Installment i in installments)
            {
                s += "\n"
                    + i.DueDate.ToString("dd/MM/yyyy")
                    + " - "
                    + i.Amount.ToString("F2", CultureInfo.InvariantCulture);
            }

            return s;
        }

    }
}
