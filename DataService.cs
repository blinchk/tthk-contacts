﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net.Configuration;
using tthk_contacts.Models;

namespace tthk_contacts
{
    public class DataService
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\AppData\contacts.mdf; Integrated Security = True");

        /// <summary>
        /// Validates text, that it isn't blank.
        /// </summary>
        /// <param name="text">Text to validate</param>
        /// <returns>Is text isn't blank?</returns>
        internal bool ValidateText(string text)
        {
            if (text == "")
            {
                return false;
            }

            return true;
        }
        
        /// <summary>
        /// Receives list of groups.
        /// </summary>
        /// <returns>List with groups.</returns>
        internal List<string> GetGroups()
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

        /// <summary>
        /// Receives whole students' emails from database.
        /// </summary>
        /// <returns>String with emails</returns>
        internal string GetAllStudentsEmails()
        {
            connection.Open();
            DataService dataService = new DataService();
            string emails = "";
            SqlCommand command = new SqlCommand("SELECT Email from Contacts;", connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (dataService.ValidateText(reader["Email"].ToString()))
                        emails += reader["Email"].ToString() + "; ";
                }
            }
            connection.Close(); 
            return emails;
        }

        /// <summary>
        /// Receives whole student's records.
        /// </summary>
        /// <returns>SqlDataAdapter with students' records.</returns>
        internal SqlDataAdapter GetStudents()
        {
            return new SqlDataAdapter("SELECT * FROM Contacts;", connection);
        }

        /// <summary>
        /// Receives students' records, which suitable by groupId.
        /// </summary>
        /// <param name="groupId">Group to search ID</param>
        /// <returns>SqlDataAdapter with students' records.</returns>
        internal SqlDataAdapter GetStudents(int groupId)
        {
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Contacts WHERE groupId = @groupId;", connection);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@groupId", groupId);
            connection.Close();
            return dataAdapter;
        }

        /// <summary>
        /// Receives students' records, which suitable by searchName.
        /// </summary>
        /// <param name="searchName">Full or name's part to search</param>
        /// <returns>SqlDataAdapter with students' records.</returns>
        internal SqlDataAdapter GetStudents(string searchName)
        {
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Contacts WHERE name LIKE @name;", connection);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@name", "%" + searchName + "%");
            connection.Close();
            return dataAdapter;
        }

        /// <summary>
        /// Receives students' records, which suitable by searchName and groupId.
        /// </summary>
        /// <param name="searchName">Full or name's part to search</param>
        /// <param name="groupId">Group to search ID</param>
        /// <returns>SqlDataAdapter with students' records.</returns>
        internal SqlDataAdapter GetStudents(string searchName, int groupId)
        {
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Contacts WHERE name LIKE @name AND groupId = @groupId;", connection);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@name", "%" + searchName + "%");
            dataAdapter.SelectCommand.Parameters.AddWithValue("@groupId", groupId);
            connection.Close();
            return dataAdapter;
        }

        /// <summary>
        /// Receives whole parents' records from database.
        /// </summary>
        /// <returns>SqlDataAdapter with parents' records.</returns>
        internal SqlDataAdapter GetParents()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds student to database.
        /// </summary>
        /// <param name="student">Student</param>
        internal void AddStudent(Student student)
        {
            connection.Open();
            SqlCommand command;
            if (student.GroupId > 0)
            {
                command = new SqlCommand("INSERT INTO Contacts(Name, Phone, Email, Picture, GroupId, DateOfBirth) VALUES (@name, @phone, @email, @picture, @groupId, @dateOfBirth)", connection);
                command.Parameters.AddWithValue("@groupId", student.GroupId);
            }
            else
            {
                command = new SqlCommand("INSERT INTO Contacts(Name, Phone, Email, Picture, DateOfBirth) VALUES (@name, @phone, @email, @picture, @dateOfBirth)", connection);
            }
            command.Parameters.AddWithValue("@name", student.Name);
            command.Parameters.AddWithValue("@phone", student.Phone);
            command.Parameters.AddWithValue("@email", student.Email);
            command.Parameters.AddWithValue("@picture", student.PicturePath);
            command.Parameters.AddWithValue("@dateOfBirth", student.DateOfBirth);
            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Adds parent record to database.
        /// </summary>
        /// <param name="parent">Parent</param>
        internal void AddParent(Parent parent)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds group to database.
        /// </summary>
        /// <param name="code">Group to add code</param>
        internal void AddGroup(string code)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Groups(Code) VALUES (@code);", connection);
            command.Parameters.AddWithValue("@code", code);
            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Deletes group with a suitable code.
        /// </summary>
        /// <param name="code">Group to delete code</param>
        internal void DeleteGroup(string code)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM Groups WHERE Code = @code;", connection);
            command.Parameters.AddWithValue("@code", code);
            command.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// Clear's group field in whole records with a suitable code in GroupId field.
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
        /// Updates student in database.
        /// </summary>
        /// <param name="student">Student</param>
        internal void UpdateStudent(Student student)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("UPDATE Contacts SET Name = @name, Phone = @phone, Email = @email, Picture = @picture, GroupId = @groupId WHERE Id = @id", connection);
            command.Parameters.AddWithValue("@id", student.Id);
            command.Parameters.AddWithValue("@name", student.Name);
            command.Parameters.AddWithValue("@phone", student.Phone);
            command.Parameters.AddWithValue("@email", student.Email);
            command.Parameters.AddWithValue("@picture", student.PicturePath);
            command.Parameters.AddWithValue("@groupId", student.GroupId);
            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Updates parent in database.
        /// </summary>
        /// <param name="parent">Parent</param>
        internal void UpdateParent(Parent parent)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes contact from database.
        /// </summary>
        /// <param name="id">Contact ID</param>
        internal void DeleteContact(int id)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM Contacts WHERE Id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Deletes parent from database.
        /// </summary>
        /// <param name="id">Parent ID</param>
        internal void DeleteParent(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Authorizes user from database.
        /// </summary>
        /// <param name="login">User's login</param>
        internal string GetPassword(string login)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT Password FROM Users WHERE Login = @login", connection);
            command.Parameters.AddWithValue("@login", login);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    return reader["Password"].ToString();
                }
            }

            return null;
        }
    }
}