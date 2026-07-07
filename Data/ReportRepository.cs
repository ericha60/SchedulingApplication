using System;
using System.Collections.Generic;
using System.Linq;
using ClientSchedule.Models;
using ClientSchedule.Utilities;
using ClientSchedule.Data;

namespace ClientSchedule.Data
{
    public static class ReportRepository
    {
        // Report 1: Appointment count by type per month
        public static List<dynamic> GetAppointmentTypeReport()
        {
            var appts = AppointmentRepository.GetAllAppointments();

            var report = appts
                .GroupBy(a => new { a.start.Month, a.type })
                .Select(g => new
                {
                    Month = g.Key.Month,
                    Type = g.Key.type,
                    Count = g.Count()
                })
                .OrderBy(r => r.Month)
                .ThenBy(r => r.Type)
                .ToList<dynamic>();

            return report;
        }

        // Report 2: Consultant schedule (with names)
        public static List<dynamic> GetConsultantSchedule()
        {
            var appts = AppointmentRepository.GetAllAppointments();
            var users = UserRepository.GetAllUsers();

            var report = appts
                .Select(a => new
                {
                    Consultant = users.First(u => u.userId == a.userId).userName,
                    a.title,
                    a.type,
                    Start = a.start,
                    End = a.end,
                    a.location,
                    a.contact
                })
                .OrderBy(r => r.Consultant)
                .ThenBy(r => r.Start)
                .ToList<dynamic>();

            return report;
        }

        // Report 3: Customer appointment list with count + contact details
        public static List<dynamic> GetCustomerAppointmentReport()
        {
            var appts = AppointmentRepository.GetAllAppointments();
            var customers = CustomerRepository.GetAllCustomers();

            var grouped = appts.GroupBy(a => a.customerId);

            var report = grouped
                .SelectMany(g =>
                {
                    var cust = customers.First(c => c.customerId == g.Key);
                    int count = g.Count();

                    return g.Select(a => new
                    {
                        Customer = cust.customerName,
                        Address = cust.address,
                        Phone = cust.phone,
                        AppointmentCount = count,
                        a.title,
                        a.type,
                        Start = a.start,
                        End = a.end
                    });
                })
                .OrderBy(r => r.Customer)
                .ThenBy(r => r.Start)
                .ToList<dynamic>();

            return report;
        }
    }
}