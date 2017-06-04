using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDIntegratedApplication.Tag
{
    class FrequencyTable
    {
        public DataTable frequencies;

        public FrequencyTable()
        {
            frequencies = new DataTable("frequencies");
            frequencies.Columns.Add("time");
            frequencies.Columns.Add("respiration");
            frequencies.Columns.Add("heartbeat");
            
        }

        public void add(double breath, double heartbeat,string time)
        {
            DataRow row = frequencies.NewRow();
            row["respiration"] = breath;
            row["heartbeat"] = heartbeat;
            row["time"] = time;
            frequencies.Rows.Add(row);
        }

        public void clear()
        {
            frequencies.Clear();
           
        }
    }
}
