﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CustomRPC {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CustomRPC.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
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
        ///   Ищет локализованную строку, похожую на Error.
        /// </summary>
        internal static string error {
            get {
                return ResourceManager.GetString("error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Can&apos;t connect to Discord client.
        ///Are you sure it&apos;s running?.
        /// </summary>
        internal static string errorCannotConnect {
            get {
                return ResourceManager.GetString("errorCannotConnect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Invalid URL specified for button(s) or the text is too long!.
        /// </summary>
        internal static string errorInvalidURL {
            get {
                return ResourceManager.GetString("errorInvalidURL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на No ID specified!.
        /// </summary>
        internal static string errorNoID {
            get {
                return ResourceManager.GetString("errorNoID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на There was an error downloading or installing an update.
        ///Press &quot;Yes&quot; to retry or &quot;No&quot; to download manually..
        /// </summary>
        internal static string errorUpdateFailed {
            get {
                return ResourceManager.GetString("errorUpdateFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на First Time Run.
        /// </summary>
        internal static string firstTimeRun {
            get {
                return ResourceManager.GetString("firstTimeRun", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Would you like to open a manual?
        ///You can open it any time by going to Help -&gt; Open the Manual or pressing F1..
        /// </summary>
        internal static string firstTimeRunText {
            get {
                return ResourceManager.GetString("firstTimeRunText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Information.
        /// </summary>
        internal static string information {
            get {
                return ResourceManager.GetString("information", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Connected.
        /// </summary>
        internal static string statusConnected {
            get {
                return ResourceManager.GetString("statusConnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Connecting....
        /// </summary>
        internal static string statusConnecting {
            get {
                return ResourceManager.GetString("statusConnecting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Connection failed (Is Discord running?).
        /// </summary>
        internal static string statusConnectionFailed {
            get {
                return ResourceManager.GetString("statusConnectionFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Disconnected.
        /// </summary>
        internal static string statusDisconnected {
            get {
                return ResourceManager.GetString("statusDisconnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Connection error (Wrong ID?).
        /// </summary>
        internal static string statusError {
            get {
                return ResourceManager.GetString("statusError", resourceCulture);
            }
        }
    }
}
