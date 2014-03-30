using System;
using NServiceBus;
using AmazonOrder.InternalMessages.Commands.Sales;


namespace AmazonOrder.Sales
{
    public partial class PlaceOrderProcessor
    {
		
        partial void HandleImplementation(PlaceOrder message)
        {
            // TODO: PlaceOrderProcessor: Add code to handle the PlaceOrder message.
            Console.WriteLine("Sales received " + message.GetType().Name);
        }

        partial void ConfigureOrderAccepted(PlaceOrder incomingMessage, Contracts.Sales.OrderAccepted message)
        {
            message.OrderNumber = incomingMessage.OrderNumber;
        }
    }
}
