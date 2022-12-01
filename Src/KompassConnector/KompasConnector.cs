using System;
using System.Runtime.InteropServices;
using Kompas6API5;
using Kompas6Constants3D;

namespace KompasConnector
{
    /// <summary>
    /// Class for connecting to Compass-3D
    /// </summary>
    public class Konnector
    {
        /// <summary>
        /// Stores the name of the program
        /// </summary>
        private const string ProgId = "KOMPAS.Application.5";

        /// <summary>
        /// Compass-3D API
        /// </summary>
        public KompasObject Kompas { get; set; }

        /// <summary>
        /// Compass-3D component interface
        /// </summary>
        public ksPart KsPart { get; set; }

        /// <summary>
        /// KompasConnector class constructor
        /// </summary>
        public void OpenKompas()
        {
            try
            {
                // if the program is open
                Kompas = (KompasObject) Marshal.GetActiveObject(ProgId);
            }
            catch (COMException)
            {
                try
                {
                    var type = Type.GetTypeFromProgID(ProgId);
                    // if the program is not open yet, then trying to open it
                    Kompas = (KompasObject)Activator.CreateInstance(type);
                }
                catch (Exception)
                {
                    throw new ArgumentException(@"Error starting the program");
                }
            }
            
            Kompas.Visible = true;
            Kompas.ActivateControllerAPI();
            
        }

         /// <summary>
         /// Create a new document 3D
         /// </summary>
        public void GetNewPart()
        {
            var doc3D = (ksDocument3D)Kompas.Document3D();
            doc3D.Create();
            KsPart = (ksPart)doc3D.GetPart((short)Part_Type.pTop_Part);
        }
    }
}
