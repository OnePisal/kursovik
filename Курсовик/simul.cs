using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
        public bool Add(string Qugo, string Tip_go, string Type, string Price)
        {
            DB db = new DB();
            bool flag = false;
            MySqlCommand command = new MySqlCommand($"INSERT INTO sklad (Qugo, Tip_go, Type, Price) VALUES (@Qugo, @Tip_go, @Type, @Price)", db.GetConnection());

            command.Parameters.AddWithValue("@Qugo", Qugo);
            command.Parameters.AddWithValue("@Tip_go", Tip_go);
            command.Parameters.AddWithValue("@Type", Type);
            command.Parameters.AddWithValue("@Price", Price);
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