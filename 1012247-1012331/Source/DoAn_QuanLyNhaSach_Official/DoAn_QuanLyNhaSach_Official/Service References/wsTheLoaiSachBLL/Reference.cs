﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TheLoaiSachDTO", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class TheLoaiSachDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.ExtensionDataObject ExtensionData1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenTheLoaiField;
        
        private int MaTheLoaiField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="ExtensionData", EmitDefaultValue=false)]
        public DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.ExtensionDataObject ExtensionData1 {
            get {
                return this.ExtensionData1Field;
            }
            set {
                if ((object.ReferenceEquals(this.ExtensionData1Field, value) != true)) {
                    this.ExtensionData1Field = value;
                    this.RaisePropertyChanged("ExtensionData1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string TenTheLoai {
            get {
                return this.TenTheLoaiField;
            }
            set {
                if ((object.ReferenceEquals(this.TenTheLoaiField, value) != true)) {
                    this.TenTheLoaiField = value;
                    this.RaisePropertyChanged("TenTheLoai");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int MaTheLoai {
            get {
                return this.MaTheLoaiField;
            }
            set {
                if ((this.MaTheLoaiField.Equals(value) != true)) {
                    this.MaTheLoaiField = value;
                    this.RaisePropertyChanged("MaTheLoai");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ExtensionDataObject", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class ExtensionDataObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsTheLoaiSachBLL.wsTheLoaiSachBLLSoap")]
    public interface wsTheLoaiSachBLLSoap {
        
        // CODEGEN: Generating message contract since element name getListTheLoaiSachResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getListTheLoaiSach", ReplyAction="*")]
        DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getListTheLoaiSachResponse getListTheLoaiSach(DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getListTheLoaiSachRequest request);
        
        // CODEGEN: Generating message contract since element name tentheloai from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getMaTheLoai", ReplyAction="*")]
        DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getMaTheLoaiResponse getMaTheLoai(DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getMaTheLoaiRequest request);
        
        // CODEGEN: Generating message contract since element name getTenTheLoaiResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getTenTheLoai", ReplyAction="*")]
        DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getTenTheLoaiResponse getTenTheLoai(DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getTenTheLoaiRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getListTheLoaiSachRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getListTheLoaiSach", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getListTheLoaiSachRequestBody Body;
        
        public getListTheLoaiSachRequest() {
        }
        
        public getListTheLoaiSachRequest(DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getListTheLoaiSachRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class getListTheLoaiSachRequestBody {
        
        public getListTheLoaiSachRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getListTheLoaiSachResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getListTheLoaiSachResponse", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getListTheLoaiSachResponseBody Body;
        
        public getListTheLoaiSachResponse() {
        }
        
        public getListTheLoaiSachResponse(DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getListTheLoaiSachResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getListTheLoaiSachResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.TheLoaiSachDTO[] getListTheLoaiSachResult;
        
        public getListTheLoaiSachResponseBody() {
        }
        
        public getListTheLoaiSachResponseBody(DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.TheLoaiSachDTO[] getListTheLoaiSachResult) {
            this.getListTheLoaiSachResult = getListTheLoaiSachResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getMaTheLoaiRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getMaTheLoai", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getMaTheLoaiRequestBody Body;
        
        public getMaTheLoaiRequest() {
        }
        
        public getMaTheLoaiRequest(DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getMaTheLoaiRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getMaTheLoaiRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string tentheloai;
        
        public getMaTheLoaiRequestBody() {
        }
        
        public getMaTheLoaiRequestBody(string tentheloai) {
            this.tentheloai = tentheloai;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getMaTheLoaiResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getMaTheLoaiResponse", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getMaTheLoaiResponseBody Body;
        
        public getMaTheLoaiResponse() {
        }
        
        public getMaTheLoaiResponse(DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getMaTheLoaiResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getMaTheLoaiResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int getMaTheLoaiResult;
        
        public getMaTheLoaiResponseBody() {
        }
        
        public getMaTheLoaiResponseBody(int getMaTheLoaiResult) {
            this.getMaTheLoaiResult = getMaTheLoaiResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getTenTheLoaiRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getTenTheLoai", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getTenTheLoaiRequestBody Body;
        
        public getTenTheLoaiRequest() {
        }
        
        public getTenTheLoaiRequest(DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getTenTheLoaiRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getTenTheLoaiRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int matheloai;
        
        public getTenTheLoaiRequestBody() {
        }
        
        public getTenTheLoaiRequestBody(int matheloai) {
            this.matheloai = matheloai;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getTenTheLoaiResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getTenTheLoaiResponse", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getTenTheLoaiResponseBody Body;
        
        public getTenTheLoaiResponse() {
        }
        
        public getTenTheLoaiResponse(DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getTenTheLoaiResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getTenTheLoaiResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string getTenTheLoaiResult;
        
        public getTenTheLoaiResponseBody() {
        }
        
        public getTenTheLoaiResponseBody(string getTenTheLoaiResult) {
            this.getTenTheLoaiResult = getTenTheLoaiResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsTheLoaiSachBLLSoapChannel : DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.wsTheLoaiSachBLLSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsTheLoaiSachBLLSoapClient : System.ServiceModel.ClientBase<DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.wsTheLoaiSachBLLSoap>, DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.wsTheLoaiSachBLLSoap {
        
        public wsTheLoaiSachBLLSoapClient() {
        }
        
        public wsTheLoaiSachBLLSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsTheLoaiSachBLLSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsTheLoaiSachBLLSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsTheLoaiSachBLLSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getListTheLoaiSachResponse DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.wsTheLoaiSachBLLSoap.getListTheLoaiSach(DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getListTheLoaiSachRequest request) {
            return base.Channel.getListTheLoaiSach(request);
        }
        
        public DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.TheLoaiSachDTO[] getListTheLoaiSach() {
            DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getListTheLoaiSachRequest inValue = new DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getListTheLoaiSachRequest();
            inValue.Body = new DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getListTheLoaiSachRequestBody();
            DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getListTheLoaiSachResponse retVal = ((DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.wsTheLoaiSachBLLSoap)(this)).getListTheLoaiSach(inValue);
            return retVal.Body.getListTheLoaiSachResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getMaTheLoaiResponse DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.wsTheLoaiSachBLLSoap.getMaTheLoai(DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getMaTheLoaiRequest request) {
            return base.Channel.getMaTheLoai(request);
        }
        
        public int getMaTheLoai(string tentheloai) {
            DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getMaTheLoaiRequest inValue = new DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getMaTheLoaiRequest();
            inValue.Body = new DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getMaTheLoaiRequestBody();
            inValue.Body.tentheloai = tentheloai;
            DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getMaTheLoaiResponse retVal = ((DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.wsTheLoaiSachBLLSoap)(this)).getMaTheLoai(inValue);
            return retVal.Body.getMaTheLoaiResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getTenTheLoaiResponse DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.wsTheLoaiSachBLLSoap.getTenTheLoai(DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getTenTheLoaiRequest request) {
            return base.Channel.getTenTheLoai(request);
        }
        
        public string getTenTheLoai(int matheloai) {
            DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getTenTheLoaiRequest inValue = new DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getTenTheLoaiRequest();
            inValue.Body = new DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getTenTheLoaiRequestBody();
            inValue.Body.matheloai = matheloai;
            DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.getTenTheLoaiResponse retVal = ((DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL.wsTheLoaiSachBLLSoap)(this)).getTenTheLoai(inValue);
            return retVal.Body.getTenTheLoaiResult;
        }
    }
}
