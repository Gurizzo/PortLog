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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceImportacion.IServicioImportacion")]
    public interface IServicioImportacion {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioImportacion/DoWork", ReplyAction="http://tempuri.org/IServicioImportacion/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioImportacion/DoWork", ReplyAction="http://tempuri.org/IServicioImportacion/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
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
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
    }
}