using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Breaddit.Models
{
    public class SliceRepo : ISliceRepo
    {
        private string _connString = ConfigurationManager.ConnectionStrings["BreadditDB"].ConnectionString;
        private IList<Slice> _sliceList;

        public SliceRepo()
        {
            if (Equals(_sliceList, null))
            {
                _sliceList = new List<Slice>();
            }
        }

        public bool addSlice(Slice slice)
        {
            throw new NotImplementedException();
            var retval = false;

            using (var con = new SqlConnection(_connString))
            {
                //
                // set-up command
                var cmd = new SqlCommand("addnewslice", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //
                // define storedproc parameters
                cmd.Parameters.AddWithValue("@name", slice.name);
                cmd.Parameters.AddWithValue("@description", slice.description);
                cmd.Parameters.AddWithValue("@followers", slice.followers);
                cmd.Parameters.AddWithValue("@userId", slice.userID);
                //
                // open db connection
                con.Open();
                //
                // execute command
                int i = cmd.ExecuteNonQuery();

                if (i >= 1)
                {
                    retval = true;
                }
            }

            return retval;
        }

        public bool deleteSlice(int sliceID)
        {
            throw new NotImplementedException();
            //var retVal = false;

            //using (var con = new SqlConnection(_connString))
            //{
            //    var cmd = new SqlCommand("DeleteSlice", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    
            //    cmd.Parameters.AddWithValue("@sliceId", sliceID);
            //
            //    con.Open();
            //    //
            //    // Execute command
            //    int i = cmd.ExecuteNonQuery();

            //    if (i >= 1)
            //    {
            //        retVal = true;
            //    }
            //}
            //
            //return retVal;
        }

        public IEnumerable<Slice> GetAllSlices()
        {
            using (var con = new SqlConnection(_connString))
            {
                var cmd = new SqlCommand("SELECT * FROM StudentInfo", con);
                cmd.CommandType = CommandType.Text;

                con.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    var slice = new Slice();

                    slice.ID = Convert.ToInt32(rdr["Id"]);
                    slice.name = rdr["Name"].ToString();
                    slice.description = rdr["Description"].ToString();
                    slice.followers = Convert.ToInt32(rdr["Followers"]);
                    slice.userID = Convert.ToInt32(rdr["UserID"]);

                    _sliceList.Add(slice);
                }
            }

            return _sliceList;
        }

        public Slice GetSlice(int sliceID)
        {
            Slice sliceDetails;

            using (var con = new SqlConnection(_connString))
            {
                var cmd = new SqlCommand("GetSliceDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@sliceId", sliceID);

                con.Open();

                var rdr = cmd.ExecuteReader(CommandBehavior.SingleRow);

                rdr.Read();

                sliceDetails = new Slice
                {
                    ID = Convert.ToInt32(rdr["id"])
                    ,
                    name = Convert.ToString(rdr["Name"])
                    ,
                    description = Convert.ToString(rdr["Description"])
                    ,
                    followers = Convert.ToInt32(rdr["Followers"])
                    ,
                    userID = Convert.ToInt32(rdr["UserID"])
                };

            }
            return sliceDetails;
        }

        public bool updateSlice(Slice slice)
        {
            var retVal = false;

            using (var con = new SqlConnection(_connString))
            {
                var cmd = new SqlCommand("UpdateSlice", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@sliceId", slice.ID);
                cmd.Parameters.AddWithValue("@Name", slice.name);
                cmd.Parameters.AddWithValue("@Description", slice.description);
                cmd.Parameters.AddWithValue("@Followers", slice.followers);
                cmd.Parameters.AddWithValue("@UserID", slice.userID);

                con.Open();

                int i = cmd.ExecuteNonQuery();

                if (i >= 1)
                {
                    retVal = true;
                }
            }

            return retVal;
        }
    }
}
