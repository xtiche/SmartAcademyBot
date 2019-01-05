//------------------------------------------------------------------------------
// <автоматически создаваемое>
//     Этот код создан программой.
//     //
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </автоматически создаваемое>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/NAVBotTest", ConfigurationName="ServiceReference1.NAVBotTest_Port")]
    public interface NAVBotTest_Port
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/NAVBotTest:GetValue", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference1.GetValue_Result> GetValueAsync(ServiceReference1.GetValue request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetValue", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/NAVBotTest", IsWrapped=true)]
    public partial class GetValue
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/NAVBotTest", Order=0)]
        public int get;
        
        public GetValue()
        {
        }
        
        public GetValue(int get)
        {
            this.get = get;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetValue_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/NAVBotTest", IsWrapped=true)]
    public partial class GetValue_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/NAVBotTest", Order=0)]
        public int return_value;
        
        public GetValue_Result()
        {
        }
        
        public GetValue_Result(int return_value)
        {
            this.return_value = return_value;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface NAVBotTest_PortChannel : ServiceReference1.NAVBotTest_Port, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class NAVBotTest_PortClient : System.ServiceModel.ClientBase<ServiceReference1.NAVBotTest_Port>, ServiceReference1.NAVBotTest_Port
    {
        
    /// <summary>
    /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
    /// </summary>
    /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
    /// <param name="clientCredentials">Учетные данные клиента.</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public NAVBotTest_PortClient() : 
                base(NAVBotTest_PortClient.GetDefaultBinding(), NAVBotTest_PortClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.NAVBotTest_Port.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NAVBotTest_PortClient(EndpointConfiguration endpointConfiguration) : 
                base(NAVBotTest_PortClient.GetBindingForEndpoint(endpointConfiguration), NAVBotTest_PortClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NAVBotTest_PortClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(NAVBotTest_PortClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NAVBotTest_PortClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(NAVBotTest_PortClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NAVBotTest_PortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.GetValue_Result> ServiceReference1.NAVBotTest_Port.GetValueAsync(ServiceReference1.GetValue request)
        {
            return base.Channel.GetValueAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.GetValue_Result> GetValueAsync(int get)
        {
            ServiceReference1.GetValue inValue = new ServiceReference1.GetValue();
            inValue.get = get;
            return ((ServiceReference1.NAVBotTest_Port)(this)).GetValueAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NAVBotTest_Port))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NAVBotTest_Port))
            {
                return new System.ServiceModel.EndpointAddress("https://13.94.251.189:7047/NAV05/WS/CRONUS International Ltd./Codeunit/NAVBotTest" +
                        "");
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return NAVBotTest_PortClient.GetBindingForEndpoint(EndpointConfiguration.NAVBotTest_Port);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return NAVBotTest_PortClient.GetEndpointAddress(EndpointConfiguration.NAVBotTest_Port);
        }
        
        public enum EndpointConfiguration
        {
            
            NAVBotTest_Port,
        }
    }
}
