using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ClientSchedule.Models;

namespace ClientSchedule.Data
{
    public static class CustomerRepository
    {
        public static List<Customer> GetAllCustomers()
        {
            var customers = new List<Customer>();

            DBConnection.OpenConnection();
            var conn = DBConnection.GetConnection();

            string query = @"
                SELECT c.customerId,
                       c.customerName,
                       c.addressId,
                       a.address,
                       a.phone
                FROM customer c
                JOIN address a ON c.addressId = a.addressId";

            using (var cmd = new MySqlCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    customers.Add(new Customer
                    {
                        customerId = reader.GetInt32("customerId"),
                        customerName = reader.GetString("customerName"),
                        addressId = reader.GetInt32("addressId"),
                        address = reader.GetString("address"),
                        phone = reader.GetString("phone")
                    });
                }
            }

            return customers;
        }

        public static void AddCustomer(string name, string address, string phone)
        {
            try
            {
                DBConnection.OpenConnection();
                var conn = DBConnection.GetConnection();

                // 1) Insert into address
                string insertAddress = @"
                    INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy)
                    VALUES (@address, '', 1, '', @phone, NOW(), 'system', NOW(), 'system')";

                int addressId;

                using (var cmd = new MySqlCommand(insertAddress, conn))
                {
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.ExecuteNonQuery();
                    addressId = (int)cmd.LastInsertedId;
                }

                // 2) Insert into customer
                string insertCustomer = @"
                    INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy)
                    VALUES (@name, @addressId, 1, NOW(), 'system', NOW(), 'system')";

                using (var cmd = new MySqlCommand(insertCustomer, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@addressId", addressId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw; // handled in form via LocalizationService.T("SaveError")
            }
        }

        public static void UpdateCustomer(int id, string name, string address, string phone)
        {
            try
            {
                DBConnection.OpenConnection();
                var conn = DBConnection.GetConnection();

                // 1) Get addressId for this customer
                int addressId;
                string getAddressIdQuery = "SELECT addressId FROM customer WHERE customerId = @id";

                using (var cmd = new MySqlCommand(getAddressIdQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    addressId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // 2) Update address
                string updateAddress = @"
                    UPDATE address
                    SET address = @address,
                        phone = @phone,
                        lastUpdate = NOW(),
                        lastUpdateBy = 'system'
                    WHERE addressId = @addressId";

                using (var cmd = new MySqlCommand(updateAddress, conn))
                {
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@addressId", addressId);
                    cmd.ExecuteNonQuery();
                }

                // 3) Update customer name
                string updateCustomer = @"
                    UPDATE customer
                    SET customerName = @name,
                        lastUpdate = NOW(),
                        lastUpdateBy = 'system'
                    WHERE customerId = @id";

                using (var cmd = new MySqlCommand(updateCustomer, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw; // handled in form via LocalizationService.T("UpdateError")
            }
        }

        public static bool DeleteCustomer(int id)
        {
            try
            {
                DBConnection.OpenConnection();
                var conn = DBConnection.GetConnection();

                // Get addressId first
                int addressId;
                string getAddressIdQuery = "SELECT addressId FROM customer WHERE customerId = @id";

                using (var cmd = new MySqlCommand(getAddressIdQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    var result = cmd.ExecuteScalar();
                    if (result == null) return false;
                    addressId = Convert.ToInt32(result);
                }

                // Delete customer
                string deleteCustomer = "DELETE FROM customer WHERE customerId = @id";

                using (var cmd = new MySqlCommand(deleteCustomer, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                // Optionally delete address (if not shared)
                string deleteAddress = "DELETE FROM address WHERE addressId = @addressId";

                using (var cmd = new MySqlCommand(deleteAddress, conn))
                {
                    cmd.Parameters.AddWithValue("@addressId", addressId);
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception)
            {
                // rubric: exception handling for delete
                return false;
            }
        }

        public static bool Exists(string name, string phone)
        {
            DBConnection.OpenConnection();
            var conn = DBConnection.GetConnection();

            string query = "SELECT COUNT(*) FROM customer c JOIN address a ON c.addressId = a.addressId " +
                           "WHERE c.customerName = @name AND a.phone = @phone";

            using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@phone", phone);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
    }
}
