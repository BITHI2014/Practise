using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeStoreApp.DBModule.DAO;

namespace EmployeeStoreApp.DBModule.DBGateway
{
    class DesignationGateway
    {
        private const string myConnectionString =
            @"data source=LAB2\SQLEXPRESS; initial catalog=EmployeeDB; integrated security=true;";
        private SqlConnection mySqlConnection = new SqlConnection(myConnectionString);
        private SqlCommand aSqlCommand;
        private SqlDataReader aSqlDataReader;
        public void AddDesignation(Designation aDesignation)
        {
            string insertQuery = "insert into tbl_designation values('" + aDesignation.Code + "','" + aDesignation.Title +
                                 "')";
            mySqlConnection.Open();
            aSqlCommand=new SqlCommand(insertQuery,mySqlConnection);
            aSqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
        }

        public List<Designation> GetDesignationList()
        {
            List<Designation> designations=new List<Designation>();
            string selectQuery = "select * from tbl_designation";
            mySqlConnection.Open();
            aSqlCommand = new SqlCommand(selectQuery, mySqlConnection);
            aSqlDataReader = aSqlCommand.ExecuteReader();
            while (aSqlDataReader.Read())
            {
                Designation designationFound = new Designation();
                designationFound.Id = Convert.ToInt32(aSqlDataReader["id"]);
                designationFound.Code = aSqlDataReader["code"].ToString();
                designationFound.Title = aSqlDataReader["title"].ToString();
                designations.Add(designationFound);
            }
            mySqlConnection.Close();
            return designations;
        }

        public Designation GetDesignation(string designationCode)
        {
            foreach (Designation designation in GetDesignationList())
            {
                if (designation.Code == designationCode)
                    return designation;
            }
            return null;
        }
        public Designation GetDesignation(int designationId)
        {
            foreach (Designation designation in GetDesignationList())
            {
                if (designation.Id == designationId)
                    return designation;
            }
            return null;
        }
    }
}
