using System.Collections.Generic;
using System.Data.SqlClient;
using tthk_contacts.Models;

namespace tthk_contacts
{
    public class DataService
    {
        private readonly SqlConnection connection = new SqlConnection(
            @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\AppData\contacts.mdf; Integrated Security = True");

        /// <summary>
        ///     Validates text, that it isn't blank.
        /// </summary>
        /// <param name="text">Text to validate</param>
        /// <returns>Is text isn't blank?</returns>
        internal bool ValidateText(string text)
        {
            if (text == "") return false;

            return true;
        }

        /// <summary>
        ///     Receives list of groups.
        /// </summary>
        /// <returns>List with groups.</returns>
        internal List<string> GetGroups()
        {
            connection.Open();
            var groups = new List<string>();
            var command = new SqlCommand("SELECT Code FROM Groups;", connection);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read()) groups.Add(reader["Code"].ToString());
            }

            connection.Close();
            return groups;
        }

        /// <summary>
        ///     Receives whole students' emails from database.
        /// </summary>
        /// <returns>String with emails</returns>
        internal string GetAllStudentsEmails()
        {
            connection.Open();
            var emails = "";
            var command = new SqlCommand("SELECT Email from Contacts;", connection);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                    if (!string.IsNullOrEmpty(reader["Email"].ToString()))
                        emails += reader["Email"] + "; ";
            }

