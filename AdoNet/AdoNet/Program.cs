using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace AdoNet
{
     class Program
    { 
        static void Main(string[] args)
        {
            
                string ConString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
            try
            {
                Console.WriteLine("Connection Established");
                string rtv;

                do
                {
                    Console.WriteLine("Select For Option: 1.Create\n 2.Retrive\n 3.Update\n 4.Delete\n 5.Search\n 6.proceedInsert\n");
                    int ch = int.Parse(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            Console.WriteLine("Enter Teacher Id");
                            int tid = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Teacher Name");
                            string tname = Console.ReadLine();
                            Console.WriteLine("Enter Teacher Email");
                            string temail = Console.ReadLine();
                            string insertQuery = "INSERT INTO teacher(id,name,email) values(" + tid + ",'" + tname + "','" + temail + "')";
                            //string insertQuery = "insert into teacher (id, name, email) values ('104', 'Ronaldo', 'ronaldo@example.com')";
                            SqlCommand insertCommand = new SqlCommand(insertQuery, con);
                            insertCommand.ExecuteNonQuery();
                            Console.WriteLine("Data Inserted");
                            break;
                        case 2:
                            string displayQuery = "Select * from teacher";
                            SqlCommand displayCommand = new SqlCommand(displayQuery, con);
                            SqlDataReader reader = displayCommand.ExecuteReader();
                            while (reader.Read())
                            {
                                Console.WriteLine("id :" + reader.GetValue(0).ToString());
                                Console.WriteLine("name :" + reader.GetValue(1).ToString());
                                Console.WriteLine("email :" + reader.GetValue(2).ToString());
                            }
                            reader.Close();
                            break;
                        case 3:

                            Console.WriteLine("Enter Teacher Id");
                            int t_id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Teacher Email");
                            string t_email = Console.ReadLine();
                            string updateQuery = "UPDATE teacher SET email = ' " + t_email + " ' Where id = " + t_id + "";
                            SqlCommand updateCommand = new SqlCommand(updateQuery, con);
                            updateCommand.ExecuteNonQuery();
                            Console.WriteLine("Data Updated");
                            break;
                        case 4:
                            Console.WriteLine("Enter Teacher Id");
                            int d_id = int.Parse(Console.ReadLine());
                            string deleteQuery = "Delete From teacher where Id = " + d_id;
                            SqlCommand deleteCommand = new SqlCommand(deleteQuery, con);
                            deleteCommand.ExecuteNonQuery();
                            Console.WriteLine("Delete  SucessFully");
                            break;
                        case 5:
                            Console.WriteLine("Enter Teacher Id");
                            int s_id = int.Parse(Console.ReadLine());
                            string searchQuery = "Select name,email From teacher where Id = " + s_id;
                            SqlCommand searchCommand = new SqlCommand(searchQuery, con);
                            searchCommand.ExecuteNonQuery();
                            Console.WriteLine("Delete  SucessFully");
                            break;
                        case 6:
                            Console.WriteLine("Enter Teacher Id");
                            int te_id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Teacher Name");
                            string te_name = Console.ReadLine();
                            Console.WriteLine("Enter Teacher Email");
                            string te_email = Console.ReadLine();
                            SqlCommand proceedcmd = new SqlCommand("insertData", con);
                            proceedcmd.CommandType = CommandType.StoredProcedure;
                            proceedcmd.Parameters.AddWithValue("@id", te_id);
                            proceedcmd.Parameters.AddWithValue("@name", te_name);
                            proceedcmd.Parameters.AddWithValue("@email", te_email);
                            proceedcmd.ExecuteNonQuery();
                            Console.WriteLine("Data Inserted");
                            break;

                        default:
                            Console.WriteLine("Wrong Input");
                            break;

                    }
                    Console.WriteLine("Do you Want to Continue:");
                    rtv = Console.ReadLine();
                } while (rtv != "no");
            }
                    catch (Exception ex)
                { 
                Console.WriteLine(ex.Message);
                }
            finally
            {
                con.Close();
            }
            Console.ReadKey();
        }
     }
}
    
 

