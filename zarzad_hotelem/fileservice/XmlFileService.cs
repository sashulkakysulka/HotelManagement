using MyLibrary.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyLibrary.fileservice
{
    public class XmlFileService<T> : IFileService<T>
    {
        public List<T> ReadData(string path)
        {
            List<T> lista = new List<T>();
            if (File.Exists(path))
            {
                using (FileStream stream = File.OpenRead(path))
                {

                    XmlSerializer serializer = new XmlSerializer(typeof(List<T>));

                    lista = (List<T>)serializer.Deserialize(stream);
                }

            }
            else
            {

                FileNotFoundException wyjatek = new FileNotFoundException("Plik nie istnieje");
                throw wyjatek;
            }

            return lista;
        }
        public void SaveData(string path, List<T> lista)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (FileStream stream = File.Create(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                xmlSerializer.Serialize(stream, lista);
            }
        }

    }
}
