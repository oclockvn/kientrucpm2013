﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PhieuThuTienDTO", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class PhieuThuTienDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.ExtensionDataObject ExtensionData1Field;
        
        private int MaKhachHangField;
        
        private int SoTienThuField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NgayThuField;
        
        private int MaPhieuThuField;
        
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
        public DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.ExtensionDataObject ExtensionData1 {
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int MaKhachHang {
            get {
                return this.MaKhachHangField;
            }
            set {
                if ((this.MaKhachHangField.Equals(value) != true)) {
                    this.MaKhachHangField = value;
                    this.RaisePropertyChanged("MaKhachHang");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int SoTienThu {
            get {
                return this.SoTienThuField;
            }
            set {
                if ((this.SoTienThuField.Equals(value) != true)) {
                    this.SoTienThuField = value;
                    this.RaisePropertyChanged("SoTienThu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string NgayThu {
            get {
                return this.NgayThuField;
            }
            set {
                if ((object.ReferenceEquals(this.NgayThuField, value) != true)) {
                    this.NgayThuField = value;
                    this.RaisePropertyChanged("NgayThu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int MaPhieuThu {
            get {
                return this.MaPhieuThuField;
            }
            set {
                if ((this.MaPhieuThuField.Equals(value) != true)) {
                    this.MaPhieuThuField = value;
                    this.RaisePropertyChanged("MaPhieuThu");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsPhieuThuTienBLL.wsPhieuThuTienBLLSoap")]
    public interface wsPhieuThuTienBLLSoap {
        
        // CODEGEN: Generating message contract since element name getListPhieuThuTienResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getListPhieuThuTien", ReplyAction="*")]
        DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.getListPhieuThuTienResponse getListPhieuThuTien(DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.getListPhieuThuTienRequest request);
        
        // CODEGEN: Generating message contract since element name phieuDTO from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertPhieuThuTien", ReplyAction="*")]
        DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.insertPhieuThuTienResponse insertPhieuThuTien(DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.insertPhieuThuTienRequest request);
        
        // CODEGEN: Generating message contract since element name phieuDTO from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/deletePhieuThuTien", ReplyAction="*")]
        DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.deletePhieuThuTienResponse deletePhieuThuTien(DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.deletePhieuThuTienRequest request);
        
        // CODEGEN: Generating message contract since element name phieuDTO from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updatePhieuThuTien", ReplyAction="*")]
        DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.updatePhieuThuTienResponse updatePhieuThuTien(DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.updatePhieuThuTienRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getListPhieuThuTienRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getListPhieuThuTien", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.getListPhieuThuTienRequestBody Body;
        
        public getListPhieuThuTienRequest() {
        }
        
        public getListPhieuThuTienRequest(DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.getListPhieuThuTienRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class getListPhieuThuTienRequestBody {
        
        public getListPhieuThuTienRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getListPhieuThuTienResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getListPhieuThuTienResponse", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.getListPhieuThuTienResponseBody Body;
        
        public getListPhieuThuTienResponse() {
        }
        
        public getListPhieuThuTienResponse(DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.getListPhieuThuTienResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getListPhieuThuTienResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.PhieuThuTienDTO[] getListPhieuThuTienResult;
        
        public getListPhieuThuTienResponseBody() {
        }
        
        public getListPhieuThuTienResponseBody(DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.PhieuThuTienDTO[] getListPhieuThuTienResult) {
            this.getListPhieuThuTienResult = getListPhieuThuTienResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class insertPhieuThuTienRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="insertPhieuThuTien", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.insertPhieuThuTienRequestBody Body;
        
        public insertPhieuThuTienRequest() {
        }
        
        public insertPhieuThuTienRequest(DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.insertPhieuThuTienRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class insertPhieuThuTienRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.PhieuThuTienDTO phieuDTO;
        
        public insertPhieuThuTienRequestBody() {
        }
        
        public insertPhieuThuTienRequestBody(DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.PhieuThuTienDTO phieuDTO) {
            this.phieuDTO = phieuDTO;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class insertPhieuThuTienResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="insertPhieuThuTienResponse", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.insertPhieuThuTienResponseBody Body;
        
        public insertPhieuThuTienResponse() {
        }
        
        public insertPhieuThuTienResponse(DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.insertPhieuThuTienResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class insertPhieuThuTienResponseBody {
        
        public insertPhieuThuTienResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class deletePhieuThuTienRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="deletePhieuThuTien", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.deletePhieuThuTienRequestBody Body;
        
        public deletePhieuThuTienRequest() {
        }
        
        public deletePhieuThuTienRequest(DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.deletePhieuThuTienRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class deletePhieuThuTienRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.PhieuThuTienDTO phieuDTO;
        
        public deletePhieuThuTienRequestBody() {
        }
        
        public deletePhieuThuTienRequestBody(DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.PhieuThuTienDTO phieuDTO) {
            this.phieuDTO = phieuDTO;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class deletePhieuThuTienResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="deletePhieuThuTienResponse", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.deletePhieuThuTienResponseBody Body;
        
        public deletePhieuThuTienResponse() {
        }
        
        public deletePhieuThuTienResponse(DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.deletePhieuThuTienResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class deletePhieuThuTienResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool deletePhieuThuTienResult;
        
        public deletePhieuThuTienResponseBody() {
        }
        
        public deletePhieuThuTienResponseBody(bool deletePhieuThuTienResult) {
            this.deletePhieuThuTienResult = deletePhieuThuTienResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class updatePhieuThuTienRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="updatePhieuThuTien", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.updatePhieuThuTienRequestBody Body;
        
        public updatePhieuThuTienRequest() {
        }
        
        public updatePhieuThuTienRequest(DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.updatePhieuThuTienRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class updatePhieuThuTienRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.PhieuThuTienDTO phieuDTO;
        
        public updatePhieuThuTienRequestBody() {
        }
        
        public updatePhieuThuTienRequestBody(DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.PhieuThuTienDTO phieuDTO) {
            this.phieuDTO = phieuDTO;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class updatePhieuThuTienResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="updatePhieuThuTienResponse", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.updatePhieuThuTienResponseBody Body;
        
        public updatePhieuThuTienResponse() {
        }
        
        public updatePhieuThuTienResponse(DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.updatePhieuThuTienResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class updatePhieuThuTienResponseBody {
        
        public updatePhieuThuTienResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsPhieuThuTienBLLSoapChannel : DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.wsPhieuThuTienBLLSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsPhieuThuTienBLLSoapClient : System.ServiceModel.ClientBase<DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.wsPhieuThuTienBLLSoap>, DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.wsPhieuThuTienBLLSoap {
        
        public wsPhieuThuTienBLLSoapClient() {
        }
        
        public wsPhieuThuTienBLLSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsPhieuThuTienBLLSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsPhieuThuTienBLLSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsPhieuThuTienBLLSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.getListPhieuThuTienResponse DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.wsPhieuThuTienBLLSoap.getListPhieuThuTien(DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.getListPhieuThuTienRequest request) {
            return base.Channel.getListPhieuThuTien(request);
        }
        
        public DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.PhieuThuTienDTO[] getListPhieuThuTien() {
            DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.getListPhieuThuTienRequest inValue = new DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.getListPhieuThuTienRequest();
            inValue.Body = new DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.getListPhieuThuTienRequestBody();
            DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.getListPhieuThuTienResponse retVal = ((DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.wsPhieuThuTienBLLSoap)(this)).getListPhieuThuTien(inValue);
            return retVal.Body.getListPhieuThuTienResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.insertPhieuThuTienResponse DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.wsPhieuThuTienBLLSoap.insertPhieuThuTien(DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.insertPhieuThuTienRequest request) {
            return base.Channel.insertPhieuThuTien(request);
        }
        
        public void insertPhieuThuTien(DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.PhieuThuTienDTO phieuDTO) {
            DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.insertPhieuThuTienRequest inValue = new DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.insertPhieuThuTienRequest();
            inValue.Body = new DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.insertPhieuThuTienRequestBody();
            inValue.Body.phieuDTO = phieuDTO;
            DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.insertPhieuThuTienResponse retVal = ((DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.wsPhieuThuTienBLLSoap)(this)).insertPhieuThuTien(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.deletePhieuThuTienResponse DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.wsPhieuThuTienBLLSoap.deletePhieuThuTien(DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.deletePhieuThuTienRequest request) {
            return base.Channel.deletePhieuThuTien(request);
        }
        
        public bool deletePhieuThuTien(DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.PhieuThuTienDTO phieuDTO) {
            DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.deletePhieuThuTienRequest inValue = new DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.deletePhieuThuTienRequest();
            inValue.Body = new DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.deletePhieuThuTienRequestBody();
            inValue.Body.phieuDTO = phieuDTO;
            DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.deletePhieuThuTienResponse retVal = ((DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.wsPhieuThuTienBLLSoap)(this)).deletePhieuThuTien(inValue);
            return retVal.Body.deletePhieuThuTienResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.updatePhieuThuTienResponse DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.wsPhieuThuTienBLLSoap.updatePhieuThuTien(DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.updatePhieuThuTienRequest request) {
            return base.Channel.updatePhieuThuTien(request);
        }
        
        public void updatePhieuThuTien(DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.PhieuThuTienDTO phieuDTO) {
            DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.updatePhieuThuTienRequest inValue = new DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.updatePhieuThuTienRequest();
            inValue.Body = new DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.updatePhieuThuTienRequestBody();
            inValue.Body.phieuDTO = phieuDTO;
            DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.updatePhieuThuTienResponse retVal = ((DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL.wsPhieuThuTienBLLSoap)(this)).updatePhieuThuTien(inValue);
        }
    }
}
