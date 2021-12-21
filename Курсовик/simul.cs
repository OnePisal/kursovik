using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовик
{
    class simul
    {

        public bool Add_to_Pets(string Name_org, string Password, string Email, string Login)
        {
            DB db = new DB();
            bool flag = false;
            MySqlCommand command = new MySqlCommand($"INSERT INTO Customer (Name_org, Password, Email, Login) VALUES (@Name_org, @Password, @Email, @Login)", db.GetConnection());

            command.Parameters.AddWithValue("@Name_org", Name_org);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Login", Login);
            db.Openconnection();
            if (command.ExecuteNonQuery() == 1)
            {
                flag = true;
            }
            db.closeconnectoin();
            return flag;
        }
        public bool Add(string Product, string Id_User, string Dcc, string Price, string ID_products )
        {
            DB db = new DB();
            bool flag = false;
            MySqlCommand command = new MySqlCommand($"INSERT INTO Supply_agreement (Product, Id_User, Dcc, Price, ID_products) VALUES (@Product, @Id_User, @Dcc, @Price, @ID_products)", db.GetConnection());

            command.Parameters.AddWithValue("@Product", Product);
            command.Parameters.AddWithValue("@Id_User", Id_User);
            command.Parameters.AddWithValue("@Dcc", Dcc);
            command.Parameters.AddWithValue("@Price", Price);
            command.Parameters.AddWithValue("@ID_products", ID_products);
            db.Openconnection();
            if (command.ExecuteNonQuery() == 1)
            {
                flag = true;
            }
            db.closeconnectoin();
            return flag;
        }
    }
}