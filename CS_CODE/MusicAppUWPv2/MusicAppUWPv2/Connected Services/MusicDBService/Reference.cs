﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 15.0.26323.1
// 
namespace MusicAppUWPv2.MusicDBService {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ViewModelClass", Namespace="http://schemas.datacontract.org/2004/07/MusicDBService.View")]
    public partial class ViewModelClass : object, System.ComponentModel.INotifyPropertyChanged {
        
        private MusicAppUWPv2.MusicDBService.ViewModelClass.AddDelegate AddMethodField;
        
        private MusicAppUWPv2.MusicDBService.ViewModelClass.ClearDelegate ClearMethodField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MusicAppUWPv2.MusicDBService.ViewModelClass.AddDelegate AddMethod {
            get {
                return this.AddMethodField;
            }
            set {
                if ((object.ReferenceEquals(this.AddMethodField, value) != true)) {
                    this.AddMethodField = value;
                    this.RaisePropertyChanged("AddMethod");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MusicAppUWPv2.MusicDBService.ViewModelClass.ClearDelegate ClearMethod {
            get {
                return this.ClearMethodField;
            }
            set {
                if ((object.ReferenceEquals(this.ClearMethodField, value) != true)) {
                    this.ClearMethodField = value;
                    this.RaisePropertyChanged("ClearMethod");
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
        
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        public class AddDelegate {
        }
        
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        public class ClearDelegate {
        }
    }
}