            connection.Close();
            return emails;
        }

        /// <summary>
        ///     Receives whole student's records.
        /// </summary>
        /// <param name="showInactive">To show inactive students?</param>
        /// <returns>SqlDataAdapter with students' records.</returns>
        internal SqlDataAdapter GetStudents(bool showInactive)
        {
            SqlDataAdapter dataAdapter;
            connection.Open();
            if (showInactive)
                dataAdapter = new SqlDataAdapter("SELECT * FROM Contacts;", connection);
            else
                dataAdapter = new SqlDataAdapter("SELECT * FROM Contacts WHERE Active = 1;", connection);
            connection.Close();
            return dataAdapter;
        }

        /// <summary>
        ///     Receives students' records, which suitable by groupId.
        /// </summary>
        /// <param name="groupId">Group to search ID</param>
        /// ///
        /// <param name="showInactive">To show inactive students?</param>
        /// <returns>SqlDataAdapter with students' records.</returns>
        internal SqlDataAdapter GetStudents(int groupId, bool showInactive)
        {
            connection.Open();
            SqlDataAdapter dataAdapter;
            if (showInactive)
                dataAdapter = new SqlDataAdapter("SELECT * FROM Contacts WHERE groupId = @groupId;", connection);
            else
                dataAdapter = new SqlDataAdapter("SELECT * FROM Contacts WHERE groupId = @groupId AND Active = 1;",
                    connection);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@groupId", groupId);
            connection.Close();
            return dataAdapter;
        }

        /// <summary>
        ///     Receives students' records, which suitable by searchName.
        /// </summary>
        /// <param name="searchName">Full or name's part to search</param>
        /// <param name="showInactive">To show inactive students?</param>
        /// <returns>SqlDataAdapter with students' records.</returns>
        internal SqlDataAdapter GetStudents(string searchName, bool showInactive)
        {
            connection.Open();
            SqlDataAdapter dataAdapter;
            if (showInactive)
                dataAdapter = new SqlDataAdapter("SELECT * FROM Contacts WHERE name LIKE @name;", connection);
            else
                dataAdapter = new SqlDataAdapter("SELECT * FROM Contacts WHERE name LIKE @name AND Active = 1;",
                    connection);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@name", "%" + searchName + "%");
            connection.Close();
            return dataAdapter;
        }

        /// <summary>
        ///     Receives students' records, which suitable by searchName and groupId.
        /// </summary>
        /// <param name="searchName">Full or name's part to search</param>
        /// <param name="groupId">Group to search ID</param>
        /// <param name="showInactive">To show inactive students?</param>
        /// <returns>SqlDataAdapter with students' records.</returns>
        internal SqlDataAdapter GetStudents(string searchName, int groupId, bool showInactive)
        {
            connection.Open();
            SqlDataAdapter dataAdapter;
            if (showInactive)
                dataAdapter =
                    new SqlDataAdapter(
                        "SELECT * FROM Contacts WHERE groupId = @groupId AND Active = 1 AND name LIKE @name;",
                        connection);
            else
                dataAdapter = new SqlDataAdapter("SELECT * FROM Contacts WHERE groupId = @groupId AND name LIKE @name;",
                    connection);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@name", "%" + searchName + "%");
            dataAdapter.SelectCommand.Parameters.AddWithValue("@groupId", groupId);
            connection.Close();
            return dataAdapter;
        }

        /// <summary>
        ///     Receives whole parents' records from database.
        /// </summary>
        /// <param name="id">Student's id</param>
        /// <returns>SqlDataAdapter with parents' records.</returns>
        internal SqlDataAdapter GetParentsByStudent(int id)
        {
            connection.Open();
            var dataAdapter = new SqlDataAdapter("SELECT * FROM Parents WHERE childrenId = @childrenId", connection);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@childrenId", id);
            connection.Close();
            return dataAdapter;
        }

        /// <summary>
        ///     Adds student to database.
        /// </summary>
        /// <param name="student">Student</param>
        internal void AddStudent(Student student)
        {
            connection.Open();
            SqlCommand command;
            if (student.GroupId > 0)
            {
                command = new SqlCommand(
                    "INSERT INTO Contacts(Name, Phone, Email, Picture, GroupId, DateOfBirth, Scholarship, Active) VALUES (@name, @phone, @email, @picture, @groupId, @dateOfBirth, @scholarship, @active)",
                    connection);
                command.Parameters.AddWithValue("@groupId", student.GroupId);
            }
            else
            {
                command = new SqlCommand(
                    "INSERT INTO Contacts(Name, Phone, Email, Picture, DateOfBirth, Scholarship, Active) VALUES (@name, @phone, @email, @picture, @dateOfBirth, @scholarship, @active)",
                    connection);
            }

            command.Parameters.AddWithValue("@name", student.Name);
            command.Parameters.AddWithValue("@phone", student.Phone);
            command.Parameters.AddWithValue("@email", student.Email);
            command.Parameters.AddWithValue("@picture", student.PicturePath);
            command.Parameters.AddWithValue("@dateOfBirth", student.DateOfBirth);
            command.Parameters.AddWithValue("@scholarship", student.Scholarship);
            command.Parameters.AddWithValue("@active", student.Active);
            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        ///     Adds parent record to database.
        /// </summary>
        /// <param name="parent">Parent</param>
        internal void AddParent(Parent parent)
        {
            connection.Open();
            var command =
                new SqlCommand(
                    "INSERT INTO Parents(Name, Phone, Email, Active, ChildrenId) VALUES (@name, @phone, @email, @active, @childrenId);",
                    connection);
            command.Parameters.AddWithValue("@name", parent.Name);
            command.Parameters.AddWithValue("@phone", parent.Phone);
            command.Parameters.AddWithValue("@email", parent.Email);
            command.Parameters.AddWithValue("@active", parent.Active);
            command.Parameters.AddWithValue("@childrenId", parent.ChildrenId);
            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        ///     Adds group to database.
        /// </summary>
        /// <param name="code">Group to add code</param>
        internal void AddGroup(string code)
        {
            connection.Open();
            var command = new SqlCommand("INSERT INTO Groups(Code) VALUES (@code);", connection);
            command.Parameters.AddWithValue("@code", code);
            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        ///     Deletes group with a suitable code.
        /// </summary>
        /// <param name="code">Group to delete code</param>
        internal void DeleteGroup(string code)
        {
            connection.Open();
            var command = new SqlCommand("DELETE FROM Groups WHERE Code = @code;", connection);
            command.Parameters.AddWithValue("@code", code);
            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        ///     Clear's group field in whole records with a suitable code in GroupId field.
        /// </summary>
        /// <param name="code">Group to clear code</param>
        internal void ClearStudentsGroup(string code)
        {
            connection.Open();
            var command = new SqlCommand("UPDATE Contacts SET GroupId = NULL WHERE Group.Code = @code", connection);
            command.Parameters.AddWithValue("@code", code);
            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        ///     Updates student in database.
        /// </summary>
        /// <param name="student">Student</param>
        internal void Update(Student student)
        {
            connection.Open();
            var command = new SqlCommand("UPDATE Contacts SET Name = @name, " +
                                         "Phone = @phone, " +
                                         "Email = @email, " +
                                         "Picture = @picture, " +
                                         "Scholarship = @scholarship, " +
                                         "GroupId = @groupId," +
                                         "DateOfBirth = @dateOfBirth, " +
                                         "Active = @active " +
                                         "WHERE Id = @id", connection);
            command.Parameters.AddWithValue("@id", student.Id);
            command.Parameters.AddWithValue("@name", student.Name);
            command.Parameters.AddWithValue("@phone", student.Phone);
            command.Parameters.AddWithValue("@email", student.Email);
            command.Parameters.AddWithValue("@picture", student.PicturePath);
            command.Parameters.AddWithValue("@groupId", student.GroupId);
            command.Parameters.AddWithValue("@scholarship", student.Scholarship);
            command.Parameters.AddWithValue("@dateOfBirth", student.DateOfBirth);
            command.Parameters.AddWithValue("@active", student.Active);
            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        ///     Updates parent in database.
        /// </summary>
        /// <param name="parent">Parent</param>
        internal void Update(Parent parent)
        {
            connection.Open();
            var command = new SqlCommand("UPDATE Parents SET Name = @name, " +
                                         "Phone = @phone, " +
                                         "Email = @email, " +
                                         "ChildrenId = @childrenId, " +
                                         "Active = @active", connection);
            command.Parameters.AddWithValue("@id", parent.Id);
            command.Parameters.AddWithValue("@name", parent.Name);
            command.Parameters.AddWithValue("@phone", parent.Phone);
            command.Parameters.AddWithValue("@email", parent.Email);
            command.Parameters.AddWithValue("@childrenId", parent.ChildrenId);
            command.Parameters.AddWithValue("@active", parent.Active);
            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        ///     Deletes contact from database.
        /// </summary>
        /// <param name="id">Contact ID</param>
        internal void DeleteStudent(int id)
        {
            connection.Open();
            var command = new SqlCommand("DELETE FROM Contacts WHERE Id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        ///     Deletes parent from database.
        /// </summary>
        /// <param name="id">Parent ID</param>
        internal void DeleteParent(int id)
        {
            connection.Open();
            var command = new SqlCommand("DELETE FROM Parents WHERE Id = @id;", connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        ///     Authorizes user from database.
        /// </summary>
        /// <param name="login">User's login</param>
        internal string GetPassword(string login)
        {
            connection.Open();
            var command = new SqlCommand("SELECT Password FROM Users WHERE Login = @login", connection);
            command.Parameters.AddWithValue("@login", login);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read()) return reader["Password"].ToString();
            }

            return null;
        }

        /// <param name="student">Student to change data permission.</param>
        internal void ChangeDataPermission(Student student)
        {
            connection.Open();
            var command = new SqlCommand("UPDATE Contacts SET DataPermission = @dataPermission WHERE Id = @id", connection);
            command.Parameters.AddWithValue("@dataPermission", student.DataPermission);
            command.Parameters.AddWithValue("@id", student.Id);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}