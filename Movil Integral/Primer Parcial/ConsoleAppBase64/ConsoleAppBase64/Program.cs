using System;

namespace ConsoleAppBase64
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Creamos la contraseña
            var contraseña = "HolaPapusSoYUnP4$$w0rd";
            Console.WriteLine($"Contraseña: {contraseña}");
            //Encriptamos la contraseña
            var encriptada = Base64EncryptService.Encriptar(contraseña);
            Console.WriteLine($"Contraseña en base64: {encriptada}");
            //Desencriptamos la contraseña
            var decripted = Base64EncryptService.Decriptar(encriptada);
            Console.WriteLine($"Contraseña Decriptada: {decripted}");
            //encriptar a MD5
            encriptada = MD5Encrypter.MD5Encrypt(contraseña);
            Console.WriteLine($"Contraseña encriptada en MD5: {encriptada}");
            var a1 = "F0";
            var a2 = "f0";
            Console.WriteLine($"Comparaciones {a1} y {a2}: {string.Equals(a1, a2)}");
            string saved = "34dd3308e8a2968d0bd73c371dcbe2c5".ToUpper();
            bool isValid = MD5Encrypter.ValidateMD5(saved, encriptada);
            Console.WriteLine($"Comparaciones {saved} y {encriptada}: {isValid}");



        }
    }
}
