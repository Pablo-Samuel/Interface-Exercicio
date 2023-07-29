using System;

namespace Exercicio.Services
{
    class PaymentServices : IOnlinePaymentServices
    {
        public double Quota(double amount, int num)
        {
            amount += (amount * 0.01) * num;
            return amount += (amount * 0.02);
        }
    }
}
