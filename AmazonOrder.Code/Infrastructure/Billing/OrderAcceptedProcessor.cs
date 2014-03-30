﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by ServiceMatrix.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using NServiceBus;
using AmazonOrder.Contracts.Sales;


namespace AmazonOrder.Billing
{
    public partial class OrderAcceptedProcessor : IOrderAcceptedProcessor, ServiceMatrix.Shared.INServiceBusComponent, IHandleMessages<OrderAccepted>
    {
		
		public void Handle(OrderAccepted message)
		{
			// Handle message on partial class
			this.HandleImplementation(message);

			// Auto-publish Event OrderBilled
			var OrderBilled = new AmazonOrder.Contracts.Billing.OrderBilled();
			ConfigureOrderBilled(message, OrderBilled);
			this.Bus.Publish(OrderBilled);
		}

		partial void HandleImplementation(OrderAccepted message);

		partial void ConfigureOrderBilled(OrderAccepted incomingMessage, AmazonOrder.Contracts.Billing.OrderBilled message);

        public IBus Bus { get; set; }

    }
    
    public partial interface IOrderAcceptedProcessor
    {
		
    }
}
