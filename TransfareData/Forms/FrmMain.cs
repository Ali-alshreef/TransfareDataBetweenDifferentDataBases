using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransfareData.Data1;
using TransfareData.Data2;

namespace TransfareData.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        TranfareContextDB2 db2 = new TranfareContextDB2();
        List<DraiverNames> draiverNames;

        private void FrmMain_Load(object sender, EventArgs e)
        {
            btnTrnsfarDataToDB2.Enabled = false;
            btnSaveChanges.Enabled = false;
            btnTrnsfarDataToDB2.BackColor = Color.Red;
            btnSaveChanges.BackColor = Color.Red;
        }

        private void btnLoadDataFromDB1_Click(object sender, EventArgs e)
        {
            TranfareContextDB1 db1 = new TranfareContextDB1();
            draiverNames = db1.DraiverNames.ToList();
            draiverNamesBindingSource.DataSource = draiverNames;
            if (draiverNames.Count > 0)
            {
                lblD1Count.Text = draiverNames.Count().ToString();
                btnTrnsfarDataToDB2.Enabled = true;
                btnTrnsfarDataToDB2.BackColor = Color.Yellow;
            }
        }

        private void btnTrnsfarDataToDB2_Click(object sender, EventArgs e)
        {
            
            DateTime dtnow = DateTime.Now;
            List<Merchants> merchants = new List<Merchants>();

            foreach (var item in draiverNames)
            {
                merchants.Add(new Merchants
                {
                    FullName = item.DraiverName,
                    Phone1 = item.PhoneNumber,
                    Phone2 = null,
                    Cityid = null,
                    Balance = 0,
                    IsDraiver = true,
                    IsClient = false,
                    IsCustomer = false,
                    IsSupplier = false,
                    IsOwnerGoods = false,
                    UserId = 1,
                    MachineName = null,
                    CreateBy = "Admin",
                    CreateOn = dtnow,
                    Notes = item.Notes,

                });
            }
            merchantsBindingSource.DataSource = merchants;
            if (merchants.Count() > 0)
            {
                db2.Merchants.AddRange(merchants);
                lblD2Count.Text = merchants.Count().ToString();
                btnSaveChanges.Enabled = true;
                btnSaveChanges.BackColor = Color.Green;
            }


        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                db2.SaveChanges();
                MessageBox.Show("Success To Trnsfar Data To DB2");
                btnSaveChanges.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Error On SaveChanges ");
            }
        }

    }
}
