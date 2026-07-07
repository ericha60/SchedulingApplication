using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ClientSchedule.Utilities
{
    public static class Localization
    {
        public static CultureInfo CurrentCulture { get; private set; }

        public static void Initialize()
        {
            CurrentCulture = CultureInfo.CurrentCulture;
        }

        public static string Translate(string key)
        {
            bool isSpanish = CurrentCulture.TwoLetterISOLanguageName == "es";

            switch (key)
            {
                case "username_required":
                    return isSpanish ? "Por favor ingrese un nombre de usuario." : "Please enter a username.";

                case "password_required":
                    return isSpanish ? "Por favor ingrese una contraseña." : "Please enter a password.";

                case "login_failed":
                    return isSpanish ? "El nombre de usuario y la contraseña no coinciden." : "The username and password do not match.";

                case "login_success":
                    return isSpanish ? "Inicio de sesión exitoso." : "Login successful.";

                default:
                    return key;
            }
        }
    }
}