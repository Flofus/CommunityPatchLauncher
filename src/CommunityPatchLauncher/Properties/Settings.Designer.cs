﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CommunityPatchLauncher.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.7.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.githubusercontent.com/LitzeYT/Settlers4Patch/master/Version.ini")]
        public string VersionInformation {
            get {
                return ((string)(this["VersionInformation"]));
            }
            set {
                this["VersionInformation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public byte Normal {
            get {
                return ((byte)(this["Normal"]));
            }
            set {
                this["Normal"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public byte Fast {
            get {
                return ((byte)(this["Fast"]));
            }
            set {
                this["Fast"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public byte Faster {
            get {
                return ((byte)(this["Faster"]));
            }
            set {
                this["Faster"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60")]
        public byte Testing {
            get {
                return ((byte)(this["Testing"]));
            }
            set {
                this["Testing"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1124076")]
        public long PatchPosition {
            get {
                return ((long)(this["PatchPosition"]));
            }
            set {
                this["PatchPosition"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Ubisoft\\Launcher\\Installs\\11785")]
        public string GamePathRegKeyPath {
            get {
                return ((string)(this["GamePathRegKeyPath"]));
            }
            set {
                this["GamePathRegKeyPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("InstallDir")]
        public string GamePathRegKeyName {
            get {
                return ((string)(this["GamePathRegKeyName"]));
            }
            set {
                this["GamePathRegKeyName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://github.com/Settlers4Modding/CommunityPatchLauncher/issues")]
        public string ReportIssueLink {
            get {
                return ((string)(this["ReportIssueLink"]));
            }
            set {
                this["ReportIssueLink"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("PreInstall.txt")]
        public string PreInstall {
            get {
                return ((string)(this["PreInstall"]));
            }
            set {
                this["PreInstall"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Settlers4Modding")]
        public string ReporistoryOwner {
            get {
                return ((string)(this["ReporistoryOwner"]));
            }
            set {
                this["ReporistoryOwner"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CommunityPatchLauncher")]
        public string RepositoryName {
            get {
                return ((string)(this["RepositoryName"]));
            }
            set {
                this["RepositoryName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("develop-([0-9]+)")]
        public string DevelopFilter {
            get {
                return ((string)(this["DevelopFilter"]));
            }
            set {
                this["DevelopFilter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("v(\\d+\\.\\d+\\.\\d+)")]
        public string ReleaseFilter {
            get {
                return ((string)(this["ReleaseFilter"]));
            }
            set {
                this["ReleaseFilter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CommunityLauncherPatcher.exe")]
        public string PatchAppName {
            get {
                return ((string)(this["PatchAppName"]));
            }
            set {
                this["PatchAppName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public float WindowMoveDistance {
            get {
                return ((float)(this["WindowMoveDistance"]));
            }
            set {
                this["WindowMoveDistance"] = value;
            }
        }
    }
}
