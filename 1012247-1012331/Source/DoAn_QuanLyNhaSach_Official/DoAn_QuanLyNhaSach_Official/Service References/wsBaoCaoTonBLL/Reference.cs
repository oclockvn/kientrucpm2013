﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaoCaoTonDTO", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class BaoCaoTonDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.ExtensionDataObject ExtensionData1Field;
        
        private int TonCuoiField;
        
        private int PhatSinhField;
        
        private int TonDauField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MaSachField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ThangField;
        
        private int MaBaoCaoTonField;
        
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
        public DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.ExtensionDataObject ExtensionData1 {
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
        public int TonCuoi {
            get {
                return this.TonCuoiField;
            }
            set {
                if ((this.TonCuoiField.Equals(value) != true)) {
                    this.TonCuoiField = value;
                    this.RaisePropertyChanged("TonCuoi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int PhatSinh {
            get {
                return this.PhatSinhField;
            }
            set {
                if ((this.PhatSinhField.Equals(value) != true)) {
                    this.PhatSinhField = value;
                    this.RaisePropertyChanged("PhatSinh");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int TonDau {
            get {
                return this.TonDauField;
            }
            set {
                if ((this.TonDauField.Equals(value) != true)) {
                    this.TonDauField = value;
                    this.RaisePropertyChanged("TonDau");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string MaSach {
            get {
                return this.MaSachField;
            }
            set {
                if ((object.ReferenceEquals(this.MaSachField, value) != true)) {
                    this.MaSachField = value;
                    this.RaisePropertyChanged("MaSach");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Thang {
            get {
                return this.ThangField;
            }
            set {
                if ((object.ReferenceEquals(this.ThangField, value) != true)) {
                    this.ThangField = value;
                    this.RaisePropertyChanged("Thang");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public int MaBaoCaoTon {
            get {
                return this.MaBaoCaoTonField;
            }
            set {
                if ((this.MaBaoCaoTonField.Equals(value) != true)) {
                    this.MaBaoCaoTonField = value;
                    this.RaisePropertyChanged("MaBaoCaoTon");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsBaoCaoTonBLL.wsBaoCaoTonBLLSoap")]
    public interface wsBaoCaoTonBLLSoap {
        
        // CODEGEN: Generating message contract since element name getListBaoCaoTonResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getListBaoCaoTon", ReplyAction="*")]
        DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.getListBaoCaoTonResponse getListBaoCaoTon(DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.getListBaoCaoTonRequest request);
        
        // CODEGEN: Generating message contract since element name baocaoDTO from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertBaoCaoTon", ReplyAction="*")]
        DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.insertBaoCaoTonResponse insertBaoCaoTon(DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.insertBaoCaoTonRequest request);
        
        // CODEGEN: Generating message contract since element name baocaoDTO from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/deleteBaoCaoTon", ReplyAction="*")]
        DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.deleteBaoCaoTonResponse deleteBaoCaoTon(DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.deleteBaoCaoTonRequest request);
        
        // CODEGEN: Generating message contract since element name baocaoDTO from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updateBaoCaoTon", ReplyAction="*")]
        DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.updateBaoCaoTonResponse updateBaoCaoTon(DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.updateBaoCaoTonRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getListBaoCaoTonRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getListBaoCaoTon", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.getListBaoCaoTonRequestBody Body;
        
        public getListBaoCaoTonRequest() {
        }
        
        public getListBaoCaoTonRequest(DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.getListBaoCaoTonRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class getListBaoCaoTonRequestBody {
        
        public getListBaoCaoTonRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getListBaoCaoTonResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getListBaoCaoTonResponse", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.getListBaoCaoTonResponseBody Body;
        
        public getListBaoCaoTonResponse() {
        }
        
        public getListBaoCaoTonResponse(DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.getListBaoCaoTonResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getListBaoCaoTonResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.BaoCaoTonDTO[] getListBaoCaoTonResult;
        
        public getListBaoCaoTonResponseBody() {
        }
        
        public getListBaoCaoTonResponseBody(DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.BaoCaoTonDTO[] getListBaoCaoTonResult) {
            this.getListBaoCaoTonResult = getListBaoCaoTonResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class insertBaoCaoTonRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="insertBaoCaoTon", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.insertBaoCaoTonRequestBody Body;
        
        public insertBaoCaoTonRequest() {
        }
        
        public insertBaoCaoTonRequest(DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.insertBaoCaoTonRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class insertBaoCaoTonRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.BaoCaoTonDTO baocaoDTO;
        
        public insertBaoCaoTonRequestBody() {
        }
        
        public insertBaoCaoTonRequestBody(DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.BaoCaoTonDTO baocaoDTO) {
            this.baocaoDTO = baocaoDTO;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class insertBaoCaoTonResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="insertBaoCaoTonResponse", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.insertBaoCaoTonResponseBody Body;
        
        public insertBaoCaoTonResponse() {
        }
        
        public insertBaoCaoTonResponse(DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.insertBaoCaoTonResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class insertBaoCaoTonResponseBody {
        
        public insertBaoCaoTonResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class deleteBaoCaoTonRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="deleteBaoCaoTon", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.deleteBaoCaoTonRequestBody Body;
        
        public deleteBaoCaoTonRequest() {
        }
        
        public deleteBaoCaoTonRequest(DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.deleteBaoCaoTonRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class deleteBaoCaoTonRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.BaoCaoTonDTO baocaoDTO;
        
        public deleteBaoCaoTonRequestBody() {
        }
        
        public deleteBaoCaoTonRequestBody(DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.BaoCaoTonDTO baocaoDTO) {
            this.baocaoDTO = baocaoDTO;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class deleteBaoCaoTonResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="deleteBaoCaoTonResponse", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.deleteBaoCaoTonResponseBody Body;
        
        public deleteBaoCaoTonResponse() {
        }
        
        public deleteBaoCaoTonResponse(DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.deleteBaoCaoTonResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class deleteBaoCaoTonResponseBody {
        
        public deleteBaoCaoTonResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class updateBaoCaoTonRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="updateBaoCaoTon", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.updateBaoCaoTonRequestBody Body;
        
        public updateBaoCaoTonRequest() {
        }
        
        public updateBaoCaoTonRequest(DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.updateBaoCaoTonRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class updateBaoCaoTonRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.BaoCaoTonDTO baocaoDTO;
        
        public updateBaoCaoTonRequestBody() {
        }
        
        public updateBaoCaoTonRequestBody(DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.BaoCaoTonDTO baocaoDTO) {
            this.baocaoDTO = baocaoDTO;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class updateBaoCaoTonResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="updateBaoCaoTonResponse", Namespace="http://tempuri.org/", Order=0)]
        public DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.updateBaoCaoTonResponseBody Body;
        
        public updateBaoCaoTonResponse() {
        }
        
        public updateBaoCaoTonResponse(DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.updateBaoCaoTonResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class updateBaoCaoTonResponseBody {
        
        public updateBaoCaoTonResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsBaoCaoTonBLLSoapChannel : DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.wsBaoCaoTonBLLSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsBaoCaoTonBLLSoapClient : System.ServiceModel.ClientBase<DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.wsBaoCaoTonBLLSoap>, DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.wsBaoCaoTonBLLSoap {
        
        public wsBaoCaoTonBLLSoapClient() {
        }
        
        public wsBaoCaoTonBLLSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsBaoCaoTonBLLSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsBaoCaoTonBLLSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsBaoCaoTonBLLSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.getListBaoCaoTonResponse DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.wsBaoCaoTonBLLSoap.getListBaoCaoTon(DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.getListBaoCaoTonRequest request) {
            return base.Channel.getListBaoCaoTon(request);
        }
        
        public DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.BaoCaoTonDTO[] getListBaoCaoTon() {
            DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.getListBaoCaoTonRequest inValue = new DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.getListBaoCaoTonRequest();
            inValue.Body = new DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.getListBaoCaoTonRequestBody();
            DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.getListBaoCaoTonResponse retVal = ((DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.wsBaoCaoTonBLLSoap)(this)).getListBaoCaoTon(inValue);
            return retVal.Body.getListBaoCaoTonResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.insertBaoCaoTonResponse DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.wsBaoCaoTonBLLSoap.insertBaoCaoTon(DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.insertBaoCaoTonRequest request) {
            return base.Channel.insertBaoCaoTon(request);
        }
        
        public void insertBaoCaoTon(DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.BaoCaoTonDTO baocaoDTO) {
            DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.insertBaoCaoTonRequest inValue = new DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.insertBaoCaoTonRequest();
            inValue.Body = new DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.insertBaoCaoTonRequestBody();
            inValue.Body.baocaoDTO = baocaoDTO;
            DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.insertBaoCaoTonResponse retVal = ((DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.wsBaoCaoTonBLLSoap)(this)).insertBaoCaoTon(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.deleteBaoCaoTonResponse DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.wsBaoCaoTonBLLSoap.deleteBaoCaoTon(DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.deleteBaoCaoTonRequest request) {
            return base.Channel.deleteBaoCaoTon(request);
        }
        
        public void deleteBaoCaoTon(DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.BaoCaoTonDTO baocaoDTO) {
            DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.deleteBaoCaoTonRequest inValue = new DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.deleteBaoCaoTonRequest();
            inValue.Body = new DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.deleteBaoCaoTonRequestBody();
            inValue.Body.baocaoDTO = baocaoDTO;
            DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.deleteBaoCaoTonResponse retVal = ((DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.wsBaoCaoTonBLLSoap)(this)).deleteBaoCaoTon(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.updateBaoCaoTonResponse DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.wsBaoCaoTonBLLSoap.updateBaoCaoTon(DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.updateBaoCaoTonRequest request) {
            return base.Channel.updateBaoCaoTon(request);
        }
        
        public void updateBaoCaoTon(DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.BaoCaoTonDTO baocaoDTO) {
            DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.updateBaoCaoTonRequest inValue = new DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.updateBaoCaoTonRequest();
            inValue.Body = new DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.updateBaoCaoTonRequestBody();
            inValue.Body.baocaoDTO = baocaoDTO;
            DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.updateBaoCaoTonResponse retVal = ((DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL.wsBaoCaoTonBLLSoap)(this)).updateBaoCaoTon(inValue);
        }
    }
}
