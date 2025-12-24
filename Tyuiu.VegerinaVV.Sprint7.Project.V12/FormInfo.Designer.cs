namespace Tyuiu.VegerinaVV.Sprint7.Project.V12
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            richTextBoxInfo_VVV = new RichTextBox();
            groupBoxInfo_VVV = new GroupBox();
            groupBoxInfo_VVV.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBoxInfo_VVV
            // 
            richTextBoxInfo_VVV.BackColor = Color.Lavender;
            richTextBoxInfo_VVV.Dock = DockStyle.Fill;
            richTextBoxInfo_VVV.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            richTextBoxInfo_VVV.Location = new Point(3, 26);
            richTextBoxInfo_VVV.Name = "richTextBoxInfo_VVV";
            richTextBoxInfo_VVV.Size = new Size(763, 585);
            richTextBoxInfo_VVV.TabIndex = 0;
            richTextBoxInfo_VVV.Text = resources.GetString("richTextBoxInfo_VVV.Text");
            // 
            // groupBoxInfo_VVV
            // 
            groupBoxInfo_VVV.BackColor = Color.Lavender;
            groupBoxInfo_VVV.Controls.Add(richTextBoxInfo_VVV);
            groupBoxInfo_VVV.Dock = DockStyle.Fill;
            groupBoxInfo_VVV.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            groupBoxInfo_VVV.Location = new Point(0, 0);
            groupBoxInfo_VVV.Name = "groupBoxInfo_VVV";
            groupBoxInfo_VVV.Size = new Size(769, 614);
            groupBoxInfo_VVV.TabIndex = 0;
            groupBoxInfo_VVV.TabStop = false;
            groupBoxInfo_VVV.Text = "ПАМЯТКА";
            // 
            // FormInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 614);
            Controls.Add(groupBoxInfo_VVV);
            Name = "FormInfo";
            Text = "Руководство пользователя";
            groupBoxInfo_VVV.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxInfo_VVV;
        private GroupBox groupBoxInfo_VVV;
    }
}