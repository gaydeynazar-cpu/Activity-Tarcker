using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Xml.Serialization;

namespace login_tutorial
{
    internal class Encryption
    {
        // creates two parameters that will consist a public and a private key
        private static RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);
        private RSAParameters pubKey;
        private RSAParameters privKey;

        public void genKeys()
        {
            pubKey = rsa.ExportParameters(false);
            privKey = rsa.ExportParameters(true);
        }

        public void PublicKeyString()
        {
            // Creates a text file where the public key would be stored
            StringWriter sw = new StringWriter();
            XmlSerializer xs = new XmlSerializer(typeof(RSAParameters));
            xs.Serialize(sw, pubKey);
            using (StreamWriter writer = new StreamWriter("Pub.txt"))
            {
                writer.WriteLine(sw.ToString());
            }
        }
        public void PrivateKeyString()
        {
            // creates the text file that would store a private key
            StringWriter sw = new StringWriter();
            XmlSerializer xs = new XmlSerializer(typeof(RSAParameters));
            xs.Serialize(sw, privKey);
            using (StreamWriter writer = new StreamWriter("Private.txt"))
            {
                writer.WriteLine(sw.ToString());
            }
        }
        public string getPubKeyString()
        {
            // reads public key from a text file
            string pubKeyString = "";
            using (StreamReader reader = new StreamReader("Pub.txt"))
            {
                pubKeyString = reader.ReadToEnd();
            }
            return pubKeyString;
        }

        public string getPrivKeyString()
        {
            // reads private key from a text file
            string privKeyString = "";
            using (StreamReader reader = new StreamReader("Private.txt"))
            {
                privKeyString = reader.ReadToEnd();
            }
            return privKeyString;
        }
        public string Encrpt(string plainT)
        {
            // encryption code that uses a public key
            string returnedKey = getPubKeyString();
            StringReader sr = new StringReader(returnedKey);
            XmlSerializer xs = new XmlSerializer(typeof(RSAParameters));
            pubKey = (RSAParameters)xs.Deserialize(sr);
            rsa.ImportParameters(pubKey);
            var BytesPlainT = Encoding.Unicode.GetBytes(plainT);
            var BytesCypherT = rsa.Encrypt(BytesPlainT, false);
            var CypherT = Convert.ToBase64String(BytesCypherT);
            return CypherT;       
        }
        public string Decrypt(string cypherT)
        {
            // decryption code using a private key
            string returnedKey = getPrivKeyString();
            StringReader sr = new StringReader(returnedKey);
            XmlSerializer xs = new XmlSerializer(typeof(RSAParameters));
            privKey = (RSAParameters)xs.Deserialize(sr);
            rsa.ImportParameters(privKey);
            var BytesCypherT = Convert.FromBase64String(cypherT);
            var BytesPlainT = rsa.Decrypt(BytesCypherT, false);
            var PlainT = Encoding.Unicode.GetString(BytesPlainT);
            return PlainT;
        }
    }
}
