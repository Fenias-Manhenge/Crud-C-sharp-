using System;

namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboNivel = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtViuvo = new System.Windows.Forms.RadioButton();
            this.rbtCasado = new System.Windows.Forms.RadioButton();
            this.rbtDivorciado = new System.Windows.Forms.RadioButton();
            this.rbtSolteiro = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.rbtFeminino = new System.Windows.Forms.RadioButton();
            this.txtCargaHoraria = new System.Windows.Forms.TextBox();
            this.txtSalarioHora = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnCadrastrar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listVisualizar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARGAHORARIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CODIGO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CONTACTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "NIVEL ACADEMICO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "SALARIO/HORA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboNivel);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtCargaHoraria);
            this.groupBox1.Controls.Add(this.txtSalarioHora);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.txtContacto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 202);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DADOS DOS PROFESSORES";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(129, 59);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(122, 20);
            this.txtNome.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nome";
            // 
            // cboNivel
            // 
            this.cboNivel.FormattingEnabled = true;
            this.cboNivel.Location = new System.Drawing.Point(130, 114);
            this.cboNivel.Name = "cboNivel";
            this.cboNivel.Size = new System.Drawing.Size(121, 21);
            this.cboNivel.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtViuvo);
            this.groupBox3.Controls.Add(this.rbtCasado);
            this.groupBox3.Controls.Add(this.rbtDivorciado);
            this.groupBox3.Controls.Add(this.rbtSolteiro);
            this.groupBox3.Location = new System.Drawing.Point(268, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 68);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ESTADO CIVIL";
            // 
            // rbtViuvo
            // 
            this.rbtViuvo.AutoSize = true;
            this.rbtViuvo.Location = new System.Drawing.Point(93, 44);
            this.rbtViuvo.Name = "rbtViuvo";
            this.rbtViuvo.Size = new System.Drawing.Size(58, 17);
            this.rbtViuvo.TabIndex = 3;
            this.rbtViuvo.TabStop = true;
            this.rbtViuvo.Text = "VIUVO";
            this.rbtViuvo.UseVisualStyleBackColor = true;
            // 
            // rbtCasado
            // 
            this.rbtCasado.AutoSize = true;
            this.rbtCasado.Location = new System.Drawing.Point(7, 44);
            this.rbtCasado.Name = "rbtCasado";
            this.rbtCasado.Size = new System.Drawing.Size(69, 17);
            this.rbtCasado.TabIndex = 2;
            this.rbtCasado.TabStop = true;
            this.rbtCasado.Text = "CASADO";
            this.rbtCasado.UseVisualStyleBackColor = true;
            // 
            // rbtDivorciado
            // 
            this.rbtDivorciado.AutoSize = true;
            this.rbtDivorciado.Location = new System.Drawing.Point(93, 20);
            this.rbtDivorciado.Name = "rbtDivorciado";
            this.rbtDivorciado.Size = new System.Drawing.Size(92, 17);
            this.rbtDivorciado.TabIndex = 1;
            this.rbtDivorciado.TabStop = true;
            this.rbtDivorciado.Text = "DIVORCIADO";
            this.rbtDivorciado.UseVisualStyleBackColor = true;
            // 
            // rbtSolteiro
            // 
            this.rbtSolteiro.AutoSize = true;
            this.rbtSolteiro.Location = new System.Drawing.Point(7, 20);
            this.rbtSolteiro.Name = "rbtSolteiro";
            this.rbtSolteiro.Size = new System.Drawing.Size(79, 17);
            this.rbtSolteiro.TabIndex = 0;
            this.rbtSolteiro.TabStop = true;
            this.rbtSolteiro.Text = "SOLTEIRO";
            this.rbtSolteiro.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtMasculino);
            this.groupBox2.Controls.Add(this.rbtFeminino);
            this.groupBox2.Location = new System.Drawing.Point(268, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 39);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SEXO";
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(97, 16);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(88, 17);
            this.rbtMasculino.TabIndex = 1;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "MASCULINO";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtFeminino
            // 
            this.rbtFeminino.AutoSize = true;
            this.rbtFeminino.Location = new System.Drawing.Point(6, 16);
            this.rbtFeminino.Name = "rbtFeminino";
            this.rbtFeminino.Size = new System.Drawing.Size(77, 17);
            this.rbtFeminino.TabIndex = 0;
            this.rbtFeminino.TabStop = true;
            this.rbtFeminino.Text = "FEMININO";
            this.rbtFeminino.UseVisualStyleBackColor = true;
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.Location = new System.Drawing.Point(129, 170);
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.Size = new System.Drawing.Size(100, 20);
            this.txtCargaHoraria.TabIndex = 9;
            // 
            // txtSalarioHora
            // 
            this.txtSalarioHora.Location = new System.Drawing.Point(129, 143);
            this.txtSalarioHora.Name = "txtSalarioHora";
            this.txtSalarioHora.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioHora.TabIndex = 8;
            this.txtSalarioHora.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(130, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 7;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(129, 87);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(100, 20);
            this.txtContacto.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCancelar);
            this.groupBox4.Controls.Add(this.btnApagar);
            this.groupBox4.Controls.Add(this.btnActualizar);
            this.groupBox4.Controls.Add(this.btnVisualizar);
            this.groupBox4.Controls.Add(this.btnCadrastrar);
            this.groupBox4.Location = new System.Drawing.Point(513, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(165, 172);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "OPERACOES";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(18, 142);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(18, 113);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(128, 23);
            this.btnApagar.TabIndex = 3;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(18, 85);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(128, 23);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(18, 56);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(128, 23);
            this.btnVisualizar.TabIndex = 1;
            this.btnVisualizar.Text = "VISUALIZAR";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnCadrastrar
            // 
            this.btnCadrastrar.Location = new System.Drawing.Point(18, 27);
            this.btnCadrastrar.Name = "btnCadrastrar";
            this.btnCadrastrar.Size = new System.Drawing.Size(128, 23);
            this.btnCadrastrar.TabIndex = 0;
            this.btnCadrastrar.Text = "CADASTRAR";
            this.btnCadrastrar.UseVisualStyleBackColor = true;
            this.btnCadrastrar.Click += new System.EventHandler(this.btnCadrastrar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listVisualizar);
            this.groupBox5.Location = new System.Drawing.Point(21, 244);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(885, 240);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "VISUALIZACAO";
            // 
            // listVisualizar
            // 
            this.listVisualizar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listVisualizar.GridLines = true;
            this.listVisualizar.HideSelection = false;
            this.listVisualizar.Location = new System.Drawing.Point(6, 19);
            this.listVisualizar.Name = "listVisualizar";
            this.listVisualizar.Size = new System.Drawing.Size(873, 215);
            this.listVisualizar.TabIndex = 0;
            this.listVisualizar.UseCompatibleStateImageBehavior = false;
            this.listVisualizar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CODIGO";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NOME";
            this.columnHeader2.Width = 158;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CONTACTO";
            this.columnHeader3.Width = 84;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SEXO";
            this.columnHeader4.Width = 44;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ESTADO CIVIL";
            this.columnHeader5.Width = 91;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "NIVEL ACADEMICO";
            this.columnHeader6.Width = 116;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "SALARIO/HORA";
            this.columnHeader7.Width = 103;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "CARGAHORARIA";
            this.columnHeader8.Width = 119;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "SALARIOMENSAL";
            this.columnHeader9.Width = 102;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "SALARIO MENSAL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 496);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtViuvo;
        private System.Windows.Forms.RadioButton rbtCasado;
        private System.Windows.Forms.RadioButton rbtDivorciado;
        private System.Windows.Forms.RadioButton rbtSolteiro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.RadioButton rbtFeminino;
        private System.Windows.Forms.TextBox txtCargaHoraria;
        private System.Windows.Forms.TextBox txtSalarioHora;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnCadrastrar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView listVisualizar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ComboBox cboNivel;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label6;
    }
}

