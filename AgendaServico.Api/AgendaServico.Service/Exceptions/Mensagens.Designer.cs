﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AgendaServico.Service.Exceptions {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Mensagens {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Mensagens() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AgendaServico.Service.Exceptions.Mensagens", typeof(Mensagens).Assembly);
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
        ///   Looks up a localized string similar to A senha do usuario não foi informada para esta operação.
        /// </summary>
        internal static string SenhaNaoFornecida {
            get {
                return ResourceManager.GetString("SenhaNaoFornecida", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A senha informada esta incorreta..
        /// </summary>
        internal static string SenhasNaoConferem {
            get {
                return ResourceManager.GetString("SenhasNaoConferem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O Usuario informado ja existe no sistema por favor informe outro nome de usuario..
        /// </summary>
        internal static string UsuarioExistente {
            get {
                return ResourceManager.GetString("UsuarioExistente", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O Usuario informado não existe no sistema.
        /// </summary>
        internal static string UsuarioNaoExiste {
            get {
                return ResourceManager.GetString("UsuarioNaoExiste", resourceCulture);
            }
        }
    }
}