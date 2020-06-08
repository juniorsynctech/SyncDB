namespace SyncDB
{
    partial class SyncDB
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
            this.btnConectar = new System.Windows.Forms.Button();
            this.buscaBase = new System.Windows.Forms.OpenFileDialog();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.btnIP = new System.Windows.Forms.Button();
            this.bntDB = new System.Windows.Forms.Button();
            this.btnBuscaID = new System.Windows.Forms.Button();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.chkJSON = new System.Windows.Forms.CheckBox();
            this.chkCSV = new System.Windows.Forms.CheckBox();
            this.chkXML = new System.Windows.Forms.CheckBox();
            this.chkSQL = new System.Windows.Forms.CheckBox();
            this.chkTESTE = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(210, 35);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buscaBase
            // 
            this.buscaBase.FileName = "buscaBase";
            this.buscaBase.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(15, 37);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(153, 20);
            this.txtIP.TabIndex = 1;
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP SERVIDOR:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "BANCO DE DADOS:";
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(15, 78);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(234, 20);
            this.txtDB.TabIndex = 4;
            // 
            // btnIP
            // 
            this.btnIP.Location = new System.Drawing.Point(174, 35);
            this.btnIP.Name = "btnIP";
            this.btnIP.Size = new System.Drawing.Size(30, 23);
            this.btnIP.TabIndex = 5;
            this.btnIP.Text = "IP";
            this.btnIP.UseVisualStyleBackColor = true;
            this.btnIP.Click += new System.EventHandler(this.btnIP_Click);
            // 
            // bntDB
            // 
            this.bntDB.Location = new System.Drawing.Point(255, 75);
            this.bntDB.Name = "bntDB";
            this.bntDB.Size = new System.Drawing.Size(30, 23);
            this.bntDB.TabIndex = 6;
            this.bntDB.Text = "DB";
            this.bntDB.UseVisualStyleBackColor = true;
            this.bntDB.Click += new System.EventHandler(this.bntDB_Click);
            // 
            // btnBuscaID
            // 
            this.btnBuscaID.Location = new System.Drawing.Point(255, 119);
            this.btnBuscaID.Name = "btnBuscaID";
            this.btnBuscaID.Size = new System.Drawing.Size(30, 23);
            this.btnBuscaID.TabIndex = 8;
            this.btnBuscaID.Text = "ID";
            this.btnBuscaID.UseVisualStyleBackColor = true;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(15, 122);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(153, 20);
            this.txtCNPJ.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(174, 122);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(75, 20);
            this.txtID.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "INFORME ID DO CNPJ DO CLIENTE:";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(118, 190);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(53, 26);
            this.btnGerar.TabIndex = 11;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // chkJSON
            // 
            this.chkJSON.AutoSize = true;
            this.chkJSON.Location = new System.Drawing.Point(15, 163);
            this.chkJSON.Name = "chkJSON";
            this.chkJSON.Size = new System.Drawing.Size(48, 17);
            this.chkJSON.TabIndex = 12;
            this.chkJSON.Text = "Json";
            this.chkJSON.UseVisualStyleBackColor = true;
            this.chkJSON.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkCSV
            // 
            this.chkCSV.AutoSize = true;
            this.chkCSV.Location = new System.Drawing.Point(124, 163);
            this.chkCSV.Name = "chkCSV";
            this.chkCSV.Size = new System.Drawing.Size(47, 17);
            this.chkCSV.TabIndex = 13;
            this.chkCSV.Text = "CSV";
            this.chkCSV.UseVisualStyleBackColor = true;
            // 
            // chkXML
            // 
            this.chkXML.AutoSize = true;
            this.chkXML.Location = new System.Drawing.Point(70, 163);
            this.chkXML.Name = "chkXML";
            this.chkXML.Size = new System.Drawing.Size(48, 17);
            this.chkXML.TabIndex = 14;
            this.chkXML.Text = "XML";
            this.chkXML.UseVisualStyleBackColor = true;
            // 
            // chkSQL
            // 
            this.chkSQL.AutoSize = true;
            this.chkSQL.Location = new System.Drawing.Point(177, 163);
            this.chkSQL.Name = "chkSQL";
            this.chkSQL.Size = new System.Drawing.Size(47, 17);
            this.chkSQL.TabIndex = 15;
            this.chkSQL.Text = "SQL";
            this.chkSQL.UseVisualStyleBackColor = true;
            // 
            // chkTESTE
            // 
            this.chkTESTE.AutoSize = true;
            this.chkTESTE.Location = new System.Drawing.Point(230, 163);
            this.chkTESTE.Name = "chkTESTE";
            this.chkTESTE.Size = new System.Drawing.Size(53, 17);
            this.chkTESTE.TabIndex = 16;
            this.chkTESTE.Text = "Teste";
            this.chkTESTE.UseVisualStyleBackColor = true;
            // 
            // SyncDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 228);
            this.Controls.Add(this.chkTESTE);
            this.Controls.Add(this.chkSQL);
            this.Controls.Add(this.chkXML);
            this.Controls.Add(this.chkCSV);
            this.Controls.Add(this.chkJSON);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnBuscaID);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.bntDB);
            this.Controls.Add(this.btnIP);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnConectar);
            this.Name = "SyncDB";
            this.Text = "Importação Dados";
            this.Load += new System.EventHandler(this.SyncDB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.OpenFileDialog buscaBase;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.Button btnIP;
        private System.Windows.Forms.Button bntDB;
        private System.Windows.Forms.Button btnBuscaID;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.CheckBox chkJSON;
        private System.Windows.Forms.CheckBox chkCSV;
        private System.Windows.Forms.CheckBox chkXML;
        private System.Windows.Forms.CheckBox chkSQL;
        private System.Windows.Forms.CheckBox chkTESTE;
    }
}

