﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC.ServiceReferenceUsuario {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UsuarioDTO", Namespace="http://schemas.datacontract.org/2004/07/Servicio.DTO")]
    [System.SerializableAttribute()]
    public partial class UsuarioDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CIField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RolField;
        
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
        public string CI {
            get {
                return this.CIField;
            }
            set {
                if ((object.ReferenceEquals(this.CIField, value) != true)) {
                    this.CIField = value;
                    this.RaisePropertyChanged("CI");
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
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Rol {
            get {
                return this.RolField;
            }
            set {
                if ((object.ReferenceEquals(this.RolField, value) != true)) {
                    this.RolField = value;
                    this.RaisePropertyChanged("Rol");
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
        private MVC.ServiceReferenceUsuario.PaisDTO PaisField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MVC.ServiceReferenceUsuario.ProductoDTO ProductoField;
        
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
        public MVC.ServiceReferenceUsuario.PaisDTO Pais {
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
        public MVC.ServiceReferenceUsuario.ProductoDTO Producto {
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductoDTO", Namespace="http://schemas.datacontract.org/2004/07/Servicio.DTO")]
    [System.SerializableAttribute()]
    public partial class ProductoDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MVC.ServiceReferenceUsuario.ClienteDTO ClienteField;
        
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
        public MVC.ServiceReferenceUsuario.ClienteDTO Cliente {
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
        private MVC.ServiceReferenceUsuario.ProductoDTO[] ProductosField;
        
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
        public MVC.ServiceReferenceUsuario.ProductoDTO[] Productos {
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceUsuario.IServicioUsuario")]
    public interface IServicioUsuario {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/Alta", ReplyAction="http://tempuri.org/IServicioUsuario/AltaResponse")]
        bool Alta(string cedula, string password, string rol);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/Alta", ReplyAction="http://tempuri.org/IServicioUsuario/AltaResponse")]
        System.Threading.Tasks.Task<bool> AltaAsync(string cedula, string password, string rol);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/Logear", ReplyAction="http://tempuri.org/IServicioUsuario/LogearResponse")]
        MVC.ServiceReferenceUsuario.UsuarioDTO Logear(string ci, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/Logear", ReplyAction="http://tempuri.org/IServicioUsuario/LogearResponse")]
        System.Threading.Tasks.Task<MVC.ServiceReferenceUsuario.UsuarioDTO> LogearAsync(string ci, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/DatosImportacion", ReplyAction="http://tempuri.org/IServicioUsuario/DatosImportacionResponse")]
        MVC.ServiceReferenceUsuario.ImportacionDTO[] DatosImportacion();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/DatosImportacion", ReplyAction="http://tempuri.org/IServicioUsuario/DatosImportacionResponse")]
        System.Threading.Tasks.Task<MVC.ServiceReferenceUsuario.ImportacionDTO[]> DatosImportacionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/DatosProductos", ReplyAction="http://tempuri.org/IServicioUsuario/DatosProductosResponse")]
        MVC.ServiceReferenceUsuario.ProductoDTO[] DatosProductos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/DatosProductos", ReplyAction="http://tempuri.org/IServicioUsuario/DatosProductosResponse")]
        System.Threading.Tasks.Task<MVC.ServiceReferenceUsuario.ProductoDTO[]> DatosProductosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/DatosClientes", ReplyAction="http://tempuri.org/IServicioUsuario/DatosClientesResponse")]
        MVC.ServiceReferenceUsuario.ClienteDTO[] DatosClientes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/DatosClientes", ReplyAction="http://tempuri.org/IServicioUsuario/DatosClientesResponse")]
        System.Threading.Tasks.Task<MVC.ServiceReferenceUsuario.ClienteDTO[]> DatosClientesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/DatosUsuarios", ReplyAction="http://tempuri.org/IServicioUsuario/DatosUsuariosResponse")]
        MVC.ServiceReferenceUsuario.UsuarioDTO[] DatosUsuarios();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/DatosUsuarios", ReplyAction="http://tempuri.org/IServicioUsuario/DatosUsuariosResponse")]
        System.Threading.Tasks.Task<MVC.ServiceReferenceUsuario.UsuarioDTO[]> DatosUsuariosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/DatosDescuentos", ReplyAction="http://tempuri.org/IServicioUsuario/DatosDescuentosResponse")]
        string[] DatosDescuentos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/DatosDescuentos", ReplyAction="http://tempuri.org/IServicioUsuario/DatosDescuentosResponse")]
        System.Threading.Tasks.Task<string[]> DatosDescuentosAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioUsuarioChannel : MVC.ServiceReferenceUsuario.IServicioUsuario, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioUsuarioClient : System.ServiceModel.ClientBase<MVC.ServiceReferenceUsuario.IServicioUsuario>, MVC.ServiceReferenceUsuario.IServicioUsuario {
        
        public ServicioUsuarioClient() {
        }
        
        public ServicioUsuarioClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioUsuarioClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioUsuarioClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioUsuarioClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Alta(string cedula, string password, string rol) {
            return base.Channel.Alta(cedula, password, rol);
        }
        
        public System.Threading.Tasks.Task<bool> AltaAsync(string cedula, string password, string rol) {
            return base.Channel.AltaAsync(cedula, password, rol);
        }
        
        public MVC.ServiceReferenceUsuario.UsuarioDTO Logear(string ci, string password) {
            return base.Channel.Logear(ci, password);
        }
        
        public System.Threading.Tasks.Task<MVC.ServiceReferenceUsuario.UsuarioDTO> LogearAsync(string ci, string password) {
            return base.Channel.LogearAsync(ci, password);
        }
        
        public MVC.ServiceReferenceUsuario.ImportacionDTO[] DatosImportacion() {
            return base.Channel.DatosImportacion();
        }
        
        public System.Threading.Tasks.Task<MVC.ServiceReferenceUsuario.ImportacionDTO[]> DatosImportacionAsync() {
            return base.Channel.DatosImportacionAsync();
        }
        
        public MVC.ServiceReferenceUsuario.ProductoDTO[] DatosProductos() {
            return base.Channel.DatosProductos();
        }
        
        public System.Threading.Tasks.Task<MVC.ServiceReferenceUsuario.ProductoDTO[]> DatosProductosAsync() {
            return base.Channel.DatosProductosAsync();
        }
        
        public MVC.ServiceReferenceUsuario.ClienteDTO[] DatosClientes() {
            return base.Channel.DatosClientes();
        }
        
        public System.Threading.Tasks.Task<MVC.ServiceReferenceUsuario.ClienteDTO[]> DatosClientesAsync() {
            return base.Channel.DatosClientesAsync();
        }
        
        public MVC.ServiceReferenceUsuario.UsuarioDTO[] DatosUsuarios() {
            return base.Channel.DatosUsuarios();
        }
        
        public System.Threading.Tasks.Task<MVC.ServiceReferenceUsuario.UsuarioDTO[]> DatosUsuariosAsync() {
            return base.Channel.DatosUsuariosAsync();
        }
        
        public string[] DatosDescuentos() {
            return base.Channel.DatosDescuentos();
        }
        
        public System.Threading.Tasks.Task<string[]> DatosDescuentosAsync() {
            return base.Channel.DatosDescuentosAsync();
        }
    }
}
