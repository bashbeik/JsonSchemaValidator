using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace JsonSchemaValidator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Visible = false;
            label5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                string schemaJson = textBox1.Text;
                JSchema schema = JSchema.Parse(schemaJson);

                JObject json = JObject.Parse(richTextBox1.Text);

                IList<string> messages = new List<string>();
                bool valid = json.IsValid(schema, out messages);

                label4.Visible = valid;
                label5.Visible = !valid;

                label3.Text = "";
               
                

                
                

               
                foreach (var msg in messages)
                {
                    label3.Text += "\r\n" + msg;
                    string s = msg;
                    s = s.Substring(s.IndexOf("line "));
                    s = s.Substring(0, s.IndexOf(","));
                    s = s.Replace("line ", "");
                    s = s.Replace(",", "");

                    int i = Convert.ToInt32(s);
                    i--;
                    int start = richTextBox1.GetFirstCharIndexFromLine(i);
                    int length = richTextBox1.Lines[i].Length;

                   richTextBox1.Select(start, length);

                    


                }
                if (!valid) 
                richTextBox1.SelectionColor = Color.Red;
                else richTextBox1.SelectionColor = Color.Black;
                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }
    }
}
