﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StyleCop.Analyzers.SpecialRules {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SpecialResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SpecialResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("StyleCop.Analyzers.SpecialRules.SpecialResources", typeof(SpecialResources).GetTypeInfo().Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Visual Studio 2015 Update 1 contains a bug which can cause diagnostics to occasionally not display in the Errors window. When this occurs, it is impossible to use the code fixes to address style violations reported during a build. This analyzer works around the bug (dotnet/roslyn#7446).
        ///
        ///When this analyzer is enabled, all diagnostics will eventually be reported in the Error window, but the performance of the analyzers is reduced. The rule is disabled for maximum performance, but can be enabled if users no [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SA0000Description {
            get {
                return ResourceManager.GetString("SA0000Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to n/a.
        /// </summary>
        internal static string SA0000MessageFormat {
            get {
                return ResourceManager.GetString("SA0000MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Workaround incomplete diagnostics in Visual Studio 2015 Update 1.
        /// </summary>
        internal static string SA0000Title {
            get {
                return ResourceManager.GetString("SA0000Title", resourceCulture);
            }
        }
    }
}