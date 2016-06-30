using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace UploadTestSpeed.Models
{    
    public class connection
    {
        private SqlConnection conn;
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        } 

        public connection  ()
        {
            string conexion = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            conn = new SqlConnection(conexion); 
   
        }

        public void insertar (string name ,string tipo , Byte [] data )
        {
           
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into testData(Name,TypeOfData,Data) values(@nombre,@tipo,@data) ",conn);
                cmd.Parameters.AddWithValue("@nombre",name);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@data", data);
                cmd.ExecuteNonQuery(); 

            }
            catch (SqlException ex) 
            {
                message = ex.ToString();
            }
            finally 
            {
                conn.Close();
            }
        } // Carga Individual 

        // Crga enviado multiples archivos 
        public void insertar(Byte[] data1, Byte[] data2, Byte[] data3, Byte[] data4, Byte[] data5,Byte[] data6,string nombre ,string ext , string value1,string value2 , string value3 )
        {
       

            try
            {
                conn.Open() ;
                    SqlCommand cmd = new SqlCommand("UploadFileIU",conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@file1",data1);
                    cmd.Parameters.AddWithValue("@file2", data2);
                    cmd.Parameters.AddWithValue("@file3", data3);
                    cmd.Parameters.AddWithValue("@file4", data4);
                    cmd.Parameters.AddWithValue("@file5", data5);
                    cmd.Parameters.AddWithValue("@file6", data6);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@extension", ext);
                    cmd.Parameters.AddWithValue("@fecha", "06/28/2016");
                    cmd.Parameters.AddWithValue("@value1", value1);
                    cmd.Parameters.AddWithValue("@value2", value2);
                    cmd.Parameters.AddWithValue("@value3", value3);   
               cmd.ExecuteNonQuery();
               
                   
                    
            }
            catch (SqlException ex) 
            {
                message = ex.ToString();
            }
            finally 
            {
                conn.Close();
            }
        }
    }
}