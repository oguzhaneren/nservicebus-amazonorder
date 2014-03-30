using System;
using NServiceBus;
using AmazonOrder.Contracts.Sales;
using AmazonOrder.Contracts.Billing;
using NServiceBus.Saga;


namespace AmazonOrder.Shipping
{
    public partial class OrderAcceptedProcessorSagaData
    {
        [Unique]
        public int OrderNumber { get; set; }


    }
}
