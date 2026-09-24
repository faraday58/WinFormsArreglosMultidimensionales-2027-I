namespace WinFormsArreglosMultidimensionales_2027_I
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
            txtbDisplay = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbMatrix1 = new Label();
            lbMatrix2 = new Label();
            label6 = new Label();
            label7 = new Label();
            lbResult = new Label();
            btnAdd = new Button();
            btnSubstraction = new Button();
            btnMultiply = new Button();
            btnTranspose = new Button();
            btnSin = new Button();
            rdbDeg = new RadioButton();
            rdbRad = new RadioButton();
            SuspendLayout();
            // 
            // txtbDisplay
            // 
            txtbDisplay.Location = new Point(101, 125);
            txtbDisplay.Name = "txtbDisplay";
            txtbDisplay.PlaceholderText = "1,2;0,1";
            txtbDisplay.Size = new Size(633, 31);
            txtbDisplay.TabIndex = 0;
            txtbDisplay.KeyPress += txtbDisplay_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 61);
            label1.Name = "label1";
            label1.Size = new Size(318, 25);
            label1.TabIndex = 1;
            label1.Text = "Ingresar Matriz, y agregar con un Enter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 231);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 1;
            label2.Text = "Matriz 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(602, 231);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 1;
            label3.Text = "Matriz 2";
            // 
            // lbMatrix1
            // 
            lbMatrix1.AutoSize = true;
            lbMatrix1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMatrix1.Location = new Point(101, 310);
            lbMatrix1.Name = "lbMatrix1";
            lbMatrix1.Size = new Size(47, 64);
            lbMatrix1.TabIndex = 1;
            lbMatrix1.Text = "1 2\r\n0 1\r\n";
            // 
            // lbMatrix2
            // 
            lbMatrix2.AutoSize = true;
            lbMatrix2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMatrix2.Location = new Point(602, 310);
            lbMatrix2.Name = "lbMatrix2";
            lbMatrix2.Size = new Size(47, 64);
            lbMatrix2.TabIndex = 1;
            lbMatrix2.Text = "2 1\r\n1 0\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(358, 310);
            label6.Name = "label6";
            label6.Size = new Size(36, 38);
            label6.TabIndex = 1;
            label6.Text = "+";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(794, 310);
            label7.Name = "label7";
            label7.Size = new Size(36, 38);
            label7.TabIndex = 1;
            label7.Text = "=";
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbResult.Location = new Point(971, 304);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(49, 64);
            lbResult.TabIndex = 1;
            lbResult.Text = "3 3\r\n1 1";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Showcard Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(74, 473);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(157, 83);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubstraction
            // 
            btnSubstraction.Font = new Font("Showcard Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubstraction.Location = new Point(292, 473);
            btnSubstraction.Name = "btnSubstraction";
            btnSubstraction.Size = new Size(157, 83);
            btnSubstraction.TabIndex = 2;
            btnSubstraction.Text = "-";
            btnSubstraction.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Showcard Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiply.Location = new Point(521, 473);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(157, 83);
            btnMultiply.TabIndex = 2;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            // 
            // btnTranspose
            // 
            btnTranspose.Font = new Font("Showcard Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTranspose.Location = new Point(716, 473);
            btnTranspose.Name = "btnTranspose";
            btnTranspose.Size = new Size(278, 83);
            btnTranspose.TabIndex = 2;
            btnTranspose.Text = "Transpuesta";
            btnTranspose.UseVisualStyleBackColor = true;
            // 
            // btnSin
            // 
            btnSin.Font = new Font("Showcard Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSin.Location = new Point(716, 598);
            btnSin.Name = "btnSin";
            btnSin.Size = new Size(278, 83);
            btnSin.TabIndex = 2;
            btnSin.Text = "Seno";
            btnSin.UseVisualStyleBackColor = true;
            btnSin.Click += btnSin_Click;
            // 
            // rdbDeg
            // 
            rdbDeg.AutoSize = true;
            rdbDeg.Location = new Point(1094, 574);
            rdbDeg.Name = "rdbDeg";
            rdbDeg.Size = new Size(70, 29);
            rdbDeg.TabIndex = 3;
            rdbDeg.TabStop = true;
            rdbDeg.Text = "Deg";
            rdbDeg.UseVisualStyleBackColor = true;
            // 
            // rdbRad
            // 
            rdbRad.AutoSize = true;
            rdbRad.Location = new Point(1094, 629);
            rdbRad.Name = "rdbRad";
            rdbRad.Size = new Size(68, 29);
            rdbRad.TabIndex = 3;
            rdbRad.TabStop = true;
            rdbRad.Text = "Rad";
            rdbRad.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 746);
            Controls.Add(rdbRad);
            Controls.Add(rdbDeg);
            Controls.Add(btnSin);
            Controls.Add(btnTranspose);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubstraction);
            Controls.Add(btnAdd);
            Controls.Add(lbResult);
            Controls.Add(label7);
            Controls.Add(lbMatrix2);
            Controls.Add(label3);
            Controls.Add(lbMatrix1);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtbDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbDisplay;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbMatrix1;
        private Label lbMatrix2;
        private Label label6;
        private Label label7;
        private Label lbResult;
        private Button btnAdd;
        private Button btnSubstraction;
        private Button btnMultiply;
        private Button btnTranspose;
        private Button btnSin;
        private RadioButton rdbDeg;
        private RadioButton rdbRad;
    }
}
