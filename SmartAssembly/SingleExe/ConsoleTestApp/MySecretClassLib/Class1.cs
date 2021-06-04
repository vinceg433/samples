using System;

namespace MySecretClassLib
{
    public class SecretClassLib
    {
        private static readonly string MySecretString = "I am supposed to be an unreadable, obfuscated string.";

        public string MySecretMethod() => MySecretString;
    }
}
