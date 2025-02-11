﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TransportManager {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TransportManager.Resources", typeof(Resources).Assembly);
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
        ///   Ищет локализованную строку, похожую на Невозможно выполнить данную операцию с аккаунтом, используемым в текущий момент.
        /// </summary>
        internal static string Error_CurrentAcc {
            get {
                return ResourceManager.GetString("Error_CurrentAcc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Невозможно установить значение id вручную, оно будет установлено автоматически.
        /// </summary>
        internal static string Error_IdAssignment {
            get {
                return ResourceManager.GetString("Error_IdAssignment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на CompanyId должен быть в диапазоне от 1 до 999999.
        /// </summary>
        internal static string Error_IncorrectCompanyId {
            get {
                return ResourceManager.GetString("Error_IncorrectCompanyId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Id должен быть больше 0.
        /// </summary>
        internal static string Error_IncorrectId {
            get {
                return ResourceManager.GetString("Error_IncorrectId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Невозмжно установить значение IsDeleted. Для удаления объекта используйте соответсующий метод.
        /// </summary>
        internal static string Error_IsDeletedTrue {
            get {
                return ResourceManager.GetString("Error_IsDeletedTrue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Невозможно установить значение SoftDeletedDate вручную. Оно будет установлено автоматически при удалении объекта.
        /// </summary>
        internal static string Error_SoftDeletedDateAssignment {
            get {
                return ResourceManager.GetString("Error_SoftDeletedDateAssignment", resourceCulture);
            }
        }
    }
}
