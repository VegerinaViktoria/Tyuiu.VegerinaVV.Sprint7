namespace Tyuiu.VegerinaVV.Sprint7.Project.V12
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAbout_VVV = new PictureBox();
            labelAbout_VVV = new Label();
            buttonOK_VVV = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_VVV).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAbout_VVV
            // 
            pictureBoxAbout_VVV.Image = (Image)resources.GetObject("pictureBoxAbout_VVV.Image");
            pictureBoxAbout_VVV.Location = new Point(12, 28);
            pictureBoxAbout_VVV.MinimumSize = new Size(190, 240);
            pictureBoxAbout_VVV.Name = "pictureBoxAbout_VVV";
            pictureBoxAbout_VVV.Size = new Size(190, 240);
            pictureBoxAbout_VVV.TabIndex = 0;
            pictureBoxAbout_VVV.TabStop = false;
            // 
            // labelAbout_VVV
            // 
            labelAbout_VVV.AutoSize = true;
            labelAbout_VVV.Location = new Point(234, 42);
            labelAbout_VVV.Name = "labelAbout_VVV";
            labelAbout_VVV.Size = new Size(370, 200);
            labelAbout_VVV.TabIndex = 1;
            labelAbout_VVV.Text = resources.GetString("labelAbout_VVV.Text");
            // 
            // buttonOK_VVV
            // 
            buttonOK_VVV.Location = new Point(590, 269);
            buttonOK_VVV.Name = "buttonOK_VVV";
            buttonOK_VVV.Size = new Size(94, 29);
            buttonOK_VVV.TabIndex = 2;
            buttonOK_VVV.Text = "OK";
            buttonOK_VVV.UseVisualStyleBackColor = true;
            buttonOK_VVV.Click += buttonOK_VVV_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(728, 324);
            Controls.Add(buttonOK_VVV);
            Controls.Add(labelAbout_VVV);
            Controls.Add(pictureBoxAbout_VVV);
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_VVV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAbout_VVV;
        private Label labelAbout_VVV;
        private Button buttonOK_VVV;
    }
}