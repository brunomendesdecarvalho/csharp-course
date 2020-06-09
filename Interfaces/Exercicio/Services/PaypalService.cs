using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio.Services
{
    class PaypalService : IOnlinePaymentService
    {
        public double Interest(double amount, int month)
        {
            return amount + (0.01 * amount * month);
        }

        public double PaymentFee(double amount)
        {
            return amount + (0.02 * amount);
        }
    }
}
