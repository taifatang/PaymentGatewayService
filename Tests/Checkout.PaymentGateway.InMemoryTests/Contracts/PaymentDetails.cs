﻿namespace Checkout.PaymentGateway.InMemoryTests.Contracts
{
    public class PaymentDetails
    {
        public string CardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string SecurityCode { get; set; }
    }
}