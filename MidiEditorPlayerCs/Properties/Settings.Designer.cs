﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MidiEditorPlayerCs.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("LightBlue")]
        public global::System.Drawing.Color GridLines {
            get {
                return ((global::System.Drawing.Color)(this["GridLines"]));
            }
            set {
                this["GridLines"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SteelBlue")]
        public global::System.Drawing.Color BackGround {
            get {
                return ((global::System.Drawing.Color)(this["BackGround"]));
            }
            set {
                this["BackGround"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color QtrNoteSeparator {
            get {
                return ((global::System.Drawing.Color)(this["QtrNoteSeparator"]));
            }
            set {
                this["QtrNoteSeparator"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color BarSeparator {
            get {
                return ((global::System.Drawing.Color)(this["BarSeparator"]));
            }
            set {
                this["BarSeparator"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("LightBlue")]
        public global::System.Drawing.Color NoteFill {
            get {
                return ((global::System.Drawing.Color)(this["NoteFill"]));
            }
            set {
                this["NoteFill"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Purple")]
        public global::System.Drawing.Color NoteOutline {
            get {
                return ((global::System.Drawing.Color)(this["NoteOutline"]));
            }
            set {
                this["NoteOutline"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public int SixteenNoteMeasureCount {
            get {
                return ((int)(this["SixteenNoteMeasureCount"]));
            }
            set {
                this["SixteenNoteMeasureCount"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public int QuarterNoteInMeasure {
            get {
                return ((int)(this["QuarterNoteInMeasure"]));
            }
            set {
                this["QuarterNoteInMeasure"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Snapper {
            get {
                return ((bool)(this["Snapper"]));
            }
            set {
                this["Snapper"] = value;
            }
        }
    }
}