﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TATBilgiTeknolojileri.PocosLayer;
using TATBilgiTeknolojileri.BusinessLogicLayer;
using TATBilgiTeknolojileri.DataAccessObjects;
using System.Data.SqlClient;

namespace TATBilgiTeknolojileri.PresentationLayer
{
    public partial class frmServisTakipKayitSilme : Form
    {
        private TblServisTakipBLL _TblServisTakipBLL;

        public frmServisTakipKayitSilme()
        {
            InitializeComponent();
            _TblServisTakipBLL = new TblServisTakipBLL();
        }

        public void Listele()
        {
            VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();

            SqlCommand sorgu = new SqlCommand("Select * from Tbl_ServisTakip", yeniBaglanti.baglanti);

            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu);
            adapter.Fill(dataTable);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            TblServisTakipPoco ServisTakip = new TblServisTakipPoco();
            ServisTakip = _TblServisTakipBLL.silServisTakip(Convert.ToInt32(txtID.Text));
            MessageBox.Show("Silme Islemi Tamamlanmistir...");
            Listele();
        }

        private void frmServisTakipKayitSilme_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtMarkaModel.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtReferansNo.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtIlgiliDepartmanKisi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAciklama.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtOnarim.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtIlgiliFirma.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtGonderilisTarihi.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtAlinisTarihi.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtSonuc.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }
    }
}
