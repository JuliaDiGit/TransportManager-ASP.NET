﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Models.Resources", typeof(Resources).Assembly);
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
        ///   Ищет локализованную строку, похожую на Id компании должен быть в диапазоне от 1 до 999999.
        /// </summary>
        internal static string Error_CompanyIdOutOfRange {
            get {
                return ResourceManager.GetString("Error_CompanyIdOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Название компании должно содержать не более 50 символов.
        /// </summary>
        internal static string Error_CompanyNameIsLonger {
            get {
                return ResourceManager.GetString("Error_CompanyNameIsLonger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Имя должно содержать не более 50 символов.
        /// </summary>
        internal static string Error_DriverNameIsLonger {
            get {
                return ResourceManager.GetString("Error_DriverNameIsLonger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Гос. номер должен быть в формате А000АА00, где А - буквы (кириллица), а 0 - цифры.
        /// </summary>
        internal static string Error_IncorrectGovernmentNumber {
            get {
                return ResourceManager.GetString("Error_IncorrectGovernmentNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Неверный тип!.
        /// </summary>
        internal static string Error_IncorrectType {
            get {
                return ResourceManager.GetString("Error_IncorrectType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Логин должен содержать не более 15 латинских букв (цифры и спецсимволы - не допускаются).
        /// </summary>
        internal static string Error_IncorrectUserLogin {
            get {
                return ResourceManager.GetString("Error_IncorrectUserLogin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Пароль должен содержать не более 20 латинских букв и цифр, среди которых, как минимум, 1 заглавная буква и 1 цифра (спецсимволы - не допускаются).
        /// </summary>
        internal static string Error_IncorrectUserPassword {
            get {
                return ResourceManager.GetString("Error_IncorrectUserPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Название модели должно содержать не более 20 символов.
        /// </summary>
        internal static string Error_VehicleModelIsLonger {
            get {
                return ResourceManager.GetString("Error_VehicleModelIsLonger", resourceCulture);
            }
        }
    }
}
