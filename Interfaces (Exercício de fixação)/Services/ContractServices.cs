using System;

namespace Exercicio.Services
{
    class ContractRegistry
    {
        public int Installments { get; set; }
        private IOnlinePaymentServices _onlinePaymentServices { get; set; }

        public ContractRegistry(int installments, IOnlinePaymentServices onlinePaymentServices)
        {
            Installments = installments;
            _onlinePaymentServices = onlinePaymentServices;
        }
        
        public double SetIOnlinePayment(double amount, int num)
        {
            return _onlinePaymentServices.Quota(amount, num);
        }
    }
}
