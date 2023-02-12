using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace InventoryBase
{
    public partial class HomePage : Form
    {
        public string Id; 
        public string HardWareNo;
        public string Brand;
        public string Model;
        public string SerialNumber;
        public string FaultStatus;
        public string Date;

        private void ClearTextBoxs()
        {
            //Metin kutuları temizlenir
            Id = null;
            txtBoxBrand.Clear();
            txtBoxDate.Clear();
            txtBoxHardwareNo.Clear();
            txtFaultStatus.Clear();
            txtModel.Clear();
            txtSerialNo.Clear(); 
        }
        public HomePage()
        {
            InitializeComponent();
        }
        DeviceLogs device = new DeviceLogs();
        private void HomePage_Load(object sender, EventArgs e)
        {
            dataGridViewDeviceLogs.DataSource = device.Fill();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearTextBoxs();
        }

        private void dataGridViewDeviceLogs_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewDeviceLogs.SelectedRows)
            {
                Id = row.Cells[0].Value.ToString();
                HardWareNo = row.Cells[1].Value.ToString();
                Brand = row.Cells[2].Value.ToString();
                Model = row.Cells[3].Value.ToString();
                SerialNumber = row.Cells[4].Value.ToString();
                FaultStatus = row.Cells[5].Value.ToString();
                Date = row.Cells[6].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Boş değer kontrolü
            if( txtBoxHardwareNo.Text == String.Empty || txtBoxBrand.Text == String.Empty || txtFaultStatus.Text == String.Empty|| txtModel.Text == String.Empty||txtSerialNo.Text == String.Empty|| txtBoxDate.Text== String.Empty)
            {
                MessageBox.Show("Lütfen alanları doldurunuz");
            }
            else
            {
                //Id var ise güncelleme yok ise ekleme işlemi gerçekleştirilir
                if(Id != null)
                {
                    device.Update(Convert.ToInt32(Id), txtBoxHardwareNo.Text, txtBoxBrand.Text, txtModel.Text, txtSerialNo.Text, txtFaultStatus.Text, txtBoxDate.Text);
                }
                else
                {
                    device.Add(txtBoxHardwareNo.Text, txtBoxBrand.Text, txtModel.Text, txtSerialNo.Text, txtFaultStatus.Text, txtBoxDate.Text);
                }
                dataGridViewDeviceLogs.DataSource = device.Fill();
                this.ClearTextBoxs();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Silme işlemi Id alınarak gerçekliştirilir.
            device.Delete(Convert.ToInt32(Id));
            dataGridViewDeviceLogs.DataSource = device.Fill();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Seçili item dan id alınmış ise metin kutuları doldurulur.
            if (Id != null)
            {
                txtBoxHardwareNo.Text = HardWareNo;
                txtBoxBrand.Text = Brand;
                txtModel.Text = Model;
                txtSerialNo.Text = SerialNumber;
                txtFaultStatus.Text = FaultStatus;
                txtBoxDate.Text = Date;
            }
            else
            {
                MessageBox.Show("Please Select Item!");
            }
        }
    }
}
