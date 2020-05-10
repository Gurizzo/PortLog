﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC.ServiceReferenceImportacion {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ImportacionDTO", Namespace="http://schemas.datacontract.org/2004/07/Servicio.DTO")]
    [System.SerializableAttribute()]
    public partial class ImportacionDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CantidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EnviadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FchIngresoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FchSalidaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Dominio.Clases.Pais PaisField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Dominio.Clases.Producto ProductoField;
        
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
        public int Cantidad {
            get {
                return this.CantidadField;
            }
            set {
                if ((this.CantidadField.Equals(value) != true)) {
                    this.CantidadField = value;
                    this.RaisePropertyChanged("Cantidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Enviado {
            get {
                return this.EnviadoField;
            }
            set {
                if ((this.EnviadoField.Equals(value) != true)) {
                    this.EnviadoField = value;
                    this.RaisePropertyChanged("Enviado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FchIngreso {
            get {
                return this.FchIngresoField;
            }
            set {
                if ((this.FchIngresoField.Equals(value) != true)) {
                    this.FchIngresoField = value;
                    this.RaisePropertyChanged("FchIngreso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FchSalida {
            get {
                return this.FchSalidaField;
            }
            set {
                if ((this.FchSalidaField.Equals(value) != true)) {
                    this.FchSalidaField = value;
                    this.RaisePropertyChanged("FchSalida");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Dominio.Clases.Pais Pais {
            get {
                return this.PaisField;
            }
            set {
                if ((object.ReferenceEquals(this.PaisField, value) != true)) {
                    this.PaisField = value;
                    this.RaisePropertyChanged("Pais");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Dominio.Clases.Producto Producto {
            get {
                return this.ProductoField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductoField, value) != true)) {
                    this.ProductoField = value;
                    this.RaisePropertyChanged("Producto");
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
        private Dominio.Clases.Cliente ClienteField;
        
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
        public Dominio.Clases.Cliente Cliente {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceImportacion.IServicioImportacion")]
    public interface IServicioImportacion {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioImportacion/AltaImportacion", ReplyAction="http://tempuri.org/IServicioImportacion/AltaImportacionResponse")]
        bool AltaImportacion(MVC.ServiceReferenceImportacion.ImportacionDTO importacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioImportacion/AltaImportacion", ReplyAction="http://tempuri.org/IServicioImportacion/AltaImportacionResponse")]
        System.Threading.Tasks.Task<bool> AltaImportacionAsync(MVC.ServiceReferenceImportacion.ImportacionDTO importacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioImportacion/BajaImportacion", ReplyAction="http://tempuri.org/IServicioImportacion/BajaImportacionResponse")]
        bool BajaImportacion(int importacionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioImportacion/BajaImportacion", ReplyAction="http://tempuri.org/IServicioImportacion/BajaImportacionResponse")]
        System.Threading.Tasks.Task<bool> BajaImportacionAsync(int importacionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioImportacion/ModificarImportacion", ReplyAction="http://tempuri.org/IServicioImportacion/ModificarImportacionResponse")]
        bool ModificarImportacion(MVC.ServiceReferenceImportacion.ImportacionDTO importacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioImportacion/ModificarImportacion", ReplyAction="http://tempuri.org/IServicioImportacion/ModificarImportacionResponse")]
        System.Threading.Tasks.Task<bool> ModificarImportacionAsync(MVC.ServiceReferenceImportacion.ImportacionDTO importacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioImportacion/TraerTodos", ReplyAction="http://tempuri.org/IServicioImportacion/TraerTodosResponse")]
        MVC.ServiceReferenceImportacion.ImportacionDTO[] TraerTodos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioImportacion/TraerTodos", ReplyAction="http://tempuri.org/IServicioImportacion/TraerTodosResponse")]
        System.Threading.Tasks.Task<MVC.ServiceReferenceImportacion.ImportacionDTO[]> TraerTodosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioImportacion/BuscarImportacion", ReplyAction="http://tempuri.org/IServicioImportacion/BuscarImportacionResponse")]
        MVC.ServiceReferenceImportacion.ImportacionDTO BuscarImportacion(int genId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioImportacion/BuscarImportacion", ReplyAction="http://tempuri.org/IServicioImportacion/BuscarImportacionResponse")]
        System.Threading.Tasks.Task<MVC.ServiceReferenceImportacion.ImportacionDTO> BuscarImportacionAsync(int genId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioImportacion/TraerDatos", ReplyAction="http://tempuri.org/IServicioImportacion/TraerDatosResponse")]
        MVC.ServiceReferenceImportacion.ProductoDTO TraerDatos(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioImportacion/TraerDatos", ReplyAction="http://tempuri.org/IServicioImportacion/TraerDatosResponse")]
        System.Threading.Tasks.Task<MVC.ServiceReferenceImportacion.ProductoDTO> TraerDatosAsync(int codigo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioImportacionChannel : MVC.ServiceReferenceImportacion.IServicioImportacion, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioImportacionClient : System.ServiceModel.ClientBase<MVC.ServiceReferenceImportacion.IServicioImportacion>, MVC.ServiceReferenceImportacion.IServicioImportacion {
        
        public ServicioImportacionClient() {
        }
        
        public ServicioImportacionClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioImportacionClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioImportacionClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioImportacionClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AltaImportacion(MVC.ServiceReferenceImportacion.ImportacionDTO importacion) {
            return base.Channel.AltaImportacion(importacion);
        }
        
        public System.Threading.Tasks.Task<bool> AltaImportacionAsync(MVC.ServiceReferenceImportacion.ImportacionDTO importacion) {
            return base.Channel.AltaImportacionAsync(importacion);
        }
        
        public bool BajaImportacion(int importacionId) {
            return base.Channel.BajaImportacion(importacionId);
        }
        
        public System.Threading.Tasks.Task<bool> BajaImportacionAsync(int importacionId) {
            return base.Channel.BajaImportacionAsync(importacionId);
        }
        
        public bool ModificarImportacion(MVC.ServiceReferenceImportacion.ImportacionDTO importacion) {
            return base.Channel.ModificarImportacion(importacion);
        }
        
        public System.Threading.Tasks.Task<bool> ModificarImportacionAsync(MVC.ServiceReferenceImportacion.ImportacionDTO importacion) {
            return base.Channel.ModificarImportacionAsync(importacion);
        }
        
        public MVC.ServiceReferenceImportacion.ImportacionDTO[] TraerTodos() {
            return base.Channel.TraerTodos();
        }
        
        public System.Threading.Tasks.Task<MVC.ServiceReferenceImportacion.ImportacionDTO[]> TraerTodosAsync() {
            return base.Channel.TraerTodosAsync();
        }
        
        public MVC.ServiceReferenceImportacion.ImportacionDTO BuscarImportacion(int genId) {
            return base.Channel.BuscarImportacion(genId);
        }
        
        public System.Threading.Tasks.Task<MVC.ServiceReferenceImportacion.ImportacionDTO> BuscarImportacionAsync(int genId) {
            return base.Channel.BuscarImportacionAsync(genId);
        }
        
        public MVC.ServiceReferenceImportacion.ProductoDTO TraerDatos(int codigo) {
            return base.Channel.TraerDatos(codigo);
        }
        
        public System.Threading.Tasks.Task<MVC.ServiceReferenceImportacion.ProductoDTO> TraerDatosAsync(int codigo) {
            return base.Channel.TraerDatosAsync(codigo);
        }
    }
}
