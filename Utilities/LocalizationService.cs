using System.Collections.Generic;
using System.Globalization;

namespace ClientSchedule.Utilities
{
    public static class LocalizationService
    {
        private static CultureInfo _currentCulture = CultureInfo.CurrentCulture;

        public static string CurrentLanguageName => _currentCulture.DisplayName;

        public static void SetCulture(string cultureName)
        {
            _currentCulture = new CultureInfo(cultureName);
        }

        private static readonly Dictionary<string, Dictionary<string, string>> _translations =
            new Dictionary<string, Dictionary<string, string>>
            {
                {
                    "en-US", new Dictionary<string, string>
                    {
                        // Login Form
                        { "lbl_username", "Username" },
                        { "lbl_password", "Password" },
                        { "btn_login", "Login" },
                        { "btn_exit", "Exit" },
                        { "lbl_language", "Language" },
                        { "lbl_location", "Location" },

                        // Login messages
                        { "username_required", "Username is required." },
                        { "password_required", "Password is required." },
                        { "login_success", "Login successful." },
                        { "login_failed", "The username and password do not match." },
                        { "appointment_alert", "You have one or more appointments scheduled within the next 15 minutes." },
                        { "alert_title", "Upcoming Appointment Alert" },

                        // Customer Form
                        { "lbl_customer_name", "Customer Name" },
                        { "lbl_address", "Address" },
                        { "lbl_phone", "Phone" },
                        { "btn_add_customer", "Add Customer" },
                        { "btn_update_customer", "Update Customer" },
                        { "btn_delete_customer", "Delete Customer" },

                        // Appointment Form
                        { "lbl_title", "Title" },
                        { "lbl_type", "Type" },
                        { "lbl_start", "Start Time" },
                        { "lbl_end", "End Time" },
                        { "lbl_customer", "Customer" },
                        { "btn_add_appt", "Add Appointment" },
                        { "btn_update_appt", "Update Appointment" },
                        { "btn_delete_appt", "Delete Appointment" },

                        // Main Form
                        { "btn_customers", "Customers" },
                        { "btn_appointments", "Appointments" },
                        { "btn_calendar", "Calendar" },
                        { "btn_reports", "Reports" },

                        //Reports
                        { "reports_title", "Reports" },
                        { "btn_report1", "Appointment Count by Type" },
                        { "btn_report2", "Consultant Schedule" },
                        { "btn_report3", "Customer Appointments" },

                    }
                },

                {
                    "es-ES", new Dictionary<string, string>
                    {
                        // Login Form
                        { "lbl_username", "Nombre de usuario" },
                        { "lbl_password", "Contraseña" },
                        { "btn_login", "Iniciar sesión" },
                        { "btn_exit", "Salir" },
                        { "lbl_language", "Idioma" },
                        { "lbl_location", "Ubicación" },

                        // Login messages
                        { "username_required", "El nombre de usuario es obligatorio." },
                        { "password_required", "La contraseña es obligatoria." },
                        { "login_success", "Inicio de sesión exitoso." },
                        { "login_failed", "El nombre de usuario y la contraseña no coinciden." },
                        { "appointment_alert", "Tiene una o más citas programadas dentro de los próximos 15 minutos." },
                        { "alert_title", "Alerta de Próxima Cita" },

                        // Customer Form
                        { "lbl_customer_name", "Nombre del cliente" },
                        { "lbl_address", "Dirección" },
                        { "lbl_phone", "Teléfono" },
                        { "btn_add_customer", "Agregar cliente" },
                        { "btn_update_customer", "Actualizar cliente" },
                        { "btn_delete_customer", "Eliminar cliente" },

                        // Appointment Form
                        { "lbl_title", "Título" },
                        { "lbl_type", "Tipo" },
                        { "lbl_start", "Hora de inicio" },
                        { "lbl_end", "Hora de fin" },
                        { "lbl_customer", "Cliente" },
                        { "btn_add_appt", "Agregar cita" },
                        { "btn_update_appt", "Actualizar cita" },
                        { "btn_delete_appt", "Eliminar cita" },

                        // Main Form
                        { "btn_customers", "Clientes" },
                        { "btn_appointments", "Citas" },
                        { "btn_calendar", "Calendario" },
                        { "btn_reports", "Informes" },

                        //Reports
                        { "reports_title", "Informes" },
                        { "btn_report1", "Conteo de citas por tipo" },
                        { "btn_report2", "Horario del consultor" },
                        { "btn_report3", "Citas del cliente" },

                    }
                }
            };

        public static string T(string key)
        {
            string culture = _currentCulture.Name;

            if (_translations.ContainsKey(culture) &&
                _translations[culture].ContainsKey(key))
            {
                return _translations[culture][key];
            }

            return key; // fallback
        }
    }
}