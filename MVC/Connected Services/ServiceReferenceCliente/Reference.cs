﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC.ServiceReferenceCliente {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClienteDTO", Namespace="http://schemas.datacontract.org/2004/07/Servicio.DTO")]
    [System.SerializableAttribute()]
    public partial class ClienteDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime AntiguedadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MVC.ServiceReferenceCliente.ProductoDTO[] ProductosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RutField;
        
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
        public System.DateTime Antiguedad {
            get {
                return this.AntiguedadField;
            }
            set {
                if ((this.AntiguedadField.Equals(value) != true)) {
                    this.AntiguedadField = value;
                    this.RaisePropertyChanged("Antiguedad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MVC.ServiceReferenceCliente.ProductoDTO[] Productos {
            get {
                return this.ProductosField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductosField, value) != true)) {
                    this.ProductosField = value;
                    this.RaisePropertyChanged("Productos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Rut {
            get {
                return this.RutField;
            }
            set {
                if ((object.ReferenceEquals(this.RutField, value) != true)) {
                    this.RutField = value;
                    this.RaisePropertyChanged("Rut");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductoDTO", Namespace="http://schemas.datacontract.org/2004/07/Servicio.DTO")]
    [System.SerializableAttribute()]
    public partial class ProductoDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MVC.ServiceReferenceCliente.ClienteDTO ClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PesoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PrecioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StockField;
        
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
        public MVC.ServiceReferenceCliente.ClienteDTO Cliente {
            get {
                return this.ClienteField;
            }
            set {
                if ((object.ReferenceEquals(this.ClienteField, value) != true)) {
                    this.ClienteField = value;
                    this.RaisePropertyChanged("Cliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((this.CodigoField.Equals(value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Peso {
            get {
                return this.PesoField;
            }
            set {
                if ((this.PesoField.Equals(value) != true)) {
                    this.PesoField = value;
                    this.RaisePropertyChanged("Peso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Precio {
            get {
                return this.PrecioField;
            }
            set {
                if ((this.PrecioField.Equals(value) != true)) {
                    this.PrecioField = value;
                    this.RaisePropertyChanged("Precio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Stock {
            get {
                return this.StockField;
            }
            set {
                if ((this.StockField.Equals(value) != true)) {
                    this.StockField = value;
                    this.RaisePropertyChanged("Stock");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceCliente.IServicioCliente")]
    public interface IServicioCliente {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/AltaCliente", ReplyAction="http://tempuri.org/IServicioCliente/AltaClienteResponse")]
        bool AltaCliente(MVC.ServiceReferenceCliente.ClienteDTO cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/AltaCliente", ReplyAction="http://tempuri.org/IServicioCliente/AltaClienteResponse")]
        System.Threading.Tasks.Task<bool> AltaClienteAsync(MVC.ServiceReferenceCliente.ClienteDTO cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/BajaCliente", ReplyAction="http://tempuri.org/IServicioCliente/BajaClienteResponse")]
        bool BajaCliente(int clienteId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/BajaCliente", ReplyAction="http://tempuri.org/IServicioCliente/BajaClienteResponse")]
        System.Threading.Tasks.Task<bool> BajaClienteAsync(int clienteId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/ModificarCliente", ReplyAction="http://tempuri.org/IServicioCliente/ModificarClienteResponse")]
        bool ModificarCliente(MVC.ServiceReferenceCliente.ClienteDTO cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/ModificarCliente", ReplyAction="http://tempuri.org/IServicioCliente/ModificarClienteResponse")]
        System.Threading.Tasks.Task<bool> ModificarClienteAsync(MVC.ServiceReferenceCliente.ClienteDTO cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/TraerTodos", ReplyAction="http://tempuri.org/IServicioCliente/TraerTodosResponse")]
        MVC.ServiceReferenceCliente.ClienteDTO[] TraerTodos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/TraerTodos", ReplyAction="http://tempuri.org/IServicioCliente/TraerTodosResponse")]
        System.Threading.Tasks.Task<MVC.ServiceReferenceCliente.ClienteDTO[]> TraerTodosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/BuscarCliente", ReplyAction="http://tempuri.org/IServicioCliente/BuscarClienteResponse")]
        MVC.ServiceReferenceCliente.ClienteDTO BuscarCliente(int clienteId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/BuscarCliente", ReplyAction="http://tempuri.org/IServicioCliente/BuscarClienteResponse")]
        System.Threading.Tasks.Task<MVC.ServiceReferenceCliente.ClienteDTO> BuscarClienteAsync(int clienteId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/CalcularGanancia", ReplyAction="http://tempuri.org/IServicioCliente/CalcularGananciaResponse")]
        decimal CalcularGanancia(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/CalcularGanancia", ReplyAction="http://tempuri.org/IServicioCliente/CalcularGananciaResponse")]
        System.Threading.Tasks.Task<decimal> CalcularGananciaAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioClienteChannel : MVC.ServiceReferenceCliente.IServicioCliente, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioClienteClient : System.ServiceModel.ClientBase<MVC.ServiceReferenceCliente.IServicioCliente>, MVC.ServiceReferenceCliente.IServicioCliente {
        
        public ServicioClienteClient() {
        }
        
        public ServicioClienteClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioClienteClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioClienteClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioClienteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AltaCliente(MVC.ServiceReferenceCliente.ClienteDTO cliente) {
            return base.Channel.AltaCliente(cliente);
        }
        
        public System.Threading.Tasks.Task<bool> AltaClienteAsync(MVC.ServiceReferenceCliente.ClienteDTO cliente) {
            return base.Channel.AltaClienteAsync(cliente);
        }
        
        public bool BajaCliente(int clienteId) {
            return base.Channel.BajaCliente(clienteId);
        }
        
        public System.Threading.Tasks.Task<bool> BajaClienteAsync(int clienteId) {
            return base.Channel.BajaClienteAsync(clienteId);
        }
        
        public bool ModificarCliente(MVC.ServiceReferenceCliente.ClienteDTO cliente) {
            return base.Channel.ModificarCliente(cliente);
        }
        
        public System.Threading.Tasks.Task<bool> ModificarClienteAsync(MVC.ServiceReferenceCliente.ClienteDTO cliente) {
            return base.Channel.ModificarClienteAsync(cliente);
        }
        
        public MVC.ServiceReferenceCliente.ClienteDTO[] TraerTodos() {
            return base.Channel.TraerTodos();
        }
        
        public System.Threading.Tasks.Task<MVC.ServiceReferenceCliente.ClienteDTO[]> TraerTodosAsync() {
            return base.Channel.TraerTodosAsync();
        }
        
        public MVC.ServiceReferenceCliente.ClienteDTO BuscarCliente(int clienteId) {
            return base.Channel.BuscarCliente(clienteId);
        }
        
        public System.Threading.Tasks.Task<MVC.ServiceReferenceCliente.ClienteDTO> BuscarClienteAsync(int clienteId) {
            return base.Channel.BuscarClienteAsync(clienteId);
        }
        
        public decimal CalcularGanancia(int id) {
            return base.Channel.CalcularGanancia(id);
        }
        
        public System.Threading.Tasks.Task<decimal> CalcularGananciaAsync(int id) {
            return base.Channel.CalcularGananciaAsync(id);
        }
    }
}
