namespace JsonSchemaValidator
{
    partial class JsonSchemaValidatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.schemaTextBox = new System.Windows.Forms.TextBox();
            this.schemaLabel = new System.Windows.Forms.Label();
            this.jsonLabel = new System.Windows.Forms.Label();
            this.validateButton = new System.Windows.Forms.Button();
            this.msgLabel = new System.Windows.Forms.Label();
            this.validLabel = new System.Windows.Forms.Label();
            this.invalidLabel = new System.Windows.Forms.Label();
            this.jsonRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // schemaTextBox
            // 
            this.schemaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.schemaTextBox.Location = new System.Drawing.Point(13, 53);
            this.schemaTextBox.Multiline = true;
            this.schemaTextBox.Name = "schemaTextBox";
            this.schemaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.schemaTextBox.Size = new System.Drawing.Size(529, 448);
            this.schemaTextBox.TabIndex = 0;
            // 
            // schemaLabel
            // 
            this.schemaLabel.AutoSize = true;
            this.schemaLabel.Location = new System.Drawing.Point(12, 27);
            this.schemaLabel.Name = "schemaLabel";
            this.schemaLabel.Size = new System.Drawing.Size(71, 13);
            this.schemaLabel.TabIndex = 2;
            this.schemaLabel.Text = "Json Schema";
            // 
            // jsonLabel
            // 
            this.jsonLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jsonLabel.AutoSize = true;
            this.jsonLabel.Location = new System.Drawing.Point(534, 27);
            this.jsonLabel.Name = "jsonLabel";
            this.jsonLabel.Size = new System.Drawing.Size(67, 13);
            this.jsonLabel.TabIndex = 3;
            this.jsonLabel.Text = "Json Sample";
            // 
            // validateButton
            // 
            this.validateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.validateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateButton.Location = new System.Drawing.Point(13, 519);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(208, 66);
            this.validateButton.TabIndex = 4;
            this.validateButton.Text = "Validate Schema";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // msgLabel
            // 
            this.msgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.msgLabel.AutoSize = true;
            this.msgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLabel.Location = new System.Drawing.Point(454, 519);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(20, 18);
            this.msgLabel.TabIndex = 5;
            this.msgLabel.Text = "   ";
            // 
            // validLabel
            // 
            this.validLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.validLabel.AutoSize = true;
            this.validLabel.BackColor = System.Drawing.Color.Lime;
            this.validLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validLabel.Location = new System.Drawing.Point(284, 519);
            this.validLabel.Name = "validLabel";
            this.validLabel.Size = new System.Drawing.Size(93, 31);
            this.validLabel.TabIndex = 6;
            this.validLabel.Text = "VALID";
            // 
            // invalidLabel
            // 
            this.invalidLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.invalidLabel.AutoSize = true;
            this.invalidLabel.BackColor = System.Drawing.Color.Red;
            this.invalidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidLabel.Location = new System.Drawing.Point(284, 554);
            this.invalidLabel.Name = "invalidLabel";
            this.invalidLabel.Size = new System.Drawing.Size(121, 31);
            this.invalidLabel.TabIndex = 7;
            this.invalidLabel.Text = "INVALID";
            // 
            // jsonRichTextBox
            // 
            this.jsonRichTextBox.Location = new System.Drawing.Point(548, 53);
            this.jsonRichTextBox.Name = "jsonRichTextBox";
            this.jsonRichTextBox.Size = new System.Drawing.Size(526, 448);
            this.jsonRichTextBox.TabIndex = 8;
            this.jsonRichTextBox.Text = "";
            // 
            // JsonSchemaValidatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 597);
            this.Controls.Add(this.jsonRichTextBox);
            this.Controls.Add(this.invalidLabel);
            this.Controls.Add(this.validLabel);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.jsonLabel);
            this.Controls.Add(this.schemaLabel);
            this.Controls.Add(this.schemaTextBox);
            this.Name = "JsonSchemaValidatorForm";
            this.Text = "Json Schema Validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox schemaTextBox;
        private System.Windows.Forms.Label schemaLabel;
        private System.Windows.Forms.Label jsonLabel;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.Label validLabel;
        private System.Windows.Forms.Label invalidLabel;
        private System.Windows.Forms.RichTextBox jsonRichTextBox;
    }
}

