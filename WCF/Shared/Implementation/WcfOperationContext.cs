﻿using Microsoft.ApplicationInsights.DataContracts;
using System;
using System.ServiceModel;

namespace Microsoft.ApplicationInsights.Wcf.Implementation
{
    internal class WcfOperationContext : IOperationContext, IExtension<OperationContext>
    {
        private OperationContext context;

        public String OperationId
        {
            get { return Request.Id; }
        }
        public String OperationName { get; private set; }
        public RequestTelemetry Request { get; private set; }

        public String ContractName
        {
            get { return context.EndpointDispatcher.ContractName; }
        }
        public String ContractNamespace
        {
            get { return context.EndpointDispatcher.ContractNamespace; }
        }

        public Uri EndpointUri
        {
            get { return context.EndpointDispatcher.EndpointAddress.Uri; }
        }
        public ServiceSecurityContext SecurityContext
        {
            get { return context.ServiceSecurityContext; }
        }

        public static IOperationContext Current
        {
            get { return GetContext();  }
        }

        private WcfOperationContext(OperationContext operationContext)
        {
            context = operationContext;
            OperationName = DiscoverOperationName(operationContext);
            Request = new RequestTelemetry();
            Request.GenerateOperationId();
        }

        public bool HasIncomingMessageProperty(string propertyName)
        {
            return context.IncomingMessageProperties.ContainsKey(propertyName);
        }

        public object GetIncomingMessageProperty(string propertyName)
        {
            return context.IncomingMessageProperties[propertyName];
        }

        public bool HasOutgoingMessageProperty(String propertyName)
        {
            return context.OutgoingMessageProperties.ContainsKey(propertyName);
        }

        public object GetOutgoingMessageProperty(String propertyName)
        {
            return context.OutgoingMessageProperties[propertyName];
        }

        public T GetIncomingMessageHeader<T>(String name, String ns)
        {
            int index = context.IncomingMessageHeaders.FindHeader(name, ns);
            if ( index >= 0 )
            {
                return context.IncomingMessageHeaders.GetHeader<T>(index);
            }
            return default(T);
        }

        private static IOperationContext GetContext()
        {
            var owner = OperationContext.Current;
            if ( owner == null )
                return null;

            WcfOperationContext context = owner.Extensions.Find<WcfOperationContext>();
            if ( context == null )
            {
                context = new WcfOperationContext(owner);
                owner.Extensions.Add(context);
            }
            return context;
        }

        void IExtension<OperationContext>.Attach(OperationContext owner)
        {
        }

        void IExtension<OperationContext>.Detach(OperationContext owner)
        {
        }

        private String DiscoverOperationName(OperationContext operationContext)
        {
            String action = operationContext.IncomingMessageHeaders.Action;
            foreach ( var op in operationContext.EndpointDispatcher.DispatchRuntime.Operations )
            {
                if ( op.Action == action )
                    return op.Name;
            }
            return "*";
        }

    }
}