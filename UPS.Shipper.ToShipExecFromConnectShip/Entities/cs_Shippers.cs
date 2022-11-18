using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace UPS.Shipper.ToShipExecFromConnectShip.Entities
{
    public class cs_Shippers
    {
        public int id { get; set; }
        public string company { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string address3 { get; set; }
        public string city { get; set; }
        public string stateProvince { get; set; }
        public string postalCode { get; set; }
        public string countrySymbol { get; set; }
        public string countryAlias { get; set; }
        public string contact { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string abbreviation { get; set; }


        public cs_Shippers(DataRow row)
        {
            this.id = Convert.ToInt32(row["id"]);
            this.company = row["company"].ToString();
            this.address1 = row["address1"].ToString();
            this.address2 = row["address2"].ToString();
            this.address3 = row["address3"].ToString();
            this.city = row["city"].ToString();
            this.stateProvince = row["stateProvince"].ToString();
            this.postalCode = row["postalCode"].ToString();
            this.countrySymbol = row["countrySymbol"].ToString();
            this.countryAlias = row["countryAlias"].ToString();
            this.contact = row["contact"].ToString();
            this.fax = row["fax"].ToString();
            this.abbreviation = row["abbreviation"].ToString();

        }
    }
}

