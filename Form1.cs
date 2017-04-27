using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AdamTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.lbResponse.Text = string.Empty;

            var individualFlg = this.individual_flg.Checked ? "0" : "1";

            var urlToCall = this.tbPostedLink.Text.Trim();
            try
            {
                using (var client = new WebClient())
                {
                    client.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
                    client.Headers.Add("Access-Control-Allow-Origin", "*");

                    byte[] response = client.UploadValues(urlToCall, "POST", new NameValueCollection()
                    {
                        { "individual_flg", individualFlg },
                        { "name", this.tbName.Text },
                        { "address", this.tbAddress.Text },
                        { "address2", this.tbAddress2.Text },
                        { "city", this.tbCity.Text },
                        { "state", this.tbState.Text },
                        { "zipcode", this.tbZipCode.Text },
                        { "areacode", this.tbAreaCode.Text },
                        { "email_address", this.tbEmail.Text },
                        { "fax", this.tbFax.Text },
                        { "recipient_category_id", recipient_category_id.Text }
                    });

                    var adamResponse = JsonConvert.DeserializeObject<AdamResponse>(System.Text.Encoding.Default.GetString(response));

                    this.lbResponse.Text = !adamResponse.Result.Equals("0") ? adamResponse.Message : @"Success";
                    
                }
            }
            catch (Exception ex)
            {
                this.lbResponse.Text = ex.Message;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.lbResponse.Text = string.Empty;
        }
    }
}
