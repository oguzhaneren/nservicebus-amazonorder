using System;
using AmazonOrder.Contracts.Billing;
using NServiceBus;
using AmazonOrder.Contracts.Sales;


namespace AmazonOrder.Shipping
{
    public partial class OrderAcceptedProcessor
    {

        partial void HandleImplementation(OrderAccepted message)
        {
            // TODO: OrderAcceptedProcessor: Add code to handle the OrderAccepted message.
            Console.WriteLine("Shipping received " + message.GetType().Name);
            Data.OrderNumber = message.OrderNumber;
        }

        partial void HandleImplementation(OrderBilled message)
        {
            // TODO: OrderAcceptedProcessor: Add code to handle the OrderAccepted message.
            Console.WriteLine("OrderBilling received " + message.GetType().Name);
            Data.OrderNumber = message.OrderNumber;
            if(message.OrderNumber>100)
                throw new Exception("credit card no limit");
        }

        partial void AllMessagesReceived()
        {
            Console.WriteLine("All done.");
            MarkAsComplete();
        }

        
    }
}
