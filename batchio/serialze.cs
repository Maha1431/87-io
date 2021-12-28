using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace batchio
{
    public class serialze
    {
        public void Serialize()
        {
            poco obj = new poco();
            obj.ApplicationId = 10;
            obj.ApplicationName = "Binary John";
            FileStream fs = new FileStream(@"C:\Users\CSC\source\repos1\batchio\batchio\demo.txt", FileMode.Create);
            BinaryFormatter format = new BinaryFormatter();
            format.Serialize(fs, obj);
            Console.ReadKey();
        }

        public void Deserialize()
        {
            /*poco obj = new poco();
            obj.ApplicationId = 10;
            obj.ApplicationName = "Binary John";*/
            FileStream fs = new FileStream(@"C:\Users\CSC\source\repos1\batchio\batchio\demo.txt", FileMode.Open);
            BinaryFormatter format = new BinaryFormatter();
            poco deserializepoco = (poco)format.Deserialize(fs);
            Console.WriteLine($"ApplicantionId {deserializepoco.ApplicationId} ----- ApplicationName {deserializepoco.ApplicationName}");
            Console.ReadKey();
        }
    }
}
