using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOBstream
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Dunning\Desktop\image.jpg";
            string textPath = @"C:\Users\Dunning\Desktop\blob.txt";

            //A stream of bytes that represnts the binary file
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            //The reader reads the binary data from the file stream
            BinaryReader reader = new BinaryReader(fs);

            //Bytes from the binary reader stored in BlobValue array
            byte[] BlobValue = reader.ReadBytes((int)fs.Length);

            string[] str = Encoding.Default.GetString(BlobValue);

            File.WriteAllLines(textPath, str);

            fs.Close();
            reader.Close();
        }
    }
}
