using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace Patient_Manager.Controllers
{
    internal class DocxController
    {
        public static DocX RepairDocx(String rutaDocx)
        {
            string rutaTemporal = "doc_temp.docx";

            // Descomprimir temporalmente
            ZipFile.ExtractToDirectory(rutaDocx, "doc_temp");

            // Reemplazar en todos los archivos XML
            foreach (var xml in Directory.GetFiles("doc_temp", "*.xml", SearchOption.AllDirectories))
            {
                string contenido = File.ReadAllText(xml);
                contenido = contenido.Replace("w:jc w:val=\"start\"", "w:jc w:val=\"left\"");
                File.WriteAllText(xml, contenido);
            }

            // Volver a comprimir
            if (File.Exists(rutaTemporal)) File.Delete(rutaTemporal);
            ZipFile.CreateFromDirectory("doc_temp", rutaTemporal);

            // Limpiar carpeta temporal
            Directory.Delete("doc_temp", true);

            // Cargar el documento reparado
            var doc = Xceed.Words.NET.DocX.Load(rutaTemporal);
            return doc;
        }
    }
}
