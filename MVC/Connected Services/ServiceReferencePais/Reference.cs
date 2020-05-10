﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC.ServiceReferencePais {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PaisDTO", Namespace="http://schemas.datacontract.org/2004/07/Servicio.DTO")]
    [System.SerializableAttribute()]
    public partial class PaisDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodPaisField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdPaisField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombrePaisField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodPais {
            get {
                return this.CodPaisField;
            }
            set {
                if ((object.ReferenceEquals(this.CodPaisField, value) != true)) {
                    this.CodPaisField = value;
                    this.RaisePropertyChanged("CodPais");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdPais {
            get {
                return this.IdPaisField;
            }
            set {
                if ((this.IdPaisField.Equals(value) != true)) {
                    this.IdPaisField = value;
                    this.RaisePropertyChanged("IdPais");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombrePais {
            get {
                return this.NombrePaisField;
            }
            set {
                if ((object.ReferenceEquals(this.NombrePaisField, value) != true)) {
                    this.NombrePaisField = value;
                    this.RaisePropertyChanged("NombrePais");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferencePais.IServicioPais")]
    public interface IServicioPais {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPais/TraerTodos", ReplyAction="http://tempuri.org/IServicioPais/TraerTodosResponse")]
        MVC.ServiceReferencePais.PaisDTO[] TraerTodos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPais/TraerTodos", ReplyAction="http://tempuri.org/IServicioPais/TraerTodosResponse")]
        System.Threading.Tasks.Task<MVC.ServiceReferencePais.PaisDTO[]> TraerTodosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPais/BuscarPais", ReplyAction="http://tempuri.org/IServicioPais/BuscarPaisResponse")]
        MVC.ServiceReferencePais.PaisDTO BuscarPais(int paisId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPais/BuscarPais", ReplyAction="http://tempuri.org/IServicioPais/BuscarPaisResponse")]
        System.Threading.Tasks.Task<MVC.ServiceReferencePais.PaisDTO> BuscarPaisAsync(int paisId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioPaisChannel : MVC.ServiceReferencePais.IServicioPais, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioPaisClient : System.ServiceModel.ClientBase<MVC.ServiceReferencePais.IServicioPais>, MVC.ServiceReferencePais.IServicioPais {
        
        public ServicioPaisClient() {
        }
        
        public ServicioPaisClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioPaisClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioPaisClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioPaisClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MVC.ServiceReferencePais.PaisDTO[] TraerTodos() {
            return base.Channel.TraerTodos();
        }
        
        public System.Threading.Tasks.Task<MVC.ServiceReferencePais.PaisDTO[]> TraerTodosAsync() {
            return base.Channel.TraerTodosAsync();
        }
        
        public MVC.ServiceReferencePais.PaisDTO BuscarPais(int paisId) {
            return base.Channel.BuscarPais(paisId);
        }
        
        public System.Threading.Tasks.Task<MVC.ServiceReferencePais.PaisDTO> BuscarPaisAsync(int paisId) {
            return base.Channel.BuscarPaisAsync(paisId);
        }
    }
}
