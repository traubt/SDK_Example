using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirTimeCityJrnlManager.Properties;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Spreadsheet;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PasSDK;
namespace SDKSample
{
    public partial class Form1 : Form
    {
        public static PastelPartnerSDK SDK = new PastelPartnerSDK();
        string itemline = "";
        public Form1()
        {
            InitializeComponent();
            txtLicense.Text = Settings.Default.SDKLicense;
            txtSerial.Text = Settings.Default.AuthKey;
            txtDataPath.Text = Settings.Default.DataPath;
        }

        private string Authenticate()
        {
            SDK.SetLicense(txtLicense.Text, txtSerial.Text);
            string strReturn = SDK.SetDataPath(txtDataPath.Text);
            return strReturn;
        }

        private void button1_Click(object sender, EventArgs e) // test connection
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

        private void button2_Click(object sender, EventArgs e) // get inventory item
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

        private void button3_Click(object sender, EventArgs e) // get customer
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

        private void button2_Click_1(object sender, EventArgs e) // create sales order
        {
            string StrReturn = string.Empty;
            StrReturn = Authenticate();

            if (StrReturn.StartsWith("0"))
            {
                SDK.OpenDocumentFiles();
            }
            else
            {
                MessageBox.Show("Error 1 " + StrReturn);
                return;
            }
            StrReturn = SDK.DefineDocumentHeader("||Y|ONL001|05/08/2024||N|0|Message no.1|Message no.2|Message no.3|Delivery no.1|Delivery no.2|Delivery no.3|Delivery no.4|Delivery no.5||00||05/03/1999|011-7402156|Johnny|011-7402157|1");

            if (StrReturn.StartsWith("0"))
            {
                StrReturn = SDK.DefineDocumentLine($"0|{txtQty.Text.ToString()}|{txtUnitP.Text.ToString()}|||15|||{txtCode.Text.ToString()}|Toc Deep Sleep|4|{txtStore.Text.ToString()}|");
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

        private void btnSaveSett_Click(object sender, EventArgs e)
        {
            Settings.Default.SDKLicense = txtLicense.Text;
            Settings.Default.AuthKey = txtSerial.Text;
            Settings.Default.DataPath = txtDataPath.Text;
            MessageBox.Show("Saved");
        }

        private void button4_Click(object sender, EventArgs e) // create new customer
        {
            string StrReturn = string.Empty;
            StrReturn = Authenticate();
            StrReturn = SDK.ImportCustomer(txtNewCC.Text.PadRight(6) +"|Van's Truck Hire|114 Smith Street|Sandon|2000|||011-7202000|011-7212000|Van|Y|00|1||Delivery no.1|Delivery no.2|Delivery no.3|Delivery no.4|Delivery no.5|N|10|N|1|Y||00|00|2000|Field 1|Field 2|Field 3|Field 4|Field 5|M|1|1|094003154|van@truck.com|Freight|Ship|TaxRef|Y|ContactDocs|EmailDocs|ContactStmt|EmailStmt|Y|Name|Surname|ID|BankAccHolderName|6|6|ThirdParty|Passport");
            if (StrReturn.StartsWith("0"))
            {
                MessageBox.Show("Customer successfulyl Created");
            }
            else
            {
                MessageBox.Show(StrReturn);
            }
;        }
    }
}
