using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RomGeo.QuizObjects;
using System.IO;
using System.Drawing;

namespace RomGeo.Utils
{
    public class Converters
    {
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null) return null;
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static String DomainToString(Domain domain)
        {
            switch (domain)
            {
                case Domain.Administrativ:
                    return "admin";
                case Domain.Hidrografie:
                    return "hidro";
                case Domain.Relief:
                    return "rel";
                case Domain.Resurse:
                    return "res";
            }
            return "error";
        }


        public static Domain StringToDomain(String domain)
        {
            switch (domain)
            {
                case "admin":
                    return Domain.Administrativ;
                case "hidro":
                    return Domain.Hidrografie;
                case "rel":
                    return Domain.Relief;
                case "res":
                    return Domain.Resurse;
            }
            return Domain.None;
        }

    }
}
