﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WORPI.ImageCreator.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WORPI.ImageCreator.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Windows Registry Editor Version 5.00
        ///[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Setup\State]
        ///&quot;ImageState&quot;=&quot;IMAGE_STATE_COMPLETE&quot;
        ///[HKEY_LOCAL_MACHINE\SYSTEM\Setup]
        ///&quot;SetupPhase&quot;=dword:00000000
        ///&quot;SetupType&quot;=dword:00000000
        ///&quot;OOBEInProgress&quot;=dword:00000000
        ///[HKEY_LOCAL_MACHINE\SYSTEM\Setup\Status\ChildCompletion]
        ///&quot;oobeldr.exe&quot;=dword:00000003
        ///&quot;SetupFinalTasks&quot;=dword:00000003
        ///[HKEY_LOCAL_MACHINE\SYSTEM\Setup\Timers\OobeBootPerf]
        ///&quot;StartLow&quot;=dword:ee3f4a6f
        ///&quot;StartHigh&quot;=dword:01d16b34
        ///&quot;Sto [rest of string was truncated]&quot;;.
        /// </summary>
        public static string firststartup {
            get {
                return ResourceManager.GetString("firststartup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to cd c:\ &amp;&amp;
        ///bcdboot i:\windows /s p: /f UEFI.
        /// </summary>
        public static string InstallUEFI {
            get {
                return ResourceManager.GetString("InstallUEFI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to cd c:\ &amp;&amp;
        ///bcdedit /store P:\EFI\Microsoft\Boot\bcd /set {default} testsigning on &amp;&amp;
        ///bcdedit /store P:\EFI\Microsoft\Boot\bcd /set {default} nointegritychecks on.
        /// </summary>
        public static string SignUEFIFiles {
            get {
                return ResourceManager.GetString("SignUEFIFiles", resourceCulture);
            }
        }
    }
}
