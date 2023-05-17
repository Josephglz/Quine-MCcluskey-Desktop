namespace MetodoTabularC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbNumVariables = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMinterminos = new TextBox();
            btnSimplificar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // cbNumVariables
            // 
            cbNumVariables.FormattingEnabled = true;
            cbNumVariables.Items.AddRange(new object[] { "2 Variables", "3 Variables", "4 Variables", "5 Variables", "6 Variables" });
            cbNumVariables.Location = new Point(339, 112);
            cbNumVariables.Margin = new Padding(3, 2, 3, 2);
            cbNumVariables.Name = "cbNumVariables";
            cbNumVariables.Size = new Size(206, 23);
            cbNumVariables.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(99, 18);
            label1.Name = "label1";
            label1.Size = new Size(472, 78);
            label1.TabIndex = 1;
            label1.Text = "Método Tabular";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(65, 109);
            label2.Name = "label2";
            label2.Size = new Size(225, 29);
            label2.TabIndex = 2;
            label2.Text = "Número de Variables";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(65, 164);
            label3.Name = "label3";
            label3.Size = new Size(145, 29);
            label3.TabIndex = 3;
            label3.Text = "Minterminos";
            // 
            // txtMinterminos
            // 
            txtMinterminos.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtMinterminos.Location = new Point(308, 161);
            txtMinterminos.Margin = new Padding(3, 2, 3, 2);
            txtMinterminos.Name = "txtMinterminos";
            txtMinterminos.Size = new Size(237, 32);
            txtMinterminos.TabIndex = 4;
            // 
            // btnSimplificar
            // 
            btnSimplificar.Location = new Point(312, 212);
            btnSimplificar.Margin = new Padding(3, 2, 3, 2);
            btnSimplificar.Name = "btnSimplificar";
            btnSimplificar.Size = new Size(82, 22);
            btnSimplificar.TabIndex = 5;
            btnSimplificar.Text = "Simplificar";
            btnSimplificar.UseVisualStyleBackColor = true;
            btnSimplificar.Click += btnSimplificar_Click;
            // 
            // lblResultado
            // 
            lblResultado.Font = new Font("Candara", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(65, 272);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(549, 34);
            lblResultado.TabIndex = 6;
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(lblResultado);
            Controls.Add(btnSimplificar);
            Controls.Add(txtMinterminos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbNumVariables);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Método Tabular";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbNumVariables;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMinterminos;
        private Button btnSimplificar;
        private Label lblResultado;
    }
}