using System;
using System.Windows.Forms;
using PasSDK;
namespace AirTimeCityJrnlManager
{
    public partial class Form1 : Form
    {
        public static PastelPartnerSDK SDK = new PastelPartnerSDK();
        string itemline = "";
        public Form1()
        {
            InitializeComponent();
        }

        private string Authenticate()
        {
            SDK.SetLicense(txtLicense.Text, txtSerial.Text);
            string strReturn = SDK.SetDataPath(txtDataPath.Text);
            return strReturn;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SDK.SetLicense(txtLicense.Text, txtSerial.Text);
            string strReturn = SDK.SetDataPath(txtDataPath.Text);
            if (strReturn.StartsWith("0"))
            {
                MessageBox.Show("Yay, Connected");
                return;
            }
            else
            {
                MessageBox.Show("Err - " + strReturn);
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtItemCode.Text.Length > 0)
            {
                Authenticate();
                string itemcode = txtItemCode.Text.Trim();
                string argFileName = "ACCPRD";
                short argKeyNumber = 0;
                itemline = SDK.GetNearest(ref argFileName, ref argKeyNumber, ref itemcode);
                txtResult.Text = itemline;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtCustCode.Text.Length > 0)
            {
                Authenticate();
                string AccCode = txtCustCode.Text.Trim().PadRight(6);
                string argFileName = "ACCMASD";
                short argKeyNumber = 0;
                itemline = SDK.GetRecord(ref argFileName, ref argKeyNumber, ref AccCode);
                txtResult.Text = itemline;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string StrReturn = string.Empty;
            StrReturn = Authenticate();

            if (StrReturn.StartsWith("0"))
            {
                SDK.OpenDocumentFiles();
            } else
            {
                MessageBox.Show("Error 1 " + StrReturn);
               return;
            }
                StrReturn = SDK.DefineDocumentHeader("||Y|ACK001|05/08/2024||N|0|Message no.1|Message no.2|Message no.3|Delivery no.1|Delivery no.2|Delivery no.3|Delivery no.4|Delivery no.5||00||05/03/1999|011-7402156|Johnny|011-7402157|1");
            
                if (StrReturn.StartsWith("0"))
                {
                    StrReturn = SDK.DefineDocumentLine("0|1|1043|667||15|||ACC/LOC|Toc Deep Sleep|4|JHB|");
                }
            else
            {
                MessageBox.Show("Error 2 " + StrReturn);
                return;
            }
            StrReturn = SDK.ImportDocument(102);
            MessageBox.Show(StrReturn);
            SDK.CloseDocumentFiles();
        }
    }
}
