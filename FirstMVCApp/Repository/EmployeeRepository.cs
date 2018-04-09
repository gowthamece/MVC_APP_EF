using FirstMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FirstMVCApp.Repository
{
    //public class EmployeeRepository
    //{
    //    private SqlConnection con;
    //    //To Handle connection related activities    
    //    private void connection()
    //    {
    //        string constr = ConfigurationManager.ConnectionStrings["getconn"].ToString();
    //        con = new SqlConnection(constr);

    //    }
    //    //To Add Employee details    
    //    public bool AddEmployee(Employee obj)
    //    {

    //        connection();
    //        SqlCommand com = new SqlCommand("stp_AddNewEmpDetails", con);
    //        com.CommandType = CommandType.StoredProcedure;
    //        com.Parameters.AddWithValue("@FirstName", obj.FirstName);
    //        com.Parameters.AddWithValue("@LastName", obj.LastName);
    //        com.Parameters.AddWithValue("@Email ", obj.Email);
    //        com.Parameters.AddWithValue("@Password",obj.Password);
    //        com.Parameters.AddWithValue("@Age", obj.Age);

    //        con.Open();
    //        int i = com.ExecuteNonQuery();
    //        con.Close();
    //        if (i >= 1)
    //        {

    //            return true;

    //        }
    //        else
    //        {

    //            return false;
    //        }


    //    }
    //    //To view employee details with generic list     
    //    public List<Employee> GetAllEmployees()
    //    {
    //        connection();
    //        List<Employee> EmpList = new List<Employee>();


    //        SqlCommand com = new SqlCommand("stp_GetEmployees", con);
    //        com.CommandType = CommandType.StoredProcedure;
    //        SqlDataAdapter da = new SqlDataAdapter(com);
    //        DataTable dt = new DataTable();
    //       // DataSet ds = new DataSet();
    //        con.Open();
    //        da.Fill(dt);
    //        con.Close();
    //        //Bind EmpModel generic list using dataRow     
    //        foreach (DataRow dr in dt.Rows)
    //        {

    //            EmpList.Add(

    //                new Employee
    //                {

    //                    EmployeeID=Convert.ToInt32(dr["EmployeeID"]),
    //                    FirstName = Convert.ToString(dr["FirstName"]),
    //                    LastName = Convert.ToString(dr["LastName"]),
    //                    Email = Convert.ToString(dr["Email"]),
    //                    Age=Convert.ToString(dr["Age"])

    //                }


    //                );


    //        }

    //        return EmpList;


    //    }
    //    //To Update Employee details    
    //    public bool UpdateEmployee(Employee obj)
    //    {

    //        connection();
    //        SqlCommand com = new SqlCommand("stp_UpdateEmpDetails", con);

    //        com.CommandType = CommandType.StoredProcedure;
    //        com.Parameters.AddWithValue("@EmpId", obj.EmployeeID);
    //        com.Parameters.AddWithValue("@FirstName", obj.FirstName);
    //        com.Parameters.AddWithValue("@LastName", obj.LastName);
    //        com.Parameters.AddWithValue("@Password", obj.Password);
    //        com.Parameters.AddWithValue("@Email", obj.Email);
    //        com.Parameters.AddWithValue("@Age", obj.Age);
    //        con.Open();
    //        int i = com.ExecuteNonQuery();
    //        con.Close();
    //        if (i >= 1)
    //        {

    //            return true;

    //        }
    //        else
    //        {

    //            return false;
    //        }


    //    }
    //    //To delete Employee details    
    //    public bool DeleteEmployee(int Id)
    //    {
    //        try
    //        {
    //            connection();
    //            SqlCommand com = new SqlCommand("stp_DeleteEmpById", con);

    //            com.CommandType = CommandType.StoredProcedure;
    //            com.Parameters.AddWithValue("@EmpId", Id);

    //            con.Open();
    //            int i = com.ExecuteNonQuery();
    //            con.Close();
    //            if (i >= 1)
    //            {

    //                return true;

    //            }
    //            else
    //            {

    //                return false;
    //            }
    //        }
    //        catch(Exception ex)
    //        {
    //            return false;
    //        }
    //        finally
    //        {
    //            con.Dispose();
    //        }

    //    }
    //}
}
