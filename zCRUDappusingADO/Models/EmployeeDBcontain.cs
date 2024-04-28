using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Xml.Linq;

namespace zCRUDappusingADO.Models
{
    public class EmployeeDBcontain
    {
        string cn = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

        public List<Employee> getEmployees()
        {
            List<Employee> emplist = new List<Employee>();
            SqlConnection con = new SqlConnection(cn);
            SqlCommand cmd = new SqlCommand("allemployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(dr.GetValue(0).ToString());
                emp.Name = dr.GetValue(1).ToString();
                emp.Salary = Convert.ToInt32(dr.GetValue(2).ToString());
                emp.gender = dr.GetValue(3).ToString();
                emp.Department = Convert.ToInt32(dr.GetValue(4).ToString());
                emplist.Add(emp);

            }
            
            con.Close();
            return emplist;
        }
        public bool addEmploye(Employee emp)
        {
            SqlConnection con = new SqlConnection(cn);
            SqlCommand cmd = new SqlCommand("inserEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name",emp.Name);
            cmd.Parameters.AddWithValue("@Salary", emp.Salary);
            cmd.Parameters.AddWithValue("@Gender", emp.gender);
            cmd.Parameters.AddWithValue("@Department", emp.Department);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool updateEmployee(Employee emp) 
        {
            SqlConnection conn=new SqlConnection(cn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("updateEmp", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id",emp.Id);
            cmd.Parameters.AddWithValue("@Name",emp.Name);
            cmd.Parameters.AddWithValue("@Salary", emp.Salary);
            cmd.Parameters.AddWithValue("@Gender", emp.gender);
            cmd.Parameters.AddWithValue("@Department", emp.Department);

            int i =cmd.ExecuteNonQuery();
            conn.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool deleteEmploye(int id)
        {
            SqlConnection conn = new SqlConnection(cn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("DeleteEmp",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            int i = cmd.ExecuteNonQuery();
            if (i>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}