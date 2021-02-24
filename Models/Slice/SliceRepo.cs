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
        //private string _connString = ConfigurationManager.ConnectionStrings["BreadditDB"].ConnectionString;
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
            //var retval = false;

            //using (var con = new sqlconnection(_connstring))
            //{
            //    //
            //    // set-up command
            //    var cmd = new sqlcommand("addnewslice", con);
            //    cmd.commandtype = commandtype.storedprocedure;
            //    //
            //    // define storedproc parameters
            //    cmd.parameters.addwithvalue("@name", slice.name);
            //    cmd.parameters.addwithvalue("@description", slice.description);
            //    //
            //    // open db connection
            //    con.open();
            //    //
            //    // execute command
            //    int i = cmd.executenonquery();

            //    if (i >= 1)
            //    {
            //        retval = true;
            //    }
            //}

            //return success / failure
            //return retval;
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
            throw new NotImplementedException();
        }

        public bool updateSlice(Slice slice)
        {
            throw new NotImplementedException();
        }
    }
}
