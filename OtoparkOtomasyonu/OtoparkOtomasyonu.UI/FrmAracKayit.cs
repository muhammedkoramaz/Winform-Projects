using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyonu.UI
{
    public partial class FrmAracKayit : Form
    {
        public FrmAracKayit()
        {
            InitializeComponent();
        }

        private void FrmAracKayit_Load(object sender, EventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close(); //iptale basıldığında form kapanacak 
        }
    }
}
