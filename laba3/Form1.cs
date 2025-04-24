using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_3
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            Phone phone = new Phone(); fPhone ft = new fPhone(phone);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                tbPhonesInfo.Text +=
                string.Format("Модель: {0}. Діагональ: {1}. Кількість ядер: {2}. Платформа: {3}." +
                "Кількість СІМ-карт: {4}. [{5}|{6}]" +
                "Чи телефон має рівно 4 ядра? - {7}\r\n",
                phone.Model, phone.Diagonal, phone.Cores, phone.Platform,
                phone.SimQuantity, phone.HasAI ? "Має ШІ" : "Не має ШІ",
                phone.HasTypeC ? "Має Type-C" : "Не має Type-C", phone.Has4Cores());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?", "Припинити роботу",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                DialogResult.OK)
                Application.Exit();
        }
    }
}
