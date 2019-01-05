//------------------------------------------------------------------------------
// <автоматически создаваемое>
//     Этот код создан программой.
//     //
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </автоматически создаваемое>
//------------------------------------------------------------------------------

namespace NAV
{
    using System.Net;
    using System.Runtime.Serialization;
    using System.ServiceModel;

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OutofOfficeRequest", Namespace="urn:microsoft-dynamics-nav/xmlports/x52005")]
    public partial class OutofOfficeRequest : object
    {
        
        private string EmployeeNoField;
        
        private string StartDateField;
        
        private string StartTimeField;
        
        private string EndDateField;
        
        private string EndTimeField;
        
        private string DescriptionField;
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="EmployeeNo.", IsRequired=true, EmitDefaultValue=false)]
        public string EmployeeNo
        {
            get
            {
                return this.EmployeeNoField;
            }
            set
            {
                this.EmployeeNoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string StartDate
        {
            get
            {
                return this.StartDateField;
            }
            set
            {
                this.StartDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string StartTime
        {
            get
            {
                return this.StartTimeField;
            }
            set
            {
                this.StartTimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false, Order=3)]
        public string EndDate
        {
            get
            {
                return this.EndDateField;
            }
            set
            {
                this.EndDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false, Order=4)]
        public string EndTime
        {
            get
            {
                return this.EndTimeField;
            }
            set
            {
                this.EndTimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false, Order=5)]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/ACADBot", ConfigurationName="NAV.ACADBot_Port")]
    public interface ACADBot_Port
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/ACADBot:CreateNewRequest", ReplyAction="*")]
        System.Threading.Tasks.Task<NAV.CreateNewRequest_Result> CreateNewRequestAsync(NAV.CreateNewRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateNewRequest", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/ACADBot", IsWrapped=true)]
    public partial class CreateNewRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/ACADBot", Order=0)]
        public NAV.OutofOfficeRequest outofOfficeRequests;
        
        public CreateNewRequest()
        {
        }
        
        public CreateNewRequest(NAV.OutofOfficeRequest outofOfficeRequests)
        {
            this.outofOfficeRequests = outofOfficeRequests;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateNewRequest_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/ACADBot", IsWrapped=true)]
    public partial class CreateNewRequest_Result
    {     
        public CreateNewRequest_Result()
        {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface ACADBot_PortChannel : NAV.ACADBot_Port, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class ACADBot_PortClient : System.ServiceModel.ClientBase<NAV.ACADBot_Port>, NAV.ACADBot_Port
    {
        
    /// <summary>
    /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
    /// </summary>
    /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
    /// <param name="clientCredentials">Учетные данные клиента.</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ACADBot_PortClient() : 
                base(ACADBot_PortClient.GetDefaultBinding(), ACADBot_PortClient.GetDefaultEndpointAddress())
        {
            ServicePointManager.ServerCertificateValidationCallback +=
                    (se, cert, chain, sslerror) => { return true; };

            this.Endpoint.Name = EndpointConfiguration.ACADBot_Port.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ACADBot_PortClient(EndpointConfiguration endpointConfiguration) : 
                base(ACADBot_PortClient.GetBindingForEndpoint(endpointConfiguration), ACADBot_PortClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ACADBot_PortClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ACADBot_PortClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ACADBot_PortClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ACADBot_PortClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ACADBot_PortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NAV.CreateNewRequest_Result> NAV.ACADBot_Port.CreateNewRequestAsync(NAV.CreateNewRequest request)
        {
            return base.Channel.CreateNewRequestAsync(request);
        }
        
        public System.Threading.Tasks.Task<NAV.CreateNewRequest_Result> CreateNewRequestAsync(NAV.OutofOfficeRequest outofOfficeRequests)
        {
            NAV.CreateNewRequest inValue = new NAV.CreateNewRequest();
            inValue.outofOfficeRequests = outofOfficeRequests;
            return ((NAV.ACADBot_Port)(this)).CreateNewRequestAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.ACADBot_Port))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;


                ServicePointManager.ServerCertificateValidationCallback +=
                    (se, cert, chain, sslerror) => { return true; };
                result.Security.Transport.ClientCredentialType = HttpClientCredentialType.Windows;


                return result;
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ACADBot_Port))
            {
                ServicePointManager.ServerCertificateValidationCallback +=
                    (se, cert, chain, sslerror) => { return true; };

                return new System.ServiceModel.EndpointAddress("https://13.94.251.189:7047/NAV05/WS/CRONUS International Ltd./Codeunit/ACADBot");
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ACADBot_PortClient.GetBindingForEndpoint(EndpointConfiguration.ACADBot_Port);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ACADBot_PortClient.GetEndpointAddress(EndpointConfiguration.ACADBot_Port);
        }
        
        public enum EndpointConfiguration
        {
            
            ACADBot_Port,
        }
    }
}
