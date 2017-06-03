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
            frequencies.Columns.Add("respiration");
            frequencies.Columns.Add("heartbeat");
        }

        public void add(int breath, int heartbeat)
        {
            DataRow row = frequencies.NewRow();
            row["respiration"] = breath;
            row["heartbeat"] = heartbeat;

            frequencies.Rows.Add(row);
        }

        public void clear()
        {
            frequencies.Clear();
           
        }
    }
}
