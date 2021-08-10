﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserCatalogServiceReference
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/BirthEntryServiceDAO_WCF.entities")]
    public partial class User : object
    {
        
        private System.DateTime BirthDateField;
        
        private string EntryDateField;
        
        private string HostNameField;
        
        private string LOCAL_IP_AddressField;
        
        private string PUBLIC_IP_AddressField;
        
        private string UserNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime BirthDate
        {
            get
            {
                return this.BirthDateField;
            }
            set
            {
                this.BirthDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EntryDate
        {
            get
            {
                return this.EntryDateField;
            }
            set
            {
                this.EntryDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HostName
        {
            get
            {
                return this.HostNameField;
            }
            set
            {
                this.HostNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LOCAL_IP_Address
        {
            get
            {
                return this.LOCAL_IP_AddressField;
            }
            set
            {
                this.LOCAL_IP_AddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PUBLIC_IP_Address
        {
            get
            {
                return this.PUBLIC_IP_AddressField;
            }
            set
            {
                this.PUBLIC_IP_AddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName
        {
            get
            {
                return this.UserNameField;
            }
            set
            {
                this.UserNameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserCatalogServiceReference.IUserCatalogDAO")]
    public interface IUserCatalogDAO
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserCatalogDAO/InsertNewUser", ReplyAction="http://tempuri.org/IUserCatalogDAO/InsertNewUserResponse")]
        bool InsertNewUser(UserCatalogServiceReference.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserCatalogDAO/InsertNewUser", ReplyAction="http://tempuri.org/IUserCatalogDAO/InsertNewUserResponse")]
        System.Threading.Tasks.Task<bool> InsertNewUserAsync(UserCatalogServiceReference.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserCatalogDAO/GetAllUsers", ReplyAction="http://tempuri.org/IUserCatalogDAO/GetAllUsersResponse")]
        UserCatalogServiceReference.User[] GetAllUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserCatalogDAO/GetAllUsers", ReplyAction="http://tempuri.org/IUserCatalogDAO/GetAllUsersResponse")]
        System.Threading.Tasks.Task<UserCatalogServiceReference.User[]> GetAllUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserCatalogDAO/GetUsersByDateOfBirth", ReplyAction="http://tempuri.org/IUserCatalogDAO/GetUsersByDateOfBirthResponse")]
        UserCatalogServiceReference.User[] GetUsersByDateOfBirth(string dateOfBirth);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserCatalogDAO/GetUsersByDateOfBirth", ReplyAction="http://tempuri.org/IUserCatalogDAO/GetUsersByDateOfBirthResponse")]
        System.Threading.Tasks.Task<UserCatalogServiceReference.User[]> GetUsersByDateOfBirthAsync(string dateOfBirth);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserCatalogDAO/GetUsersAfterDateOfBirth", ReplyAction="http://tempuri.org/IUserCatalogDAO/GetUsersAfterDateOfBirthResponse")]
        UserCatalogServiceReference.User[] GetUsersAfterDateOfBirth(string dateOfBirth);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserCatalogDAO/GetUsersAfterDateOfBirth", ReplyAction="http://tempuri.org/IUserCatalogDAO/GetUsersAfterDateOfBirthResponse")]
        System.Threading.Tasks.Task<UserCatalogServiceReference.User[]> GetUsersAfterDateOfBirthAsync(string dateOfBirth);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserCatalogDAO/GetUsersBeforeDateOfBirth", ReplyAction="http://tempuri.org/IUserCatalogDAO/GetUsersBeforeDateOfBirthResponse")]
        UserCatalogServiceReference.User[] GetUsersBeforeDateOfBirth(string dateOfBirth);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserCatalogDAO/GetUsersBeforeDateOfBirth", ReplyAction="http://tempuri.org/IUserCatalogDAO/GetUsersBeforeDateOfBirthResponse")]
        System.Threading.Tasks.Task<UserCatalogServiceReference.User[]> GetUsersBeforeDateOfBirthAsync(string dateOfBirth);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserCatalogDAO/GetUsersByDateEntryRange", ReplyAction="http://tempuri.org/IUserCatalogDAO/GetUsersByDateEntryRangeResponse")]
        UserCatalogServiceReference.User[] GetUsersByDateEntryRange(string minimalDate, string maximumDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserCatalogDAO/GetUsersByDateEntryRange", ReplyAction="http://tempuri.org/IUserCatalogDAO/GetUsersByDateEntryRangeResponse")]
        System.Threading.Tasks.Task<UserCatalogServiceReference.User[]> GetUsersByDateEntryRangeAsync(string minimalDate, string maximumDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserCatalogDAO/GetUsersByEntryDateTimeline", ReplyAction="http://tempuri.org/IUserCatalogDAO/GetUsersByEntryDateTimelineResponse")]
        UserCatalogServiceReference.User[] GetUsersByEntryDateTimeline(string timeline);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserCatalogDAO/GetUsersByEntryDateTimeline", ReplyAction="http://tempuri.org/IUserCatalogDAO/GetUsersByEntryDateTimelineResponse")]
        System.Threading.Tasks.Task<UserCatalogServiceReference.User[]> GetUsersByEntryDateTimelineAsync(string timeline);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserCatalogDAO/GetUsersByPublicIP", ReplyAction="http://tempuri.org/IUserCatalogDAO/GetUsersByPublicIPResponse")]
        UserCatalogServiceReference.User[] GetUsersByPublicIP(string publicIP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserCatalogDAO/GetUsersByPublicIP", ReplyAction="http://tempuri.org/IUserCatalogDAO/GetUsersByPublicIPResponse")]
        System.Threading.Tasks.Task<UserCatalogServiceReference.User[]> GetUsersByPublicIPAsync(string publicIP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserCatalogDAO/GetByUsername", ReplyAction="http://tempuri.org/IUserCatalogDAO/GetByUsernameResponse")]
        UserCatalogServiceReference.User[] GetByUsername(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserCatalogDAO/GetByUsername", ReplyAction="http://tempuri.org/IUserCatalogDAO/GetByUsernameResponse")]
        System.Threading.Tasks.Task<UserCatalogServiceReference.User[]> GetByUsernameAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserCatalogDAO/GetByUsernamePattern", ReplyAction="http://tempuri.org/IUserCatalogDAO/GetByUsernamePatternResponse")]
        UserCatalogServiceReference.User[] GetByUsernamePattern(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserCatalogDAO/GetByUsernamePattern", ReplyAction="http://tempuri.org/IUserCatalogDAO/GetByUsernamePatternResponse")]
        System.Threading.Tasks.Task<UserCatalogServiceReference.User[]> GetByUsernamePatternAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserCatalogDAO/GetUsersByDateEntry", ReplyAction="http://tempuri.org/IUserCatalogDAO/GetUsersByDateEntryResponse")]
        UserCatalogServiceReference.User[] GetUsersByDateEntry(string entryDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserCatalogDAO/GetUsersByDateEntry", ReplyAction="http://tempuri.org/IUserCatalogDAO/GetUsersByDateEntryResponse")]
        System.Threading.Tasks.Task<UserCatalogServiceReference.User[]> GetUsersByDateEntryAsync(string entryDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserCatalogDAO/GetUsersOlderThanAge", ReplyAction="http://tempuri.org/IUserCatalogDAO/GetUsersOlderThanAgeResponse")]
        UserCatalogServiceReference.User[] GetUsersOlderThanAge(int age);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserCatalogDAO/GetUsersOlderThanAge", ReplyAction="http://tempuri.org/IUserCatalogDAO/GetUsersOlderThanAgeResponse")]
        System.Threading.Tasks.Task<UserCatalogServiceReference.User[]> GetUsersOlderThanAgeAsync(int age);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserCatalogDAO/GetUsersByAgeRange", ReplyAction="http://tempuri.org/IUserCatalogDAO/GetUsersByAgeRangeResponse")]
        UserCatalogServiceReference.User[] GetUsersByAgeRange(int minimalAge, int maximalAge);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserCatalogDAO/GetUsersByAgeRange", ReplyAction="http://tempuri.org/IUserCatalogDAO/GetUsersByAgeRangeResponse")]
        System.Threading.Tasks.Task<UserCatalogServiceReference.User[]> GetUsersByAgeRangeAsync(int minimalAge, int maximalAge);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IUserCatalogDAOChannel : UserCatalogServiceReference.IUserCatalogDAO, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class UserCatalogDAOClient : System.ServiceModel.ClientBase<UserCatalogServiceReference.IUserCatalogDAO>, UserCatalogServiceReference.IUserCatalogDAO
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public UserCatalogDAOClient() : 
                base(UserCatalogDAOClient.GetDefaultBinding(), UserCatalogDAOClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IUserCatalogDAO.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserCatalogDAOClient(EndpointConfiguration endpointConfiguration) : 
                base(UserCatalogDAOClient.GetBindingForEndpoint(endpointConfiguration), UserCatalogDAOClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserCatalogDAOClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(UserCatalogDAOClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserCatalogDAOClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(UserCatalogDAOClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserCatalogDAOClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public bool InsertNewUser(UserCatalogServiceReference.User user)
        {
            return base.Channel.InsertNewUser(user);
        }
        
        public System.Threading.Tasks.Task<bool> InsertNewUserAsync(UserCatalogServiceReference.User user)
        {
            return base.Channel.InsertNewUserAsync(user);
        }
        
        public UserCatalogServiceReference.User[] GetAllUsers()
        {
            return base.Channel.GetAllUsers();
        }
        
        public System.Threading.Tasks.Task<UserCatalogServiceReference.User[]> GetAllUsersAsync()
        {
            return base.Channel.GetAllUsersAsync();
        }
        
        public UserCatalogServiceReference.User[] GetUsersByDateOfBirth(string dateOfBirth)
        {
            return base.Channel.GetUsersByDateOfBirth(dateOfBirth);
        }
        
        public System.Threading.Tasks.Task<UserCatalogServiceReference.User[]> GetUsersByDateOfBirthAsync(string dateOfBirth)
        {
            return base.Channel.GetUsersByDateOfBirthAsync(dateOfBirth);
        }
        
        public UserCatalogServiceReference.User[] GetUsersAfterDateOfBirth(string dateOfBirth)
        {
            return base.Channel.GetUsersAfterDateOfBirth(dateOfBirth);
        }
        
        public System.Threading.Tasks.Task<UserCatalogServiceReference.User[]> GetUsersAfterDateOfBirthAsync(string dateOfBirth)
        {
            return base.Channel.GetUsersAfterDateOfBirthAsync(dateOfBirth);
        }
        
        public UserCatalogServiceReference.User[] GetUsersBeforeDateOfBirth(string dateOfBirth)
        {
            return base.Channel.GetUsersBeforeDateOfBirth(dateOfBirth);
        }
        
        public System.Threading.Tasks.Task<UserCatalogServiceReference.User[]> GetUsersBeforeDateOfBirthAsync(string dateOfBirth)
        {
            return base.Channel.GetUsersBeforeDateOfBirthAsync(dateOfBirth);
        }
        
        public UserCatalogServiceReference.User[] GetUsersByDateEntryRange(string minimalDate, string maximumDate)
        {
            return base.Channel.GetUsersByDateEntryRange(minimalDate, maximumDate);
        }
        
        public System.Threading.Tasks.Task<UserCatalogServiceReference.User[]> GetUsersByDateEntryRangeAsync(string minimalDate, string maximumDate)
        {
            return base.Channel.GetUsersByDateEntryRangeAsync(minimalDate, maximumDate);
        }
        
        public UserCatalogServiceReference.User[] GetUsersByEntryDateTimeline(string timeline)
        {
            return base.Channel.GetUsersByEntryDateTimeline(timeline);
        }
        
        public System.Threading.Tasks.Task<UserCatalogServiceReference.User[]> GetUsersByEntryDateTimelineAsync(string timeline)
        {
            return base.Channel.GetUsersByEntryDateTimelineAsync(timeline);
        }
        
        public UserCatalogServiceReference.User[] GetUsersByPublicIP(string publicIP)
        {
            return base.Channel.GetUsersByPublicIP(publicIP);
        }
        
        public System.Threading.Tasks.Task<UserCatalogServiceReference.User[]> GetUsersByPublicIPAsync(string publicIP)
        {
            return base.Channel.GetUsersByPublicIPAsync(publicIP);
        }
        
        public UserCatalogServiceReference.User[] GetByUsername(string username)
        {
            return base.Channel.GetByUsername(username);
        }
        
        public System.Threading.Tasks.Task<UserCatalogServiceReference.User[]> GetByUsernameAsync(string username)
        {
            return base.Channel.GetByUsernameAsync(username);
        }
        
        public UserCatalogServiceReference.User[] GetByUsernamePattern(string username)
        {
            return base.Channel.GetByUsernamePattern(username);
        }
        
        public System.Threading.Tasks.Task<UserCatalogServiceReference.User[]> GetByUsernamePatternAsync(string username)
        {
            return base.Channel.GetByUsernamePatternAsync(username);
        }
        
        public UserCatalogServiceReference.User[] GetUsersByDateEntry(string entryDate)
        {
            return base.Channel.GetUsersByDateEntry(entryDate);
        }
        
        public System.Threading.Tasks.Task<UserCatalogServiceReference.User[]> GetUsersByDateEntryAsync(string entryDate)
        {
            return base.Channel.GetUsersByDateEntryAsync(entryDate);
        }
        
        public UserCatalogServiceReference.User[] GetUsersOlderThanAge(int age)
        {
            return base.Channel.GetUsersOlderThanAge(age);
        }
        
        public System.Threading.Tasks.Task<UserCatalogServiceReference.User[]> GetUsersOlderThanAgeAsync(int age)
        {
            return base.Channel.GetUsersOlderThanAgeAsync(age);
        }
        
        public UserCatalogServiceReference.User[] GetUsersByAgeRange(int minimalAge, int maximalAge)
        {
            return base.Channel.GetUsersByAgeRange(minimalAge, maximalAge);
        }
        
        public System.Threading.Tasks.Task<UserCatalogServiceReference.User[]> GetUsersByAgeRangeAsync(int minimalAge, int maximalAge)
        {
            return base.Channel.GetUsersByAgeRangeAsync(minimalAge, maximalAge);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IUserCatalogDAO))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IUserCatalogDAO))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8733/Design_Time_Addresses/BirthServiceDAO_WCF/UserCatalogServic" +
                        "e/");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return UserCatalogDAOClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IUserCatalogDAO);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return UserCatalogDAOClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IUserCatalogDAO);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IUserCatalogDAO,
        }
    }
}