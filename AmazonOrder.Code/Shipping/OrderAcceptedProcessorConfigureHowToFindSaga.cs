using System;
using NServiceBus;
using AmazonOrder.Contracts.Sales;
using AmazonOrder.Contracts.Billing;
using NServiceBus.Saga;


namespace AmazonOrder.Shipping
{
    public partial class OrderAcceptedProcessor
    {
        public override void ConfigureHowToFindSaga()
        {
            ConfigureMapping<OrderAccepted>(m => m.OrderNumber).ToSaga(s =>  s.OrderNumber );
            ConfigureMapping<OrderBilled>(m => m.OrderNumber).ToSaga(s => s.OrderNumber);

            
            // If you add new messages to be handled by your saga, you will need to manually add a call to ConfigureMapping for them.
        }
    }
}
