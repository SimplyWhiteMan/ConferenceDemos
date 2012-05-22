﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17379
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AsyncMVCOld.NewsServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NewsModel", Namespace="http://schemas.datacontract.org/2004/07/AsyncMVCOld")]
    [System.SerializableAttribute()]
    public partial class NewsModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HeadingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TextField;
        
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
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Heading {
            get {
                return this.HeadingField;
            }
            set {
                if ((object.ReferenceEquals(this.HeadingField, value) != true)) {
                    this.HeadingField = value;
                    this.RaisePropertyChanged("Heading");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text {
            get {
                return this.TextField;
            }
            set {
                if ((object.ReferenceEquals(this.TextField, value) != true)) {
                    this.TextField = value;
                    this.RaisePropertyChanged("Text");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NewsServiceReference.INewsService")]
    public interface INewsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/GetWorldNews", ReplyAction="http://tempuri.org/INewsService/GetWorldNewsResponse")]
        AsyncMVCOld.NewsServiceReference.NewsModel[] GetWorldNews();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/INewsService/GetWorldNews", ReplyAction="http://tempuri.org/INewsService/GetWorldNewsResponse")]
        System.IAsyncResult BeginGetWorldNews(System.AsyncCallback callback, object asyncState);
        
        AsyncMVCOld.NewsServiceReference.NewsModel[] EndGetWorldNews(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/GetSportNews", ReplyAction="http://tempuri.org/INewsService/GetSportNewsResponse")]
        AsyncMVCOld.NewsServiceReference.NewsModel[] GetSportNews();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/INewsService/GetSportNews", ReplyAction="http://tempuri.org/INewsService/GetSportNewsResponse")]
        System.IAsyncResult BeginGetSportNews(System.AsyncCallback callback, object asyncState);
        
        AsyncMVCOld.NewsServiceReference.NewsModel[] EndGetSportNews(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/GetFunNews", ReplyAction="http://tempuri.org/INewsService/GetFunNewsResponse")]
        AsyncMVCOld.NewsServiceReference.NewsModel[] GetFunNews();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/INewsService/GetFunNews", ReplyAction="http://tempuri.org/INewsService/GetFunNewsResponse")]
        System.IAsyncResult BeginGetFunNews(System.AsyncCallback callback, object asyncState);
        
        AsyncMVCOld.NewsServiceReference.NewsModel[] EndGetFunNews(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INewsServiceChannel : AsyncMVCOld.NewsServiceReference.INewsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetWorldNewsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetWorldNewsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public AsyncMVCOld.NewsServiceReference.NewsModel[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((AsyncMVCOld.NewsServiceReference.NewsModel[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetSportNewsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetSportNewsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public AsyncMVCOld.NewsServiceReference.NewsModel[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((AsyncMVCOld.NewsServiceReference.NewsModel[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetFunNewsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetFunNewsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public AsyncMVCOld.NewsServiceReference.NewsModel[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((AsyncMVCOld.NewsServiceReference.NewsModel[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NewsServiceClient : System.ServiceModel.ClientBase<AsyncMVCOld.NewsServiceReference.INewsService>, AsyncMVCOld.NewsServiceReference.INewsService {
        
        private BeginOperationDelegate onBeginGetWorldNewsDelegate;
        
        private EndOperationDelegate onEndGetWorldNewsDelegate;
        
        private System.Threading.SendOrPostCallback onGetWorldNewsCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetSportNewsDelegate;
        
        private EndOperationDelegate onEndGetSportNewsDelegate;
        
        private System.Threading.SendOrPostCallback onGetSportNewsCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetFunNewsDelegate;
        
        private EndOperationDelegate onEndGetFunNewsDelegate;
        
        private System.Threading.SendOrPostCallback onGetFunNewsCompletedDelegate;
        
        public NewsServiceClient() {
        }
        
        public NewsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NewsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NewsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NewsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<GetWorldNewsCompletedEventArgs> GetWorldNewsCompleted;
        
        public event System.EventHandler<GetSportNewsCompletedEventArgs> GetSportNewsCompleted;
        
        public event System.EventHandler<GetFunNewsCompletedEventArgs> GetFunNewsCompleted;
        
        public AsyncMVCOld.NewsServiceReference.NewsModel[] GetWorldNews() {
            return base.Channel.GetWorldNews();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetWorldNews(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetWorldNews(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public AsyncMVCOld.NewsServiceReference.NewsModel[] EndGetWorldNews(System.IAsyncResult result) {
            return base.Channel.EndGetWorldNews(result);
        }
        
        private System.IAsyncResult OnBeginGetWorldNews(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetWorldNews(callback, asyncState);
        }
        
        private object[] OnEndGetWorldNews(System.IAsyncResult result) {
            AsyncMVCOld.NewsServiceReference.NewsModel[] retVal = this.EndGetWorldNews(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetWorldNewsCompleted(object state) {
            if ((this.GetWorldNewsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetWorldNewsCompleted(this, new GetWorldNewsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetWorldNewsAsync() {
            this.GetWorldNewsAsync(null);
        }
        
        public void GetWorldNewsAsync(object userState) {
            if ((this.onBeginGetWorldNewsDelegate == null)) {
                this.onBeginGetWorldNewsDelegate = new BeginOperationDelegate(this.OnBeginGetWorldNews);
            }
            if ((this.onEndGetWorldNewsDelegate == null)) {
                this.onEndGetWorldNewsDelegate = new EndOperationDelegate(this.OnEndGetWorldNews);
            }
            if ((this.onGetWorldNewsCompletedDelegate == null)) {
                this.onGetWorldNewsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetWorldNewsCompleted);
            }
            base.InvokeAsync(this.onBeginGetWorldNewsDelegate, null, this.onEndGetWorldNewsDelegate, this.onGetWorldNewsCompletedDelegate, userState);
        }
        
        public AsyncMVCOld.NewsServiceReference.NewsModel[] GetSportNews() {
            return base.Channel.GetSportNews();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetSportNews(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetSportNews(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public AsyncMVCOld.NewsServiceReference.NewsModel[] EndGetSportNews(System.IAsyncResult result) {
            return base.Channel.EndGetSportNews(result);
        }
        
        private System.IAsyncResult OnBeginGetSportNews(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetSportNews(callback, asyncState);
        }
        
        private object[] OnEndGetSportNews(System.IAsyncResult result) {
            AsyncMVCOld.NewsServiceReference.NewsModel[] retVal = this.EndGetSportNews(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetSportNewsCompleted(object state) {
            if ((this.GetSportNewsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetSportNewsCompleted(this, new GetSportNewsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetSportNewsAsync() {
            this.GetSportNewsAsync(null);
        }
        
        public void GetSportNewsAsync(object userState) {
            if ((this.onBeginGetSportNewsDelegate == null)) {
                this.onBeginGetSportNewsDelegate = new BeginOperationDelegate(this.OnBeginGetSportNews);
            }
            if ((this.onEndGetSportNewsDelegate == null)) {
                this.onEndGetSportNewsDelegate = new EndOperationDelegate(this.OnEndGetSportNews);
            }
            if ((this.onGetSportNewsCompletedDelegate == null)) {
                this.onGetSportNewsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetSportNewsCompleted);
            }
            base.InvokeAsync(this.onBeginGetSportNewsDelegate, null, this.onEndGetSportNewsDelegate, this.onGetSportNewsCompletedDelegate, userState);
        }
        
        public AsyncMVCOld.NewsServiceReference.NewsModel[] GetFunNews() {
            return base.Channel.GetFunNews();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetFunNews(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetFunNews(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public AsyncMVCOld.NewsServiceReference.NewsModel[] EndGetFunNews(System.IAsyncResult result) {
            return base.Channel.EndGetFunNews(result);
        }
        
        private System.IAsyncResult OnBeginGetFunNews(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetFunNews(callback, asyncState);
        }
        
        private object[] OnEndGetFunNews(System.IAsyncResult result) {
            AsyncMVCOld.NewsServiceReference.NewsModel[] retVal = this.EndGetFunNews(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetFunNewsCompleted(object state) {
            if ((this.GetFunNewsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetFunNewsCompleted(this, new GetFunNewsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetFunNewsAsync() {
            this.GetFunNewsAsync(null);
        }
        
        public void GetFunNewsAsync(object userState) {
            if ((this.onBeginGetFunNewsDelegate == null)) {
                this.onBeginGetFunNewsDelegate = new BeginOperationDelegate(this.OnBeginGetFunNews);
            }
            if ((this.onEndGetFunNewsDelegate == null)) {
                this.onEndGetFunNewsDelegate = new EndOperationDelegate(this.OnEndGetFunNews);
            }
            if ((this.onGetFunNewsCompletedDelegate == null)) {
                this.onGetFunNewsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetFunNewsCompleted);
            }
            base.InvokeAsync(this.onBeginGetFunNewsDelegate, null, this.onEndGetFunNewsDelegate, this.onGetFunNewsCompletedDelegate, userState);
        }
    }
}