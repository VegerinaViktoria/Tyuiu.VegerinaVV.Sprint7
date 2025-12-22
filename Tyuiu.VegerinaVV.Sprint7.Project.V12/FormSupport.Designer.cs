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
            label1 = new Label();
            buttonSupportClose_VVV = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(245, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 31);
            label1.TabIndex = 1;
            label1.Text = "ПОДДЕРЖКА";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(32, 74);
            label2.Name = "label2";
            label2.Size = new Size(624, 252);
            label2.TabIndex = 3;
            label2.Text = resources.GetString("label2.Text");
            // 
            // FormSupport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Plufow_Le_Studio___plufow____Unsplash_Photo_Community;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(716, 405);
            Controls.Add(label2);
            Controls.Add(buttonSupportClose_VVV);
            Controls.Add(label1);
            Name = "FormSupport";
            Text = "Поддержка";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button buttonSupportClose_VVV;
        private Label label2;
    }
}