﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_SITE.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IBD")]
    public interface IBD {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBD/ListarDatos", ReplyAction="http://tempuri.org/IBD/ListarDatosResponse")]
        System.Data.DataTable ListarDatos(string sNombreSP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBD/ListarDatos", ReplyAction="http://tempuri.org/IBD/ListarDatosResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> ListarDatosAsync(string sNombreSP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBD/Insertar_Usuarios", ReplyAction="http://tempuri.org/IBD/Insertar_UsuariosResponse")]
        string Insertar_Usuarios(string Correo, string Clave, string Nombre, string Notas, string Telefono, bool Notificaciones);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBD/Insertar_Usuarios", ReplyAction="http://tempuri.org/IBD/Insertar_UsuariosResponse")]
        System.Threading.Tasks.Task<string> Insertar_UsuariosAsync(string Correo, string Clave, string Nombre, string Notas, string Telefono, bool Notificaciones);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBD/InicioSesion", ReplyAction="http://tempuri.org/IBD/InicioSesionResponse")]
        string InicioSesion(string Correo, string Clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBD/InicioSesion", ReplyAction="http://tempuri.org/IBD/InicioSesionResponse")]
        System.Threading.Tasks.Task<string> InicioSesionAsync(string Correo, string Clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBD/Modificar_Usuario", ReplyAction="http://tempuri.org/IBD/Modificar_UsuarioResponse")]
        string Modificar_Usuario(short idUsuario, string Correo, string Clave, string Nombre, string Notas, string Telefono, bool Notificaciones);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBD/Modificar_Usuario", ReplyAction="http://tempuri.org/IBD/Modificar_UsuarioResponse")]
        System.Threading.Tasks.Task<string> Modificar_UsuarioAsync(short idUsuario, string Correo, string Clave, string Nombre, string Notas, string Telefono, bool Notificaciones);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBD/FILTRARDatos", ReplyAction="http://tempuri.org/IBD/FILTRARDatosResponse")]
        System.Data.DataTable FILTRARDatos(string sNombreSP, string sNombreParametro, System.Data.SqlDbType DBType, string svalorparametro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBD/FILTRARDatos", ReplyAction="http://tempuri.org/IBD/FILTRARDatosResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> FILTRARDatosAsync(string sNombreSP, string sNombreParametro, System.Data.SqlDbType DBType, string svalorparametro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBD/ConectarBD", ReplyAction="http://tempuri.org/IBD/ConectarBDResponse")]
        bool ConectarBD();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBD/ConectarBD", ReplyAction="http://tempuri.org/IBD/ConectarBDResponse")]
        System.Threading.Tasks.Task<bool> ConectarBDAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBD/SUMAR", ReplyAction="http://tempuri.org/IBD/SUMARResponse")]
        int SUMAR(int Valor_1, int Valor_2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBD/SUMAR", ReplyAction="http://tempuri.org/IBD/SUMARResponse")]
        System.Threading.Tasks.Task<int> SUMARAsync(int Valor_1, int Valor_2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBDChannel : Proyecto_SITE.ServiceReference.IBD, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BDClient : System.ServiceModel.ClientBase<Proyecto_SITE.ServiceReference.IBD>, Proyecto_SITE.ServiceReference.IBD {
        
        public BDClient() {
        }
        
        public BDClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BDClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BDClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BDClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable ListarDatos(string sNombreSP) {
            return base.Channel.ListarDatos(sNombreSP);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> ListarDatosAsync(string sNombreSP) {
            return base.Channel.ListarDatosAsync(sNombreSP);
        }
        
        public string Insertar_Usuarios(string Correo, string Clave, string Nombre, string Notas, string Telefono, bool Notificaciones) {
            return base.Channel.Insertar_Usuarios(Correo, Clave, Nombre, Notas, Telefono, Notificaciones);
        }
        
        public System.Threading.Tasks.Task<string> Insertar_UsuariosAsync(string Correo, string Clave, string Nombre, string Notas, string Telefono, bool Notificaciones) {
            return base.Channel.Insertar_UsuariosAsync(Correo, Clave, Nombre, Notas, Telefono, Notificaciones);
        }
        
        public string InicioSesion(string Correo, string Clave) {
            return base.Channel.InicioSesion(Correo, Clave);
        }
        
        public System.Threading.Tasks.Task<string> InicioSesionAsync(string Correo, string Clave) {
            return base.Channel.InicioSesionAsync(Correo, Clave);
        }
        
        public string Modificar_Usuario(short idUsuario, string Correo, string Clave, string Nombre, string Notas, string Telefono, bool Notificaciones) {
            return base.Channel.Modificar_Usuario(idUsuario, Correo, Clave, Nombre, Notas, Telefono, Notificaciones);
        }
        
        public System.Threading.Tasks.Task<string> Modificar_UsuarioAsync(short idUsuario, string Correo, string Clave, string Nombre, string Notas, string Telefono, bool Notificaciones) {
            return base.Channel.Modificar_UsuarioAsync(idUsuario, Correo, Clave, Nombre, Notas, Telefono, Notificaciones);
        }
        
        public System.Data.DataTable FILTRARDatos(string sNombreSP, string sNombreParametro, System.Data.SqlDbType DBType, string svalorparametro) {
            return base.Channel.FILTRARDatos(sNombreSP, sNombreParametro, DBType, svalorparametro);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> FILTRARDatosAsync(string sNombreSP, string sNombreParametro, System.Data.SqlDbType DBType, string svalorparametro) {
            return base.Channel.FILTRARDatosAsync(sNombreSP, sNombreParametro, DBType, svalorparametro);
        }
        
        public bool ConectarBD() {
            return base.Channel.ConectarBD();
        }
        
        public System.Threading.Tasks.Task<bool> ConectarBDAsync() {
            return base.Channel.ConectarBDAsync();
        }
        
        public int SUMAR(int Valor_1, int Valor_2) {
            return base.Channel.SUMAR(Valor_1, Valor_2);
        }
        
        public System.Threading.Tasks.Task<int> SUMARAsync(int Valor_1, int Valor_2) {
            return base.Channel.SUMARAsync(Valor_1, Valor_2);
        }
    }
}
