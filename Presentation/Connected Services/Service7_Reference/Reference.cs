﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Presentation.Service7_Reference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuditDTO", Namespace="http://schemas.datacontract.org/2004/07/CommunicationApp")]
    [System.SerializableAttribute()]
    public partial class AuditDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BrandField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CardIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CostField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstLastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Id_CustomerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsAdminField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PlateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SecondLastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ServiceTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Vehicle_IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int YearField;
        
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
        public string Brand {
            get {
                return this.BrandField;
            }
            set {
                if ((object.ReferenceEquals(this.BrandField, value) != true)) {
                    this.BrandField = value;
                    this.RaisePropertyChanged("Brand");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CardId {
            get {
                return this.CardIdField;
            }
            set {
                if ((this.CardIdField.Equals(value) != true)) {
                    this.CardIdField = value;
                    this.RaisePropertyChanged("CardId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Cost {
            get {
                return this.CostField;
            }
            set {
                if ((this.CostField.Equals(value) != true)) {
                    this.CostField = value;
                    this.RaisePropertyChanged("Cost");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstLastName {
            get {
                return this.FirstLastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstLastNameField, value) != true)) {
                    this.FirstLastNameField = value;
                    this.RaisePropertyChanged("FirstLastName");
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
        public int Id_Customer {
            get {
                return this.Id_CustomerField;
            }
            set {
                if ((this.Id_CustomerField.Equals(value) != true)) {
                    this.Id_CustomerField = value;
                    this.RaisePropertyChanged("Id_Customer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsAdmin {
            get {
                return this.IsAdminField;
            }
            set {
                if ((this.IsAdminField.Equals(value) != true)) {
                    this.IsAdminField = value;
                    this.RaisePropertyChanged("IsAdmin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Model {
            get {
                return this.ModelField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelField, value) != true)) {
                    this.ModelField = value;
                    this.RaisePropertyChanged("Model");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
        public int Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((this.PhoneField.Equals(value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Plate {
            get {
                return this.PlateField;
            }
            set {
                if ((object.ReferenceEquals(this.PlateField, value) != true)) {
                    this.PlateField = value;
                    this.RaisePropertyChanged("Plate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SecondLastName {
            get {
                return this.SecondLastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SecondLastNameField, value) != true)) {
                    this.SecondLastNameField = value;
                    this.RaisePropertyChanged("SecondLastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ServiceType {
            get {
                return this.ServiceTypeField;
            }
            set {
                if ((this.ServiceTypeField.Equals(value) != true)) {
                    this.ServiceTypeField = value;
                    this.RaisePropertyChanged("ServiceType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Vehicle_Id {
            get {
                return this.Vehicle_IdField;
            }
            set {
                if ((this.Vehicle_IdField.Equals(value) != true)) {
                    this.Vehicle_IdField = value;
                    this.RaisePropertyChanged("Vehicle_Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Year {
            get {
                return this.YearField;
            }
            set {
                if ((this.YearField.Equals(value) != true)) {
                    this.YearField = value;
                    this.RaisePropertyChanged("Year");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AuditList", Namespace="http://schemas.datacontract.org/2004/07/CommunicationApp")]
    [System.SerializableAttribute()]
    public partial class AuditList : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Presentation.Service7_Reference.AuditDTO[] listsField;
        
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
        public Presentation.Service7_Reference.AuditDTO[] lists {
            get {
                return this.listsField;
            }
            set {
                if ((object.ReferenceEquals(this.listsField, value) != true)) {
                    this.listsField = value;
                    this.RaisePropertyChanged("lists");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Service7_Reference.IService7")]
    public interface IService7 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService7/GetAuditId", ReplyAction="http://tempuri.org/IService7/GetAuditIdResponse")]
        Presentation.Service7_Reference.AuditDTO GetAuditId(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService7/GetAuditId", ReplyAction="http://tempuri.org/IService7/GetAuditIdResponse")]
        System.Threading.Tasks.Task<Presentation.Service7_Reference.AuditDTO> GetAuditIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService7/InsertAudit", ReplyAction="http://tempuri.org/IService7/InsertAuditResponse")]
        void InsertAudit(Presentation.Service7_Reference.AuditDTO audit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService7/InsertAudit", ReplyAction="http://tempuri.org/IService7/InsertAuditResponse")]
        System.Threading.Tasks.Task InsertAuditAsync(Presentation.Service7_Reference.AuditDTO audit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService7/DeleteAudit", ReplyAction="http://tempuri.org/IService7/DeleteAuditResponse")]
        void DeleteAudit(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService7/DeleteAudit", ReplyAction="http://tempuri.org/IService7/DeleteAuditResponse")]
        System.Threading.Tasks.Task DeleteAuditAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService7/ModifyAudit", ReplyAction="http://tempuri.org/IService7/ModifyAuditResponse")]
        void ModifyAudit(Presentation.Service7_Reference.AuditDTO audit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService7/ModifyAudit", ReplyAction="http://tempuri.org/IService7/ModifyAuditResponse")]
        System.Threading.Tasks.Task ModifyAuditAsync(Presentation.Service7_Reference.AuditDTO audit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService7/GetAllAudit", ReplyAction="http://tempuri.org/IService7/GetAllAuditResponse")]
        Presentation.Service7_Reference.AuditList GetAllAudit();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService7/GetAllAudit", ReplyAction="http://tempuri.org/IService7/GetAllAuditResponse")]
        System.Threading.Tasks.Task<Presentation.Service7_Reference.AuditList> GetAllAuditAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService7Channel : Presentation.Service7_Reference.IService7, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service7Client : System.ServiceModel.ClientBase<Presentation.Service7_Reference.IService7>, Presentation.Service7_Reference.IService7 {
        
        public Service7Client() {
        }
        
        public Service7Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service7Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service7Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service7Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Presentation.Service7_Reference.AuditDTO GetAuditId(int id) {
            return base.Channel.GetAuditId(id);
        }
        
        public System.Threading.Tasks.Task<Presentation.Service7_Reference.AuditDTO> GetAuditIdAsync(int id) {
            return base.Channel.GetAuditIdAsync(id);
        }
        
        public void InsertAudit(Presentation.Service7_Reference.AuditDTO audit) {
            base.Channel.InsertAudit(audit);
        }
        
        public System.Threading.Tasks.Task InsertAuditAsync(Presentation.Service7_Reference.AuditDTO audit) {
            return base.Channel.InsertAuditAsync(audit);
        }
        
        public void DeleteAudit(int id) {
            base.Channel.DeleteAudit(id);
        }
        
        public System.Threading.Tasks.Task DeleteAuditAsync(int id) {
            return base.Channel.DeleteAuditAsync(id);
        }
        
        public void ModifyAudit(Presentation.Service7_Reference.AuditDTO audit) {
            base.Channel.ModifyAudit(audit);
        }
        
        public System.Threading.Tasks.Task ModifyAuditAsync(Presentation.Service7_Reference.AuditDTO audit) {
            return base.Channel.ModifyAuditAsync(audit);
        }
        
        public Presentation.Service7_Reference.AuditList GetAllAudit() {
            return base.Channel.GetAllAudit();
        }
        
        public System.Threading.Tasks.Task<Presentation.Service7_Reference.AuditList> GetAllAuditAsync() {
            return base.Channel.GetAllAuditAsync();
        }
    }
}