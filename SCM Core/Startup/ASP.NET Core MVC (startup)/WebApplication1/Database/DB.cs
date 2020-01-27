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



        public void Insert_Item_Menuf_Type(Item_Menuf_Type imt)
        {

            using (SqlConnection conn = new SqlConnection(connectString))
            {

                using (SqlCommand cmd = new SqlCommand("insert into Item_Menuf_Type values (@Mtype_id,@Icate_id,@Description)", conn))
                {

                    conn.Open();
                    cmd.Parameters.AddWithValue("@Mtype_id", imt.Mtype_id);
                    cmd.Parameters.AddWithValue("@Icate_id", imt.Icate_id);
                    cmd.Parameters.AddWithValue("@Description", imt.Description);


                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Item_Category> ItemCat_dropdown()
        {
            List<Item_Category> DBase = new List<Item_Category>();

            using (SqlConnection conn = new SqlConnection(connectString))
            {
                using (SqlCommand cmd = new SqlCommand("select c.Icate_id,c.Description from Item_Category c", conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Item_Category emp = new Item_Category();
                        emp.Item_category_id = Convert.ToInt16(reader["Icate_id"]);
                        emp.Descrption = reader["Description"].ToString();

                        DBase.Add(emp);
                    }
                }
            }
            return DBase;
        }


        //Item_Menuf_Type end


        //Item_SubCategory start

        public Item_Sub_Cateogory Item_Sub_Cateogory_id_Generate()
        {
            Item_Sub_Cateogory ads = new Item_Sub_Cateogory();
            SqlConnection con = new SqlConnection(connectString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select isnull(max(c.Isubcate_id),0)+1 isubcate from Item_SubCategory c";
            cmd.Connection = con;
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            ads.Isubcate_id = Convert.ToInt16(reader["isubcate"]);

            reader.Close();
            return ads;
        }


        public void Insert_Item_SubCategory(Item_Sub_Cateogory isc , string Status)
        {

            using (SqlConnection conn = new SqlConnection(connectString))
            {

                using (SqlCommand cmd = new SqlCommand("insert into Item_SubCategory values (@Isubcate_id,@Icate_id,@Description,@Remarks,@Status)", conn))
                {

                    conn.Open();
                    cmd.Parameters.AddWithValue("@Isubcate_id", isc.Isubcate_id);
                    cmd.Parameters.AddWithValue("@Icate_id", isc.Icate_id);
                    cmd.Parameters.AddWithValue("@Description", isc.Description);

                    if (String.IsNullOrEmpty(isc.Remarks))
                    {
                        cmd.Parameters.AddWithValue("@Remarks", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Remarks", isc.Remarks);
                    }
                    cmd.Parameters.AddWithValue("@Status", Status);


                    cmd.ExecuteNonQuery();
                }
            }
        }


        //Item_SubCategory End


        //Set_Generic start

        public Set_Generic Set_Generic_id_Generate()
        {
            Set_Generic ads = new Set_Generic();
            SqlConnection con = new SqlConnection(connectString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select isnull(max(g.Generic_id),0)+1 Set_Generic from Set_Generic g";
            cmd.Connection = con;
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            ads.Generic_id = Convert.ToInt16(reader["Set_Generic"]);

            reader.Close();
            return ads;
        }

        public void Insert_Generic(Set_Generic sg)
        {

            using (SqlConnection conn = new SqlConnection(connectString))
            {

                using (SqlCommand cmd = new SqlCommand("insert into Set_Generic values (@generic_id,@Icate_id,@Isubcate_id,@Description)", conn))
                {

                    conn.Open();
                    cmd.Parameters.AddWithValue("@generic_id", sg.Generic_id);
                    cmd.Parameters.AddWithValue("@Icate_id", sg.Icate_id);
                    cmd.Parameters.AddWithValue("@Isubcate_id", sg.Isubcate_id);
                    cmd.Parameters.AddWithValue("@Description", sg.Description);


                    cmd.ExecuteNonQuery();
                }
            }
        }


       
        public List<Item_Sub_Cateogory> Item_Sub_Cat_dropdown()
        {
            List<Item_Sub_Cateogory> DBase = new List<Item_Sub_Cateogory>();

            using (SqlConnection conn = new SqlConnection(connectString))
            {
                using (SqlCommand cmd = new SqlCommand("select s.Isubcate_id, s.Description from Item_SubCategory s", conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Item_Sub_Cateogory emp = new Item_Sub_Cateogory();
                        emp.Isubcate_id = Convert.ToInt16(reader["Isubcate_id"]);
                        emp.Description = reader["Description"].ToString();

                        DBase.Add(emp);
                    }
                }
            }
            return DBase;
        }

        //Set_Generic End


        public Scm_Supplier SCM_Supplier_id_Generate()
        {
            Scm_Supplier ads = new Scm_Supplier();
            SqlConnection con = new SqlConnection(connectString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select isnull(max(g.SUPP_id),0)+1 SUPP_id from SCM_SUPPLIER g";
            cmd.Connection = con;
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            ads.SUPP_id = Convert.ToInt16(reader["SUPP_id"]);

            reader.Close();
            return ads;
        }

        public void Insert_SCM_Supplier(Scm_Supplier ss, string R_Status)
        {

            using (SqlConnection conn = new SqlConnection(connectString))
            {

                using (SqlCommand cmd = new SqlCommand("insert into SCM_SUPPLIER values (@SUPP_id,@SUPP_CODE,@SUPPLIER,@Contact_PERSON,@Oth_Contact_PERSON,@SUPP_TYPE,@SUPP_NTN,@SUPP_EMAIL,@SUPP_FAX,@Contact_Office,@MOBILE_no,@Oth_MOBILE_no,@CNIC,@Regions,@COUNTRY,@PROVINCE,@CITY,@Area,@SUPP_ADDRESS,@INVOICE_CURRENCY,@PAY_CURRENCY,@Supp_STATUS)", conn))
                {

                    conn.Open();
                    cmd.Parameters.AddWithValue("@SUPP_id", ss.SUPP_id);
                    cmd.Parameters.AddWithValue("@SUPP_CODE", ss.SUPP_CODE);
                    cmd.Parameters.AddWithValue("@SUPPLIER", ss.SUPPLIER);
                    cmd.Parameters.AddWithValue("@Contact_PERSON", ss.Contact_PERSON);
                    cmd.Parameters.AddWithValue("@Oth_Contact_PERSON", ss.Oth_Contact_PERSON);
                    cmd.Parameters.AddWithValue("@SUPP_TYPE", ss.SUPP_TYPE);
                    cmd.Parameters.AddWithValue("@SUPP_NTN", ss.SUPP_NTN);
                    cmd.Parameters.AddWithValue("@SUPP_EMAIL", ss.SUPP_EMAIL);
                    cmd.Parameters.AddWithValue("@SUPP_FAX", ss.SUPP_FAX);
                    cmd.Parameters.AddWithValue("@Contact_Office", ss.Contact_Office);
                    cmd.Parameters.AddWithValue("@MOBILE_no", ss.MOBILE_no);
                    cmd.Parameters.AddWithValue("@Oth_MOBILE_no", ss.Oth_MOBILE_no);
                    cmd.Parameters.AddWithValue("@CNIC", ss.CNIC);
                    cmd.Parameters.AddWithValue("@Regions", ss.Regions);
                    cmd.Parameters.AddWithValue("@COUNTRY", ss.COUNTRY);
                    cmd.Parameters.AddWithValue("@PROVINCE", ss.PROVINCE);
                    cmd.Parameters.AddWithValue("@CITY", ss.CITY);
                    cmd.Parameters.AddWithValue("@Area", ss.Area);
                    cmd.Parameters.AddWithValue("@SUPP_ADDRESS", ss.SUPP_ADDRESS);
                    cmd.Parameters.AddWithValue("@INVOICE_CURRENCY", ss.INVOICE_CURRENCY);
                    cmd.Parameters.AddWithValue("@PAY_CURRENCY", ss.PAY_CURRENCY);
                    cmd.Parameters.AddWithValue("@Supp_STATUS", R_Status);



                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
