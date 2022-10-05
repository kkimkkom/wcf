﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoginClient2.LoginReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LoginReference.ILogin")]
    public interface ILogin {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogin/Login", ReplyAction="http://tempuri.org/ILogin/LoginResponse")]
        string Login(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogin/Login", ReplyAction="http://tempuri.org/ILogin/LoginResponse")]
        System.Threading.Tasks.Task<string> LoginAsync(string email, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILoginChannel : LoginClient2.LoginReference.ILogin, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LoginClient : System.ServiceModel.ClientBase<LoginClient2.LoginReference.ILogin>, LoginClient2.LoginReference.ILogin {
        
        public LoginClient() {
        }
        
        public LoginClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LoginClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Login(string email, string password) {
            return base.Channel.Login(email, password);
        }
        
        public System.Threading.Tasks.Task<string> LoginAsync(string email, string password) {
            return base.Channel.LoginAsync(email, password);
        }
    }
}
