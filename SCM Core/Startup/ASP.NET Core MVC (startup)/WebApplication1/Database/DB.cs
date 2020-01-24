using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WebApplication1.Database;
using WebApplication1.Models;

namespace WebApplication1.Database
{
    public class DB
    {
        string connectString = DBConnection.connectString;


        //Item_Category Start

        public Item_Category Item_category_id_Generate()
        {
            Item_Category ads = new Item_Category();
            SqlConnection con = new SqlConnection(connectString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select isnull(max(c.Icate_id),0)+1 I_Cate from Item_Category c";
            cmd.Connection = con;
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            ads.Item_category_id = Convert.ToInt16(reader["I_Cate"]);

            reader.Close();
            return ads;
        }



        public void Insert_Item_Category(Item_Category ic, string Status)
        {

            using (SqlConnection conn = new SqlConnection(connectString))
            {

                using (SqlCommand cmd = new SqlCommand("insert into Item_Category values (@Icate,@Descrption,@Status)", conn))
                {

                    conn.Open();
                    cmd.Parameters.AddWithValue("@Icate", ic.Item_category_id);
                    cmd.Parameters.AddWithValue("@Descrption", ic.Descrption);
                    cmd.Parameters.AddWithValue("@Status", Status);


                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Item_Category End


        //Item_Menuf_Type start
        public Item_Menuf_Type Item_Menuf_type_id_Generate()
        {
            Item_Menuf_Type ads = new Item_Menuf_Type();
            SqlConnection con = new SqlConnection(connectString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select isnull(max(c.Mtype_id),0)+1 Mtype_id from Item_Menuf_Type c";
            cmd.Connection = con;
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            ads.Mtype_id = Convert.ToInt16(reader["Mtype_id"]);

            reader.Close();
            return ads;
        }
    }
}
