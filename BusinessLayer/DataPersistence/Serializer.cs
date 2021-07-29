using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace BusinessLayer.DataPersistence
{
    public class Serializer
    {
        public void serialize(object value, string directory, string fileName)
        {
            CreateDirectory(directory);
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream(directory + "/" + fileName, FileMode.Create, FileAccess.Write);

            using (stream)
            {
            formatter.Serialize(stream, value);
            stream.Close();
            stream.Dispose();
            }
        }

        public object Deserialize(string directory, string fileName)
        {
            CreateDirectory(directory);
            object retorno = null;

            if (File.Exists(directory + "/" + fileName))
            {
                BinaryFormatter formatter = new BinaryFormatter();

                FileStream stream = new FileStream(directory + "/" + fileName, FileMode.Open, FileAccess.Read);

                using (stream)
                {
                    retorno = formatter.Deserialize(stream);
                    stream.Close();
                    stream.Dispose();
                }

            }
            
            return retorno;
        }

        private void CreateDirectory(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

    }
}
