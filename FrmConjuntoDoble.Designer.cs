namespace Aplicacion_Conjuntos
{
    partial class FrmConjuntoDoble
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConjuntoDoble));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConjuntoA = new System.Windows.Forms.TextBox();
            this.txtConjuntoB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPositivo = new System.Windows.Forms.TextBox();
            this.txtKleene = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInterseccionAB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDiferenciaAB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSimetricaAB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUnionAB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDiferenciaBA = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOperar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLimpiar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lenguaje 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lenguaje 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtConjuntoA
            // 
            this.txtConjuntoA.BackColor = System.Drawing.Color.White;
            this.txtConjuntoA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConjuntoA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConjuntoA.ForeColor = System.Drawing.Color.Black;
            this.txtConjuntoA.Location = new System.Drawing.Point(32, 37);
            this.txtConjuntoA.Multiline = true;
            this.txtConjuntoA.Name = "txtConjuntoA";
            this.txtConjuntoA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConjuntoA.Size = new System.Drawing.Size(141, 132);
            this.txtConjuntoA.TabIndex = 2;
            this.txtConjuntoA.TextChanged += new System.EventHandler(this.txtConjuntoA_TextChanged);
            // 
            // txtConjuntoB
            // 
            this.txtConjuntoB.BackColor = System.Drawing.Color.White;
            this.txtConjuntoB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConjuntoB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConjuntoB.ForeColor = System.Drawing.Color.Black;
            this.txtConjuntoB.Location = new System.Drawing.Point(208, 37);
            this.txtConjuntoB.Multiline = true;
            this.txtConjuntoB.Name = "txtConjuntoB";
            this.txtConjuntoB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConjuntoB.Size = new System.Drawing.Size(141, 132);
            this.txtConjuntoB.TabIndex = 3;
            this.txtConjuntoB.TextChanged += new System.EventHandler(this.txtConjuntoB_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtPositivo);
            this.panel1.Controls.Add(this.txtKleene);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtInterseccionAB);
            this.panel1.Controls.Add(this.txtDiferenciaAB);
            this.panel1.Controls.Add(this.txtSimetricaAB);
            this.panel1.Controls.Add(this.txtUnionAB);
            this.panel1.Controls.Add(this.txtDiferenciaBA);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(32, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 467);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtPositivo
            // 
            this.txtPositivo.BackColor = System.Drawing.Color.White;
            this.txtPositivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPositivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPositivo.ForeColor = System.Drawing.Color.Black;
            this.txtPositivo.Location = new System.Drawing.Point(95, 341);
            this.txtPositivo.Multiline = true;
            this.txtPositivo.Name = "txtPositivo";
            this.txtPositivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPositivo.Size = new System.Drawing.Size(416, 110);
            this.txtPositivo.TabIndex = 20;
            // 
            // txtKleene
            // 
            this.txtKleene.BackColor = System.Drawing.Color.White;
            this.txtKleene.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKleene.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKleene.ForeColor = System.Drawing.Color.Black;
            this.txtKleene.Location = new System.Drawing.Point(95, 218);
            this.txtKleene.Multiline = true;
            this.txtKleene.Name = "txtKleene";
            this.txtKleene.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKleene.Size = new System.Drawing.Size(416, 110);
            this.txtKleene.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "A+ =";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "A* =";
            // 
            // txtInterseccionAB
            // 
            this.txtInterseccionAB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInterseccionAB.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtInterseccionAB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInterseccionAB.HintForeColor = System.Drawing.Color.Empty;
            this.txtInterseccionAB.HintText = "";
            this.txtInterseccionAB.isPassword = false;
            this.txtInterseccionAB.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtInterseccionAB.LineIdleColor = System.Drawing.Color.Gray;
            this.txtInterseccionAB.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtInterseccionAB.LineThickness = 3;
            this.txtInterseccionAB.Location = new System.Drawing.Point(95, 44);
            this.txtInterseccionAB.Margin = new System.Windows.Forms.Padding(4);
            this.txtInterseccionAB.Name = "txtInterseccionAB";
            this.txtInterseccionAB.Size = new System.Drawing.Size(416, 33);
            this.txtInterseccionAB.TabIndex = 14;
            this.txtInterseccionAB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtInterseccionAB.OnValueChanged += new System.EventHandler(this.txtInterseccionAB_OnValueChanged);
            // 
            // txtDiferenciaAB
            // 
            this.txtDiferenciaAB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiferenciaAB.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDiferenciaAB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiferenciaAB.HintForeColor = System.Drawing.Color.Empty;
            this.txtDiferenciaAB.HintText = "";
            this.txtDiferenciaAB.isPassword = false;
            this.txtDiferenciaAB.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDiferenciaAB.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDiferenciaAB.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDiferenciaAB.LineThickness = 3;
            this.txtDiferenciaAB.Location = new System.Drawing.Point(95, 85);
            this.txtDiferenciaAB.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiferenciaAB.Name = "txtDiferenciaAB";
            this.txtDiferenciaAB.Size = new System.Drawing.Size(416, 33);
            this.txtDiferenciaAB.TabIndex = 13;
            this.txtDiferenciaAB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiferenciaAB.OnValueChanged += new System.EventHandler(this.txtDiferenciaAB_OnValueChanged);
            // 
            // txtSimetricaAB
            // 
            this.txtSimetricaAB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSimetricaAB.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSimetricaAB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSimetricaAB.HintForeColor = System.Drawing.Color.Empty;
            this.txtSimetricaAB.HintText = "";
            this.txtSimetricaAB.isPassword = false;
            this.txtSimetricaAB.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSimetricaAB.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSimetricaAB.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSimetricaAB.LineThickness = 3;
            this.txtSimetricaAB.Location = new System.Drawing.Point(95, 172);
            this.txtSimetricaAB.Margin = new System.Windows.Forms.Padding(4);
            this.txtSimetricaAB.Name = "txtSimetricaAB";
            this.txtSimetricaAB.Size = new System.Drawing.Size(416, 33);
            this.txtSimetricaAB.TabIndex = 10;
            this.txtSimetricaAB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSimetricaAB.OnValueChanged += new System.EventHandler(this.txtSimetricaAB_OnValueChanged);
            // 
            // txtUnionAB
            // 
            this.txtUnionAB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnionAB.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUnionAB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUnionAB.HintForeColor = System.Drawing.Color.Empty;
            this.txtUnionAB.HintText = "";
            this.txtUnionAB.isPassword = false;
            this.txtUnionAB.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtUnionAB.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUnionAB.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtUnionAB.LineThickness = 3;
            this.txtUnionAB.Location = new System.Drawing.Point(95, 3);
            this.txtUnionAB.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnionAB.Name = "txtUnionAB";
            this.txtUnionAB.Size = new System.Drawing.Size(416, 33);
            this.txtUnionAB.TabIndex = 12;
            this.txtUnionAB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUnionAB.OnValueChanged += new System.EventHandler(this.txtUnionAB_OnValueChanged);
            // 
            // txtDiferenciaBA
            // 
            this.txtDiferenciaBA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiferenciaBA.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDiferenciaBA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiferenciaBA.HintForeColor = System.Drawing.Color.Empty;
            this.txtDiferenciaBA.HintText = "";
            this.txtDiferenciaBA.isPassword = false;
            this.txtDiferenciaBA.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDiferenciaBA.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDiferenciaBA.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDiferenciaBA.LineThickness = 3;
            this.txtDiferenciaBA.Location = new System.Drawing.Point(95, 129);
            this.txtDiferenciaBA.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiferenciaBA.Name = "txtDiferenciaBA";
            this.txtDiferenciaBA.Size = new System.Drawing.Size(416, 33);
            this.txtDiferenciaBA.TabIndex = 9;
            this.txtDiferenciaBA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiferenciaBA.OnValueChanged += new System.EventHandler(this.txtDiferenciaBA_OnValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "A Δ B =";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "B - A =";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "A - B =";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "A ∩ B =";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "A U B =";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnOperar
            // 
            this.btnOperar.ActiveBorderThickness = 1;
            this.btnOperar.ActiveCornerRadius = 20;
            this.btnOperar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnOperar.ActiveForecolor = System.Drawing.Color.White;
            this.btnOperar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnOperar.BackColor = System.Drawing.Color.White;
            this.btnOperar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOperar.BackgroundImage")));
            this.btnOperar.ButtonText = "Calcular";
            this.btnOperar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOperar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnOperar.IdleBorderThickness = 1;
            this.btnOperar.IdleCornerRadius = 20;
            this.btnOperar.IdleFillColor = System.Drawing.Color.White;
            this.btnOperar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnOperar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnOperar.Location = new System.Drawing.Point(373, 37);
            this.btnOperar.Margin = new System.Windows.Forms.Padding(5);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(181, 63);
            this.btnOperar.TabIndex = 7;
            this.btnOperar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ActiveBorderThickness = 1;
            this.btnLimpiar.ActiveCornerRadius = 20;
            this.btnLimpiar.ActiveFillColor = System.Drawing.Color.Red;
            this.btnLimpiar.ActiveForecolor = System.Drawing.Color.White;
            this.btnLimpiar.ActiveLineColor = System.Drawing.Color.Red;
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.ButtonText = "Borrar";
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Red;
            this.btnLimpiar.IdleBorderThickness = 1;
            this.btnLimpiar.IdleCornerRadius = 20;
            this.btnLimpiar.IdleFillColor = System.Drawing.Color.White;
            this.btnLimpiar.IdleForecolor = System.Drawing.Color.Red;
            this.btnLimpiar.IdleLineColor = System.Drawing.Color.Red;
            this.btnLimpiar.Location = new System.Drawing.Point(373, 110);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(181, 59);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Aplicacion_Conjuntos.Properties.Resources.cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(559, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 659);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "MonoDLDev";
            // 
            // FrmConjuntoDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 683);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtConjuntoB);
            this.Controls.Add(this.txtConjuntoA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConjuntoDoble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conjunto Doble";
            this.Load += new System.EventHandler(this.FrmConjuntoDoble_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConjuntoA;
        private System.Windows.Forms.TextBox txtConjuntoB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtInterseccionAB;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDiferenciaAB;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSimetricaAB;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUnionAB;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDiferenciaBA;
        private Bunifu.Framework.UI.BunifuThinButton2 btnOperar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLimpiar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKleene;
        private System.Windows.Forms.TextBox txtPositivo;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label10;
    }
}

