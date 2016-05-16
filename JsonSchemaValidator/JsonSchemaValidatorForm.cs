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
    public partial class JsonSchemaValidatorForm : Form
    {
        public JsonSchemaValidatorForm()
        {
            InitializeComponent();
            validLabel.Visible = false;
            invalidLabel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {

                string schemaJson = schemaTextBox.Text;
                JSchema schema = JSchema.Parse(schemaJson);

                //Parses json to schema
                JObject json = JObject.Parse(jsonRichTextBox.Text);

                //List of messages containing the schema errors
                IList<string> messages = new List<string>();
                bool valid = json.IsValid(schema, out messages);

                validLabel.Visible = valid;
                invalidLabel.Visible = !valid;

                msgLabel.Text = "";
               

                //print each error and highlight the error line
                foreach (var msg in messages)
                {
                    msgLabel.Text += "\r\n" + msg;


                    int i = getLineNum(msg);
                    
                    //decrease for zero based index
                    i--;
                    int start = jsonRichTextBox.GetFirstCharIndexFromLine(i);
                    int length = jsonRichTextBox.Lines[i].Length;

                   jsonRichTextBox.Select(start, length);


                }
                if (!valid) 
                jsonRichTextBox.SelectionColor = Color.Red;
                else jsonRichTextBox.SelectionColor = Color.Black;
                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }

        //get line number from the message
        static int getLineNum(string s)
        {
            
            s = s.Substring(s.IndexOf("line "));
            s = s.Substring(0, s.IndexOf(","));
            s = s.Replace("line ", "");
            s = s.Replace(",", "");
            return Convert.ToInt32(s);
        }
    }
}
