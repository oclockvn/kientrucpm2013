﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PhieuNhapSachDTO", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class PhieuNhapSachDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int TongSoLuongNhapField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NgayNhapField;
        
        private int MaChiTietPhieuNhapSachField;
        
        private int MaPhieuNhapSachField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int TongSoLuongNhap {
            get {
                return this.TongSoLuongNhapField;
            }
            set {
                if ((this.TongSoLuongNhapField.Equals(value) != true)) {
                    this.TongSoLuongNhapField = value;
                    this.RaisePropertyChanged("TongSoLuongNhap");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string NgayNhap {
            get {
                return this.NgayNhapField;
            }
            set {
                if ((object.ReferenceEquals(this.NgayNhapField, value) != true)) {
                    this.NgayNhapField = value;
                    this.RaisePropertyChanged("NgayNhap");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int MaChiTietPhieuNhapSach {
            get {
                return this.MaChiTietPhieuNhapSachField;
            }
            set {
                if ((this.MaChiTietPhieuNhapSachField.Equals(value) != true)) {
                    this.MaChiTietPhieuNhapSachField = value;
                    this.RaisePropertyChanged("MaChiTietPhieuNhapSach");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int MaPhieuNhapSach {
            get {
                return this.MaPhieuNhapSachField;
            }
            set {
                if ((this.MaPhieuNhapSachField.Equals(value) != true)) {
                    this.MaPhieuNhapSachField = value;
                    this.RaisePropertyChanged("MaPhieuNhapSach");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsPhieuNhapSachDAL.wsPhieuNhapSachSoap")]
    public interface wsPhieuNhapSachSoap {
        
        // CODEGEN: Generating message contract since element name phieuDTO from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertPhieuNhapSach", ReplyAction="*")]
        DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.insertPhieuNhapSachResponse insertPhieuNhapSach(DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.insertPhieuNhapSachRequest request);
        
        // CODEGEN: Generating message contract since element name phieuDTO from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/deletePhieuNhapSach", ReplyAction="*")]
        DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.deletePhieuNhapSachResponse deletePhieuNhapSach(DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.deletePhieuNhapSachRequest request);
        
        // CODEGEN: Generating message contract since element name phieuDTO from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updatePhieuNhapSach", ReplyAction="*")]
        DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.updatePhieuNhapSachResponse updatePhieuNhapSach(DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.updatePhieuNhapSachRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class insertPhieuNhapSachRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="insertPhieuNhapSach", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.insertPhieuNhapSachRequestBody Body;
        
        public insertPhieuNhapSachRequest() {
        }
        
        public insertPhieuNhapSachRequest(DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.insertPhieuNhapSachRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class insertPhieuNhapSachRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.PhieuNhapSachDTO phieuDTO;
        
        public insertPhieuNhapSachRequestBody() {
        }
        
        public insertPhieuNhapSachRequestBody(DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.PhieuNhapSachDTO phieuDTO) {
            this.phieuDTO = phieuDTO;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class insertPhieuNhapSachResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="insertPhieuNhapSachResponse", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.insertPhieuNhapSachResponseBody Body;
        
        public insertPhieuNhapSachResponse() {
        }
        
        public insertPhieuNhapSachResponse(DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.insertPhieuNhapSachResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class insertPhieuNhapSachResponseBody {
        
        public insertPhieuNhapSachResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class deletePhieuNhapSachRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="deletePhieuNhapSach", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.deletePhieuNhapSachRequestBody Body;
        
        public deletePhieuNhapSachRequest() {
        }
        
        public deletePhieuNhapSachRequest(DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.deletePhieuNhapSachRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class deletePhieuNhapSachRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.PhieuNhapSachDTO phieuDTO;
        
        public deletePhieuNhapSachRequestBody() {
        }
        
        public deletePhieuNhapSachRequestBody(DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.PhieuNhapSachDTO phieuDTO) {
            this.phieuDTO = phieuDTO;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class deletePhieuNhapSachResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="deletePhieuNhapSachResponse", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.deletePhieuNhapSachResponseBody Body;
        
        public deletePhieuNhapSachResponse() {
        }
        
        public deletePhieuNhapSachResponse(DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.deletePhieuNhapSachResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class deletePhieuNhapSachResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool deletePhieuNhapSachResult;
        
        public deletePhieuNhapSachResponseBody() {
        }
        
        public deletePhieuNhapSachResponseBody(bool deletePhieuNhapSachResult) {
            this.deletePhieuNhapSachResult = deletePhieuNhapSachResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class updatePhieuNhapSachRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="updatePhieuNhapSach", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.updatePhieuNhapSachRequestBody Body;
        
        public updatePhieuNhapSachRequest() {
        }
        
        public updatePhieuNhapSachRequest(DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.updatePhieuNhapSachRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class updatePhieuNhapSachRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.PhieuNhapSachDTO phieuDTO;
        
        public updatePhieuNhapSachRequestBody() {
        }
        
        public updatePhieuNhapSachRequestBody(DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.PhieuNhapSachDTO phieuDTO) {
            this.phieuDTO = phieuDTO;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class updatePhieuNhapSachResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="updatePhieuNhapSachResponse", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.updatePhieuNhapSachResponseBody Body;
        
        public updatePhieuNhapSachResponse() {
        }
        
        public updatePhieuNhapSachResponse(DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.updatePhieuNhapSachResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class updatePhieuNhapSachResponseBody {
        
        public updatePhieuNhapSachResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsPhieuNhapSachSoapChannel : DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.wsPhieuNhapSachSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsPhieuNhapSachSoapClient : System.ServiceModel.ClientBase<DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.wsPhieuNhapSachSoap>, DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.wsPhieuNhapSachSoap {
        
        public wsPhieuNhapSachSoapClient() {
        }
        
        public wsPhieuNhapSachSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsPhieuNhapSachSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsPhieuNhapSachSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsPhieuNhapSachSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.insertPhieuNhapSachResponse DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.wsPhieuNhapSachSoap.insertPhieuNhapSach(DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.insertPhieuNhapSachRequest request) {
            return base.Channel.insertPhieuNhapSach(request);
        }
        
        public void insertPhieuNhapSach(DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.PhieuNhapSachDTO phieuDTO) {
            DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.insertPhieuNhapSachRequest inValue = new DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.insertPhieuNhapSachRequest();
            inValue.Body = new DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.insertPhieuNhapSachRequestBody();
            inValue.Body.phieuDTO = phieuDTO;
            DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.insertPhieuNhapSachResponse retVal = ((DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.wsPhieuNhapSachSoap)(this)).insertPhieuNhapSach(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.deletePhieuNhapSachResponse DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.wsPhieuNhapSachSoap.deletePhieuNhapSach(DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.deletePhieuNhapSachRequest request) {
            return base.Channel.deletePhieuNhapSach(request);
        }
        
        public bool deletePhieuNhapSach(DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.PhieuNhapSachDTO phieuDTO) {
            DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.deletePhieuNhapSachRequest inValue = new DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.deletePhieuNhapSachRequest();
            inValue.Body = new DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.deletePhieuNhapSachRequestBody();
            inValue.Body.phieuDTO = phieuDTO;
            DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.deletePhieuNhapSachResponse retVal = ((DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.wsPhieuNhapSachSoap)(this)).deletePhieuNhapSach(inValue);
            return retVal.Body.deletePhieuNhapSachResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.updatePhieuNhapSachResponse DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.wsPhieuNhapSachSoap.updatePhieuNhapSach(DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.updatePhieuNhapSachRequest request) {
            return base.Channel.updatePhieuNhapSach(request);
        }
        
        public void updatePhieuNhapSach(DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.PhieuNhapSachDTO phieuDTO) {
            DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.updatePhieuNhapSachRequest inValue = new DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.updatePhieuNhapSachRequest();
            inValue.Body = new DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.updatePhieuNhapSachRequestBody();
            inValue.Body.phieuDTO = phieuDTO;
            DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.updatePhieuNhapSachResponse retVal = ((DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL.wsPhieuNhapSachSoap)(this)).updatePhieuNhapSach(inValue);
        }
    }
}
