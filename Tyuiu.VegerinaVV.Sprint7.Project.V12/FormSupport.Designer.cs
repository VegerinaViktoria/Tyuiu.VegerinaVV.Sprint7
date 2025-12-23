namespace Tyuiu.VegerinaVV.Sprint7.Project.V12
{
    partial class FormSupport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupport));
            labelSupport_VVV = new Label();
            buttonSupportClose_VVV = new Button();
            labelHelp_VVV = new Label();
            SuspendLayout();
            // 
            // labelSupport_VVV
            // 
            labelSupport_VVV.AutoSize = true;
            labelSupport_VVV.BackColor = Color.Transparent;
            labelSupport_VVV.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelSupport_VVV.Location = new Point(245, 9);
            labelSupport_VVV.Name = "labelSupport_VVV";
            labelSupport_VVV.Size = new Size(162, 31);
            labelSupport_VVV.TabIndex = 1;
            labelSupport_VVV.Text = "ПОДДЕРЖКА";
            // 
            // buttonSupportClose_VVV
            // 
            buttonSupportClose_VVV.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonSupportClose_VVV.ForeColor = Color.Black;
            buttonSupportClose_VVV.Location = new Point(585, 357);
            buttonSupportClose_VVV.Name = "buttonSupportClose_VVV";
            buttonSupportClose_VVV.Size = new Size(102, 36);
            buttonSupportClose_VVV.TabIndex = 2;
            buttonSupportClose_VVV.Text = "Закрыть ";
            buttonSupportClose_VVV.UseVisualStyleBackColor = true;
            buttonSupportClose_VVV.Click += buttonSupportClose_VVV_Click;
            // 
            // labelHelp_VVV
            // 
            labelHelp_VVV.AutoSize = true;
            labelHelp_VVV.BackColor = Color.Transparent;
            labelHelp_VVV.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelHelp_VVV.Location = new Point(32, 74);
            labelHelp_VVV.Name = "labelHelp_VVV";
            labelHelp_VVV.Size = new Size(624, 252);
            labelHelp_VVV.TabIndex = 3;
            labelHelp_VVV.Text = resources.GetString("labelHelp_VVV.Text");
            // 
            // FormSupport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Plufow_Le_Studio___plufow____Unsplash_Photo_Community;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(716, 405);
            Controls.Add(labelHelp_VVV);
            Controls.Add(buttonSupportClose_VVV);
            Controls.Add(labelSupport_VVV);
            Name = "FormSupport";
            Text = "Поддержка";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelSupport_VVV;
        private Button buttonSupportClose_VVV;
        private Label labelHelp_VVV;
    }
}