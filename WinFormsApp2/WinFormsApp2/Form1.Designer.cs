namespace WinFormsApp2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BRRP = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTNsalir = new System.Windows.Forms.Button();
            this.BTNlimpiar = new System.Windows.Forms.Button();
            this.TXBNcontra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXBusuario = new System.Windows.Forms.TextBox();
            this.BTNingresar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.porcentaje = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "INICIO DE SESION";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.porcentaje);
            this.groupBox1.Controls.Add(this.BRRP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.BTNsalir);
            this.groupBox1.Controls.Add(this.BTNlimpiar);
            this.groupBox1.Controls.Add(this.TXBNcontra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TXBusuario);
            this.groupBox1.Controls.Add(this.BTNingresar);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(24, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 355);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESE LOS DATOS SOLICITADOS";
            // 
            // BRRP
            // 
            this.BRRP.Location = new System.Drawing.Point(34, 309);
            this.BRRP.Name = "BRRP";
            this.BRRP.Size = new System.Drawing.Size(669, 23);
            this.BRRP.TabIndex = 10;
            this.BRRP.Click += new System.EventHandler(this.BRRP_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Reem Kufi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 35);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contraseña :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(387, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // BTNsalir
            // 
            this.BTNsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTNsalir.ForeColor = System.Drawing.Color.Black;
            this.BTNsalir.Location = new System.Drawing.Point(628, 250);
            this.BTNsalir.Name = "BTNsalir";
            this.BTNsalir.Size = new System.Drawing.Size(75, 31);
            this.BTNsalir.TabIndex = 7;
            this.BTNsalir.Text = "Salir";
            this.BTNsalir.UseVisualStyleBackColor = false;
            this.BTNsalir.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // BTNlimpiar
            // 
            this.BTNlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTNlimpiar.ForeColor = System.Drawing.Color.Black;
            this.BTNlimpiar.Location = new System.Drawing.Point(514, 250);
            this.BTNlimpiar.Name = "BTNlimpiar";
            this.BTNlimpiar.Size = new System.Drawing.Size(75, 31);
            this.BTNlimpiar.TabIndex = 6;
            this.BTNlimpiar.Text = "Limpiar";
            this.BTNlimpiar.UseVisualStyleBackColor = false;
            this.BTNlimpiar.Click += new System.EventHandler(this.BTNlimpiar_Click);
            // 
            // TXBNcontra
            // 
            this.TXBNcontra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TXBNcontra.Location = new System.Drawing.Point(34, 211);
            this.TXBNcontra.Name = "TXBNcontra";
            this.TXBNcontra.PasswordChar = '*';
            this.TXBNcontra.Size = new System.Drawing.Size(299, 23);
            this.TXBNcontra.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Reem Kufi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del Usuario :";
            // 
            // TXBusuario
            // 
            this.TXBusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TXBusuario.ForeColor = System.Drawing.Color.Black;
            this.TXBusuario.Location = new System.Drawing.Point(34, 110);
            this.TXBusuario.Name = "TXBusuario";
            this.TXBusuario.PasswordChar = '*';
            this.TXBusuario.Size = new System.Drawing.Size(299, 23);
            this.TXBusuario.TabIndex = 1;
            // 
            // BTNingresar
            // 
            this.BTNingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTNingresar.ForeColor = System.Drawing.Color.Black;
            this.BTNingresar.Location = new System.Drawing.Point(387, 250);
            this.BTNingresar.Name = "BTNingresar";
            this.BTNingresar.Size = new System.Drawing.Size(80, 31);
            this.BTNingresar.TabIndex = 0;
            this.BTNingresar.Text = "Ingresar";
            this.BTNingresar.UseVisualStyleBackColor = false;
            this.BTNingresar.Click += new System.EventHandler(this.BTNingresar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // porcentaje
            // 
            this.porcentaje.AutoSize = true;
            this.porcentaje.Location = new System.Drawing.Point(182, 277);
            this.porcentaje.Name = "porcentaje";
            this.porcentaje.Size = new System.Drawing.Size(38, 15);
            this.porcentaje.TabIndex = 11;
            this.porcentaje.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 405);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private PictureBox pictureBox1;
        private Button BTNsalir;
        private Button BTNlimpiar;
        private TextBox TXBNcontra;
        private Label label2;
        private TextBox TXBusuario;
        private Button BTNingresar;
        private ProgressBar BRRP;
        private System.Windows.Forms.Timer timer1;
        private Label porcentaje;
    }
}