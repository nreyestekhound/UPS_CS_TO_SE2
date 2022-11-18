using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPS.Shipper.ToShipExecFromConnectShip.Entities;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace UPS.Shipper.ToShipExecFromConnectShip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCSConnectionString.Text != null && txtCSConnectionString.Text != "")
                {
                    List<cs_Shippers> csShippers = new List<cs_Shippers>();

                    SqlConnection conn = new SqlConnection(txtCSConnectionString.Text);
                    SQL_Commands sql = new SQL_Commands(conn);

                    csShippers = sql.ExcuteObject<cs_Shippers>("SELECT * FROM controller_shippers", false).ToList();

                    if (csShippers.Count > 0)
                    {
                        string result = "Shippers Fund:";
                        foreach (cs_Shippers csShipper in csShippers)
                        {
                            result += Environment.NewLine + csShipper.abbreviation;
                        }

                        txtResults.Text = result;
                        txtCSConnectionString.Enabled = false;
                        lblAppdb.Visible = true;
                        txtSEAppDB.Visible = true;
                        btnTestSE.Visible = true;

                    }
                    else
                    {
                        string result = "No Shippers Fund:";

                        txtResults.Text = result;
                    }

                }
                else
                {
                    MessageBox.Show("Please Provide ConnectShip Controller connection string");
                }
            }
            catch(Exception ex)
            {
                txtResults.Text = ex.Message;
            }
           
        }

        private void btnMigrate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(txtCSConnectionString.Text);
                SqlConnection connApp = new SqlConnection(txtSEAppDB.Text);
                SQL_Commands sql = new SQL_Commands(conn);
                string server = conn.DataSource;
                string database = conn.Database;

                string Appserver = connApp.DataSource;
                string Appdatabase = connApp.Database;

                string queryCompany = $@"select top(1) Id from [{(string)Appdatabase}].[dbo].[Company]";
                if (txtCompany.Text != null && txtCompany.Text != "")
                {
                    queryCompany = $@"select Id from [{(string)Appdatabase}].[dbo].[Company] where Symbol = '" + txtCompany.Text + "'";
                }

                string query = $@"
                insert into [{(string)Appdatabase}].[dbo].[Shipper] ([Name] ,[Symbol] ,[CompanyId] ,[SiteId] ,[Address1] ,[Address2] ,[Address3] ,[City] ,[Company]
                                                ,[Contact] ,[Country] ,[Fax] ,[Phone] ,[PostalCode],[StateProvince], PoBox,Residential,sms,CustomDataXml)
                select [abbreviation],[abbreviation],({(string)queryCompany}),NULL,[address1],[address2],[address3],[city],[Company]
                                                ,[contact], case when [countryAlias] = 'UNITED STATES' then 'US' else [countryAlias] end,[fax], [phone],[postalCode],[stateProvince], 0,0,null,null    
                FROM [{(string)database}].[dbo].[controller_shippers]

                ";


                //insert into[{ (string)Appdatabase}].[dbo].[ShipperCarriers]([ShipperId],[CarrierId])
                //SELECT S.Id, C.Id
                //FROM[{ (string)Appdatabase}].[dbo].[Shipper] S,  [{ (string)Appdatabase}].[dbo].[Carrier] C

                //Insert[{ (string)Appdatabase}].[dbo].[AdapterShipperMapping]( [ShipExecShipperId], [AdapterShipperId], [AdapterRegistrationId])
                //SELECT S.Id, A.Id, AR.ID
                //FROM[{ (string)Appdatabase}].[dbo].[Shipper] S ,   [{ (string)Appdatabase}].[dbo].[AdapterShipper] A,  [{ (string)Appdatabase}].[dbo].[AdapterRegistration] AR

                sql.Exec(query);
                txtResults.Text += Environment.NewLine + "Migration successfully!";
            }
            catch(Exception ex)
            {
                txtResults.Text = ex.Message;
            }
           
        }

        private void btnTestSE_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(txtSEAppDB.Text);
                SQL_Commands sql = new SQL_Commands(conn);
                bool isOk = sql.IsServerConnected();
                string result = "The Connection was Successful";
                if (!isOk)
                {
                    result = "The Connection was not Successful";
                }
                txtResults.Text += Environment.NewLine + result;
                txtSEAppDB.Enabled = false;
                btnMigrate.Visible = true;
                txtCompany.Visible = true;
                lblCompany.Visible = true;
            }
            catch (Exception ex) {
                txtResults.Text = ex.Message;
            }
           
        }

        
    }
}
