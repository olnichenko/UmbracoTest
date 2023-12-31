﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference2
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IWSDLPublish")]
    public interface IWSDLPublish
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.borland.com/namespaces/Types-IWSDLPublish", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        System.Threading.Tasks.Task<ServiceReference2.GetPortTypeListResponse> GetPortTypeListAsync(ServiceReference2.GetPortTypeListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.borland.com/namespaces/Types-IWSDLPublish", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        System.Threading.Tasks.Task<ServiceReference2.GetWSDLForPortTypeResponse> GetWSDLForPortTypeAsync(ServiceReference2.GetWSDLForPortTypeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.borland.com/namespaces/Types-IWSDLPublish", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        System.Threading.Tasks.Task<ServiceReference2.GetTypeSystemsListResponse> GetTypeSystemsListAsync(ServiceReference2.GetTypeSystemsListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.borland.com/namespaces/Types-IWSDLPublish", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        System.Threading.Tasks.Task<ServiceReference2.GetXSDForTypeSystemResponse> GetXSDForTypeSystemAsync(ServiceReference2.GetXSDForTypeSystemRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPortTypeList", WrapperNamespace="http://www.borland.com/namespaces/Types", IsWrapped=true)]
    public partial class GetPortTypeListRequest
    {
        
        public GetPortTypeListRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPortTypeListResponse", WrapperNamespace="http://www.borland.com/namespaces/Types", IsWrapped=true)]
    public partial class GetPortTypeListResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string[] @return;
        
        public GetPortTypeListResponse()
        {
        }
        
        public GetPortTypeListResponse(string[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetWSDLForPortType", WrapperNamespace="http://www.borland.com/namespaces/Types", IsWrapped=true)]
    public partial class GetWSDLForPortTypeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string PortType;
        
        public GetWSDLForPortTypeRequest()
        {
        }
        
        public GetWSDLForPortTypeRequest(string PortType)
        {
            this.PortType = PortType;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetWSDLForPortTypeResponse", WrapperNamespace="http://www.borland.com/namespaces/Types", IsWrapped=true)]
    public partial class GetWSDLForPortTypeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string @return;
        
        public GetWSDLForPortTypeResponse()
        {
        }
        
        public GetWSDLForPortTypeResponse(string @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetTypeSystemsList", WrapperNamespace="http://www.borland.com/namespaces/Types", IsWrapped=true)]
    public partial class GetTypeSystemsListRequest
    {
        
        public GetTypeSystemsListRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetTypeSystemsListResponse", WrapperNamespace="http://www.borland.com/namespaces/Types", IsWrapped=true)]
    public partial class GetTypeSystemsListResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string[] @return;
        
        public GetTypeSystemsListResponse()
        {
        }
        
        public GetTypeSystemsListResponse(string[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetXSDForTypeSystem", WrapperNamespace="http://www.borland.com/namespaces/Types", IsWrapped=true)]
    public partial class GetXSDForTypeSystemRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string TypeSystem;
        
        public GetXSDForTypeSystemRequest()
        {
        }
        
        public GetXSDForTypeSystemRequest(string TypeSystem)
        {
            this.TypeSystem = TypeSystem;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetXSDForTypeSystemResponse", WrapperNamespace="http://www.borland.com/namespaces/Types", IsWrapped=true)]
    public partial class GetXSDForTypeSystemResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string @return;
        
        public GetXSDForTypeSystemResponse()
        {
        }
        
        public GetXSDForTypeSystemResponse(string @return)
        {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IWSDLPublishChannel : ServiceReference2.IWSDLPublish, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class WSDLPublishClient : System.ServiceModel.ClientBase<ServiceReference2.IWSDLPublish>, ServiceReference2.IWSDLPublish
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WSDLPublishClient() : 
                base(WSDLPublishClient.GetDefaultBinding(), WSDLPublishClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.IWSDLPublishPort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WSDLPublishClient(EndpointConfiguration endpointConfiguration) : 
                base(WSDLPublishClient.GetBindingForEndpoint(endpointConfiguration), WSDLPublishClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WSDLPublishClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WSDLPublishClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WSDLPublishClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WSDLPublishClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WSDLPublishClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference2.GetPortTypeListResponse> ServiceReference2.IWSDLPublish.GetPortTypeListAsync(ServiceReference2.GetPortTypeListRequest request)
        {
            return base.Channel.GetPortTypeListAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference2.GetPortTypeListResponse> GetPortTypeListAsync()
        {
            ServiceReference2.GetPortTypeListRequest inValue = new ServiceReference2.GetPortTypeListRequest();
            return ((ServiceReference2.IWSDLPublish)(this)).GetPortTypeListAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference2.GetWSDLForPortTypeResponse> ServiceReference2.IWSDLPublish.GetWSDLForPortTypeAsync(ServiceReference2.GetWSDLForPortTypeRequest request)
        {
            return base.Channel.GetWSDLForPortTypeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference2.GetWSDLForPortTypeResponse> GetWSDLForPortTypeAsync(string PortType)
        {
            ServiceReference2.GetWSDLForPortTypeRequest inValue = new ServiceReference2.GetWSDLForPortTypeRequest();
            inValue.PortType = PortType;
            return ((ServiceReference2.IWSDLPublish)(this)).GetWSDLForPortTypeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference2.GetTypeSystemsListResponse> ServiceReference2.IWSDLPublish.GetTypeSystemsListAsync(ServiceReference2.GetTypeSystemsListRequest request)
        {
            return base.Channel.GetTypeSystemsListAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference2.GetTypeSystemsListResponse> GetTypeSystemsListAsync()
        {
            ServiceReference2.GetTypeSystemsListRequest inValue = new ServiceReference2.GetTypeSystemsListRequest();
            return ((ServiceReference2.IWSDLPublish)(this)).GetTypeSystemsListAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference2.GetXSDForTypeSystemResponse> ServiceReference2.IWSDLPublish.GetXSDForTypeSystemAsync(ServiceReference2.GetXSDForTypeSystemRequest request)
        {
            return base.Channel.GetXSDForTypeSystemAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference2.GetXSDForTypeSystemResponse> GetXSDForTypeSystemAsync(string TypeSystem)
        {
            ServiceReference2.GetXSDForTypeSystemRequest inValue = new ServiceReference2.GetXSDForTypeSystemRequest();
            inValue.TypeSystem = TypeSystem;
            return ((ServiceReference2.IWSDLPublish)(this)).GetXSDForTypeSystemAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.IWSDLPublishPort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.IWSDLPublishPort))
            {
                return new System.ServiceModel.EndpointAddress("http://isapi.icu-tech.com/icutech-test.dll/soap/IWSDLPublish");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return WSDLPublishClient.GetBindingForEndpoint(EndpointConfiguration.IWSDLPublishPort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return WSDLPublishClient.GetEndpointAddress(EndpointConfiguration.IWSDLPublishPort);
        }
        
        public enum EndpointConfiguration
        {
            
            IWSDLPublishPort,
        }
    }
}
