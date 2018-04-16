using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CSHARPDICEGAME
{
    class MYSQL
    {
        private string sqlString = "";
        public MYSQL()
        {

        }
        private string Player1, Player2;

        private int Dice_WinsUpdate(string FirstName,string LastName)
        {
            int returnValue = -1;
            using (SqlConnection myConnection = new SqlConnection(sqlString))
            {
                string commandtextBuidler = "Select Dice_Wins from MyClass Where FirstName = '" + FirstName + "' and LastName = '" + LastName + "'";
                Console.WriteLine(commandtextBuidler);
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandType = System.Data.CommandType.Text;
                myCommand.CommandText = commandtextBuidler;
                returnValue = Convert.ToInt32(myCommand.ExecuteScalar());
                myConnection.Close();
            }
            Console.WriteLine(returnValue);
            return returnValue;
        }

        public void updatePlayerWins(string FirstName,string LastName)
        {
            SqlCommand myCommand = new SqlCommand();
            myCommand.ExecuteNonQuery();
        }
    }
}
