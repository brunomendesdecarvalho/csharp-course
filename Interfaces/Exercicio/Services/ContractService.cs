using Exercicio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio.Services
{
    class ContractService
    {
        public ContractService()
        {

        }

        PaypalService ps = new PaypalService();
        public void ProcessContract(Contract contract, int months)
        {
            double amount = (contract.TotalValue / months);
            for(int i = 1; i <= 3; i++)
            {
                Installment installment = new Installment(contract.Date.AddMonths(i));
                installment.Amount = ps.PaymentFee(ps.Interest(amount, i));
                contract.installments.Add(installment);
            }

        }
    }
}
