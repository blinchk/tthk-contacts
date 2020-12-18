using System.Collections.Generic;
using System.Data.SqlClient;
using tthk_contacts.Models;

namespace tthk_contacts
{
    public class DataService
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\AppData\contacts.mdf; Integrated Security = True");

        internal bool ValidateText(string text)
        {
            if (text == "")
            {
                return false;
            }

            return true;
        }

        internal List<string> SearchGroups()
        {
            connection.Open();
            List<string> groups = new List<string>();
            SqlCommand command = new SqlCommand("SELECT Code FROM Groups;", connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    groups.Add(reader["Code"].ToString());
                }
            }
            connection.Close();
            return groups;
        }
        internal SqlDataAdapter SearchData()
        {
            return new SqlDataAdapter("SELECT * FROM Contacts;", connection);
        }

        internal SqlDataAdapter SearchData(int groupId)
        {
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Contacts WHERE groupId = @groupId;", connection);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@groupId", groupId);
            connection.Close();
            return dataAdapter;
        }

        internal SqlDataAdapter SearchData(string searchName)
        {
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Contacts WHERE name LIKE @name;", connection);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@name", "%" + searchName + "%");
            connection.Close();
            return dataAdapter;
        }

        internal SqlDataAdapter SearchData(string searchName, int groupId)
        {
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Contacts WHERE name LIKE @name AND groupId = @groupId;", connection);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@name", "%" + searchName + "%");
            dataAdapter.SelectCommand.Parameters.AddWithValue("@groupId", groupId);
            connection.Close();
            return dataAdapter;
        }

        internal void AddContact(Contact contact)
        {
            connection.Open();
            SqlCommand command;
            if (contact.GroupId > 0)
            {
                command = new SqlCommand("INSERT INTO Contacts(Name, Phone, Email, Picture, GroupId) VALUES (@name, @phone, @email, @picture, @groupId)", connection);
                command.Parameters.AddWithValue("@groupId", contact.GroupId);
            }
            else
            {
                command = new SqlCommand("INSERT INTO Contacts(Name, Phone, Email, Picture) VALUES (@name, @phone, @email, @picture)", connection);
            }
            command.Parameters.AddWithValue("@name", contact.Name);
            command.Parameters.AddWithValue("@phone", contact.Phone);
            command.Parameters.AddWithValue("@email", contact.Email);
            command.Parameters.AddWithValue("@picture", contact.PicturePath);
            command.ExecuteNonQuery();
            connection.Close();
        }
        internal void UpdateContact(Contact contact)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("UPDATE Contacts SET Name = @name, Phone = @phone, Email = @email, Picture = @picture, GroupId = @groupId WHERE Id = @id", connection);
            command.Parameters.AddWithValue("@id", contact.Id);
            command.Parameters.AddWithValue("@name", contact.Name);
            command.Parameters.AddWithValue("@phone", contact.Phone);
            command.Parameters.AddWithValue("@email", contact.Email);
            command.Parameters.AddWithValue("@picture", contact.PicturePath);
            command.Parameters.AddWithValue("@groupId", contact.GroupId);
            command.ExecuteNonQuery();
            connection.Close();
        }

        internal void DeleteContact(int id)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM Contacts WHERE Id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}