using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SürücüKursu
{
    class sifrele
    {
        public static string password = "1";
        public static string sifreli="";

        private byte[] Sifrele(byte[] SifresizVeri, byte[] Key, byte[] IV)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael alg = Rijndael.Create();

            alg.Key = Key;
            alg.IV = IV;

            CryptoStream cs = new CryptoStream(ms,

            alg.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(SifresizVeri, 0, SifresizVeri.Length);
            cs.Close();

            byte[] sifrelenmisVeri = ms.ToArray();
            return sifrelenmisVeri;
        }

        private byte[] SifreCoz(byte[] SifreliVeri, byte[] Key, byte[] IV)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael alg = Rijndael.Create();

            alg.Key = Key;
            alg.IV = IV;

            CryptoStream cs = new CryptoStream(ms, alg.CreateDecryptor(), CryptoStreamMode.Write);

            cs.Write(SifreliVeri, 0, SifreliVeri.Length);
            cs.Close();

            byte[] SifresiCozulmusVeri = ms.ToArray();
            return SifresiCozulmusVeri;
        }

        public string TextSifrele(string sifrelenecekMetin)
        {
            byte[] sifrelenecekByteDizisi = System.Text.Encoding.Unicode.GetBytes(sifrelenecekMetin);
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(password, new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d,
            0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
            byte[] SifrelenmisVeri = Sifrele(sifrelenecekByteDizisi,
                 pdb.GetBytes(32), pdb.GetBytes(16));
            return Convert.ToBase64String(SifrelenmisVeri);
        }

        public string TextSifreCoz(string text)
        {
            byte[] SifrelenmisByteDizisi = Convert.FromBase64String(text);
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(password,
                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65,
            0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
            byte[] SifresiCozulmusVeri = SifreCoz(SifrelenmisByteDizisi,
                pdb.GetBytes(32), pdb.GetBytes(16));
            return System.Text.Encoding.Unicode.GetString(SifresiCozulmusVeri);
        }
    }
}
