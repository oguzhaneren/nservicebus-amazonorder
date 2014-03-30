using System;
using AmazonOrder.Contracts.Billing;
using NServiceBus;
using AmazonOrder.Contracts.Sales;


namespace AmazonOrder.Billing
{
    public partial class OrderAcceptedProcessor
    {
		
        partial void HandleImplementation(OrderAccepted message)
        {
            // TODO: OrderAcceptedProcessor: Add code to handle the OrderAccepted message.
            Console.WriteLine("Billing received " + message.GetType().Name);
        }

        partial void ConfigureOrderBilled(OrderAccepted incomingMessage, OrderBilled message)
        {
            message.OrderNumber = incomingMessage.OrderNumber;
        }
    }
}
