﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HoaDonBanSachDTO", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class HoaDonBanSachDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.ExtensionDataObject ExtensionData1Field;
        
        private int TongTienField;
        
        private int MaChiTietHoaDonField;
        
        private int MaKhachHangField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NgayLapHoaDonField;
        
        private int MaHoaDonField;
        
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
        public DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.ExtensionDataObject ExtensionData1 {
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
        public int TongTien {
            get {
                return this.TongTienField;
            }
            set {
                if ((this.TongTienField.Equals(value) != true)) {
                    this.TongTienField = value;
                    this.RaisePropertyChanged("TongTien");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int MaChiTietHoaDon {
            get {
                return this.MaChiTietHoaDonField;
            }
            set {
                if ((this.MaChiTietHoaDonField.Equals(value) != true)) {
                    this.MaChiTietHoaDonField = value;
                    this.RaisePropertyChanged("MaChiTietHoaDon");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string NgayLapHoaDon {
            get {
                return this.NgayLapHoaDonField;
            }
            set {
                if ((object.ReferenceEquals(this.NgayLapHoaDonField, value) != true)) {
                    this.NgayLapHoaDonField = value;
                    this.RaisePropertyChanged("NgayLapHoaDon");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public int MaHoaDon {
            get {
                return this.MaHoaDonField;
            }
            set {
                if ((this.MaHoaDonField.Equals(value) != true)) {
                    this.MaHoaDonField = value;
                    this.RaisePropertyChanged("MaHoaDon");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsHoaDonBanSachBLL.wsHoaDonBanSachBLLSoap")]
    public interface wsHoaDonBanSachBLLSoap {
        
        // CODEGEN: Generating message contract since element name hoadonDTO from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertHoaDonBanSach", ReplyAction="*")]
        DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.insertHoaDonBanSachResponse insertHoaDonBanSach(DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.insertHoaDonBanSachRequest request);
        
        // CODEGEN: Generating message contract since element name hoadonDTO from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/addNewHoaDonBanSach", ReplyAction="*")]
        DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.addNewHoaDonBanSachResponse addNewHoaDonBanSach(DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.addNewHoaDonBanSachRequest request);
        
        // CODEGEN: Generating message contract since element name hoadonDTO from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updateHoaDonBanSach", ReplyAction="*")]
        DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.updateHoaDonBanSachResponse updateHoaDonBanSach(DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.updateHoaDonBanSachRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getTongTienHoaDonBanSach", ReplyAction="*")]
        int getTongTienHoaDonBanSach();
        
        // CODEGEN: Generating message contract since element name deleteAllTableHoaDonBanSachResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/deleteAllTableHoaDonBanSach", ReplyAction="*")]
        DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.deleteAllTableHoaDonBanSachResponse deleteAllTableHoaDonBanSach(DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.deleteAllTableHoaDonBanSachRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class insertHoaDonBanSachRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="insertHoaDonBanSach", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.insertHoaDonBanSachRequestBody Body;
        
        public insertHoaDonBanSachRequest() {
        }
        
        public insertHoaDonBanSachRequest(DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.insertHoaDonBanSachRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class insertHoaDonBanSachRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.HoaDonBanSachDTO hoadonDTO;
        
        public insertHoaDonBanSachRequestBody() {
        }
        
        public insertHoaDonBanSachRequestBody(DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.HoaDonBanSachDTO hoadonDTO) {
            this.hoadonDTO = hoadonDTO;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class insertHoaDonBanSachResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="insertHoaDonBanSachResponse", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.insertHoaDonBanSachResponseBody Body;
        
        public insertHoaDonBanSachResponse() {
        }
        
        public insertHoaDonBanSachResponse(DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.insertHoaDonBanSachResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class insertHoaDonBanSachResponseBody {
        
        public insertHoaDonBanSachResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class addNewHoaDonBanSachRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="addNewHoaDonBanSach", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.addNewHoaDonBanSachRequestBody Body;
        
        public addNewHoaDonBanSachRequest() {
        }
        
        public addNewHoaDonBanSachRequest(DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.addNewHoaDonBanSachRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class addNewHoaDonBanSachRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.HoaDonBanSachDTO hoadonDTO;
        
        public addNewHoaDonBanSachRequestBody() {
        }
        
        public addNewHoaDonBanSachRequestBody(DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.HoaDonBanSachDTO hoadonDTO) {
            this.hoadonDTO = hoadonDTO;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class addNewHoaDonBanSachResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="addNewHoaDonBanSachResponse", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.addNewHoaDonBanSachResponseBody Body;
        
        public addNewHoaDonBanSachResponse() {
        }
        
        public addNewHoaDonBanSachResponse(DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.addNewHoaDonBanSachResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class addNewHoaDonBanSachResponseBody {
        
        public addNewHoaDonBanSachResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class updateHoaDonBanSachRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="updateHoaDonBanSach", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.updateHoaDonBanSachRequestBody Body;
        
        public updateHoaDonBanSachRequest() {
        }
        
        public updateHoaDonBanSachRequest(DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.updateHoaDonBanSachRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class updateHoaDonBanSachRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.HoaDonBanSachDTO hoadonDTO;
        
        public updateHoaDonBanSachRequestBody() {
        }
        
        public updateHoaDonBanSachRequestBody(DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.HoaDonBanSachDTO hoadonDTO) {
            this.hoadonDTO = hoadonDTO;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class updateHoaDonBanSachResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="updateHoaDonBanSachResponse", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.updateHoaDonBanSachResponseBody Body;
        
        public updateHoaDonBanSachResponse() {
        }
        
        public updateHoaDonBanSachResponse(DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.updateHoaDonBanSachResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class updateHoaDonBanSachResponseBody {
        
        public updateHoaDonBanSachResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class deleteAllTableHoaDonBanSachRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="deleteAllTableHoaDonBanSach", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.deleteAllTableHoaDonBanSachRequestBody Body;
        
        public deleteAllTableHoaDonBanSachRequest() {
        }
        
        public deleteAllTableHoaDonBanSachRequest(DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.deleteAllTableHoaDonBanSachRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class deleteAllTableHoaDonBanSachRequestBody {
        
        public deleteAllTableHoaDonBanSachRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class deleteAllTableHoaDonBanSachResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="deleteAllTableHoaDonBanSachResponse", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.deleteAllTableHoaDonBanSachResponseBody Body;
        
        public deleteAllTableHoaDonBanSachResponse() {
        }
        
        public deleteAllTableHoaDonBanSachResponse(DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.deleteAllTableHoaDonBanSachResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class deleteAllTableHoaDonBanSachResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.HoaDonBanSachDTO[] deleteAllTableHoaDonBanSachResult;
        
        public deleteAllTableHoaDonBanSachResponseBody() {
        }
        
        public deleteAllTableHoaDonBanSachResponseBody(DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.HoaDonBanSachDTO[] deleteAllTableHoaDonBanSachResult) {
            this.deleteAllTableHoaDonBanSachResult = deleteAllTableHoaDonBanSachResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsHoaDonBanSachBLLSoapChannel : DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.wsHoaDonBanSachBLLSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsHoaDonBanSachBLLSoapClient : System.ServiceModel.ClientBase<DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.wsHoaDonBanSachBLLSoap>, DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.wsHoaDonBanSachBLLSoap {
        
        public wsHoaDonBanSachBLLSoapClient() {
        }
        
        public wsHoaDonBanSachBLLSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsHoaDonBanSachBLLSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsHoaDonBanSachBLLSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsHoaDonBanSachBLLSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.insertHoaDonBanSachResponse DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.wsHoaDonBanSachBLLSoap.insertHoaDonBanSach(DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.insertHoaDonBanSachRequest request) {
            return base.Channel.insertHoaDonBanSach(request);
        }
        
        public void insertHoaDonBanSach(DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.HoaDonBanSachDTO hoadonDTO) {
            DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.insertHoaDonBanSachRequest inValue = new DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.insertHoaDonBanSachRequest();
            inValue.Body = new DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.insertHoaDonBanSachRequestBody();
            inValue.Body.hoadonDTO = hoadonDTO;
            DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.insertHoaDonBanSachResponse retVal = ((DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.wsHoaDonBanSachBLLSoap)(this)).insertHoaDonBanSach(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.addNewHoaDonBanSachResponse DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.wsHoaDonBanSachBLLSoap.addNewHoaDonBanSach(DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.addNewHoaDonBanSachRequest request) {
            return base.Channel.addNewHoaDonBanSach(request);
        }
        
        public void addNewHoaDonBanSach(DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.HoaDonBanSachDTO hoadonDTO) {
            DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.addNewHoaDonBanSachRequest inValue = new DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.addNewHoaDonBanSachRequest();
            inValue.Body = new DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.addNewHoaDonBanSachRequestBody();
            inValue.Body.hoadonDTO = hoadonDTO;
            DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.addNewHoaDonBanSachResponse retVal = ((DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.wsHoaDonBanSachBLLSoap)(this)).addNewHoaDonBanSach(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.updateHoaDonBanSachResponse DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.wsHoaDonBanSachBLLSoap.updateHoaDonBanSach(DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.updateHoaDonBanSachRequest request) {
            return base.Channel.updateHoaDonBanSach(request);
        }
        
        public void updateHoaDonBanSach(DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.HoaDonBanSachDTO hoadonDTO) {
            DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.updateHoaDonBanSachRequest inValue = new DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.updateHoaDonBanSachRequest();
            inValue.Body = new DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.updateHoaDonBanSachRequestBody();
            inValue.Body.hoadonDTO = hoadonDTO;
            DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.updateHoaDonBanSachResponse retVal = ((DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.wsHoaDonBanSachBLLSoap)(this)).updateHoaDonBanSach(inValue);
        }
        
        public int getTongTienHoaDonBanSach() {
            return base.Channel.getTongTienHoaDonBanSach();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.deleteAllTableHoaDonBanSachResponse DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.wsHoaDonBanSachBLLSoap.deleteAllTableHoaDonBanSach(DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.deleteAllTableHoaDonBanSachRequest request) {
            return base.Channel.deleteAllTableHoaDonBanSach(request);
        }
        
        public DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.HoaDonBanSachDTO[] deleteAllTableHoaDonBanSach() {
            DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.deleteAllTableHoaDonBanSachRequest inValue = new DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.deleteAllTableHoaDonBanSachRequest();
            inValue.Body = new DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.deleteAllTableHoaDonBanSachRequestBody();
            DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.deleteAllTableHoaDonBanSachResponse retVal = ((DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL.wsHoaDonBanSachBLLSoap)(this)).deleteAllTableHoaDonBanSach(inValue);
            return retVal.Body.deleteAllTableHoaDonBanSachResult;
        }
    }
}
