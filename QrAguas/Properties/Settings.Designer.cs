﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QrAguas.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("server=remotemysql.com;user id=0YbKKAeeke;password=Aqhx0syv8q;database=0YbKKAeeke" +
            "")]
        public string _0YbKKAeekeConnectionString {
            get {
                return ((string)(this["_0YbKKAeekeConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("server=localhost;user id=root;database=0YbKKAeeke")]
        public string qraguasConnectionString {
            get {
                return ((string)(this["qraguasConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("server=Fernando-PC;user id=root;persistsecurityinfo=True;database=0ybkkaeeke")]
        public string _0ybkkaeekeConnectionString1_QrAguasLocalDatabase {
            get {
                return ((string)(this["_0ybkkaeekeConnectionString1_QrAguasLocalDatabase"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("server=localhost;user id=root;persistsecurityinfo=True;database=0ybkkaeeke")]
        public string _0ybkkaeekeCnn {
            get {
                return ((string)(this["_0ybkkaeekeCnn"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("server=Fernando-PC;user id=fernando;password=123456;persistsecurityinfo=True;data" +
            "base=0ybkkaeeke")]
        public string _FernandoPCn53ta {
            get {
                return ((string)(this["_FernandoPCn53ta"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("server=Fernando-PC;user id=fernando;persistsecurityinfo=True;password=123456;data" +
            "base=qraguas")]
        public string QrAguasCnn {
            get {
                return ((string)(this["QrAguasCnn"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("server=qraguasdb.cpfylhgmewyg.sa-east-1.rds.amazonaws.com;port=3306;user id=root;" +
            "password=smartpro;persistsecurityinfo=True;database=qraguasremotedb")]
        public string qraguasremotedbConnectionString {
            get {
                return ((string)(this["qraguasremotedbConnectionString"]));
            }
        }
    }
}
