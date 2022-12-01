using System;
using Kompas6API5;
using Kompas6Constants3D;
using System.Runtime.InteropServices;

namespace APIConnector
{
    /// <summary>
    /// Класс для подключения к Компас-3D
    /// </summary>
    public class KompasConnector
    {
        /// <summary>
        /// Хранит название программы
        /// </summary>
        private const string ProgId = "KOMPAS.Application.5";

        /// <summary>
        /// Интерфейс API Компас-3D
        /// </summary>
        public KompasObject Kompas { get; set; }

        /// <summary>
        /// Интерфейс компонента Компас-3D
        /// </summary>
        public ksPart KsPart { get; set; }

        /// <summary>
        /// Конструктор класса KompasConnector
        /// </summary>
        public void OpenKompas()
        {
            try
            {
                //если программа открыта
                Kompas = (KompasObject) Marshal.GetActiveObject(ProgId);
            }
            catch (COMException)
            {
                try
                {
                    var t = Type.GetTypeFromProgID(ProgId);
                    //если программа еще не открыта, то 
                    //пытаемся ее открыть
                    Kompas = (KompasObject)Activator.CreateInstance(t);
                }
                catch (Exception)
                {
                    throw new ArgumentException(@"Ошибка в запуске программы");
                }
            }
            
            Kompas.Visible = true;
            Kompas.ActivateControllerAPI();
            
            var doc3D = (ksDocument3D) Kompas.Document3D();
            doc3D.Create();
            KsPart = (ksPart)doc3D.GetPart((short)Part_Type.pTop_Part);
        }
    }
}
