namespace trabalho
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lv_Emp = new System.Windows.Forms.ListView();
            this.Item2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantidade2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefone2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Gel = new System.Windows.Forms.ListView();
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Local = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Usu = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btRel = new System.Windows.Forms.Button();
            this.btOut = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btAtt = new System.Windows.Forms.Button();
            this.btGra = new System.Windows.Forms.Button();
            this.tbSeuNum = new System.Windows.Forms.TextBox();
            this.lbLocNum = new System.Windows.Forms.Label();
            this.tbDon = new System.Windows.Forms.TextBox();
            this.tbNomIte = new System.Windows.Forms.TextBox();
            this.tbNumQtd = new System.Windows.Forms.TextBox();
            this.lbDon = new System.Windows.Forms.Label();
            this.cbLoc = new System.Windows.Forms.ComboBox();
            this.lbNomIte = new System.Windows.Forms.Label();
            this.lbNumQtd = new System.Windows.Forms.Label();
            this.rbEmprestimo = new System.Windows.Forms.RadioButton();
            this.rbGeladeira = new System.Windows.Forms.RadioButton();
            this.rbUsuario = new System.Windows.Forms.RadioButton();
            this.mtbNumU = new System.Windows.Forms.MaskedTextBox();
            this.mtbNumE = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lv_Emp
            // 
            this.lv_Emp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item2,
            this.Quantidade2,
            this.Telefone2,
            this.Dono});
            this.lv_Emp.HideSelection = false;
            this.lv_Emp.Location = new System.Drawing.Point(459, 464);
            this.lv_Emp.Name = "lv_Emp";
            this.lv_Emp.Size = new System.Drawing.Size(309, 243);
            this.lv_Emp.TabIndex = 42;
            this.lv_Emp.UseCompatibleStateImageBehavior = false;
            this.lv_Emp.View = System.Windows.Forms.View.Details;
            // 
            // Item2
            // 
            this.Item2.Text = "Item";
            this.Item2.Width = 80;
            // 
            // Quantidade2
            // 
            this.Quantidade2.Text = "Qtd";
            this.Quantidade2.Width = 30;
            // 
            // Telefone2
            // 
            this.Telefone2.Text = "Telefone";
            this.Telefone2.Width = 100;
            // 
            // Dono
            // 
            this.Dono.Text = "Dono";
            this.Dono.Width = 100;
            // 
            // lv_Gel
            // 
            this.lv_Gel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.Quantidade,
            this.Local});
            this.lv_Gel.HideSelection = false;
            this.lv_Gel.Location = new System.Drawing.Point(259, 464);
            this.lv_Gel.Name = "lv_Gel";
            this.lv_Gel.Size = new System.Drawing.Size(194, 243);
            this.lv_Gel.TabIndex = 41;
            this.lv_Gel.UseCompatibleStateImageBehavior = false;
            this.lv_Gel.View = System.Windows.Forms.View.Details;
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 80;
            // 
            // Quantidade
            // 
            this.Quantidade.Text = "Qtd";
            this.Quantidade.Width = 30;
            // 
            // Local
            // 
            this.Local.Text = "Local";
            this.Local.Width = 80;
            // 
            // lv_Usu
            // 
            this.lv_Usu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Telefone});
            this.lv_Usu.HideSelection = false;
            this.lv_Usu.Location = new System.Drawing.Point(68, 464);
            this.lv_Usu.Name = "lv_Usu";
            this.lv_Usu.Size = new System.Drawing.Size(185, 243);
            this.lv_Usu.TabIndex = 40;
            this.lv_Usu.UseCompatibleStateImageBehavior = false;
            this.lv_Usu.View = System.Windows.Forms.View.Details;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 80;
            // 
            // Telefone
            // 
            this.Telefone.Text = "Telefone";
            this.Telefone.Width = 100;
            // 
            // btRel
            // 
            this.btRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btRel.Location = new System.Drawing.Point(527, 377);
            this.btRel.Name = "btRel";
            this.btRel.Size = new System.Drawing.Size(87, 33);
            this.btRel.TabIndex = 39;
            this.btRel.Text = "Reload";
            this.btRel.UseVisualStyleBackColor = true;
            this.btRel.Click += new System.EventHandler(this.btRel_Click);
            // 
            // btOut
            // 
            this.btOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btOut.Location = new System.Drawing.Point(680, 377);
            this.btOut.Name = "btOut";
            this.btOut.Size = new System.Drawing.Size(87, 33);
            this.btOut.TabIndex = 38;
            this.btOut.Text = "Sair";
            this.btOut.UseVisualStyleBackColor = true;
            this.btOut.Click += new System.EventHandler(this.btOut_Click);
            // 
            // btDel
            // 
            this.btDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btDel.Location = new System.Drawing.Point(374, 377);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(87, 33);
            this.btDel.TabIndex = 37;
            this.btDel.Text = "Deletar";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btAtt
            // 
            this.btAtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btAtt.Location = new System.Drawing.Point(221, 377);
            this.btAtt.Name = "btAtt";
            this.btAtt.Size = new System.Drawing.Size(87, 33);
            this.btAtt.TabIndex = 36;
            this.btAtt.Text = "Atualizar";
            this.btAtt.UseVisualStyleBackColor = true;
            this.btAtt.Click += new System.EventHandler(this.btAtt_Click);
            // 
            // btGra
            // 
            this.btGra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btGra.Location = new System.Drawing.Point(68, 377);
            this.btGra.Name = "btGra";
            this.btGra.Size = new System.Drawing.Size(87, 33);
            this.btGra.TabIndex = 35;
            this.btGra.Text = "Gravar";
            this.btGra.UseVisualStyleBackColor = true;
            this.btGra.Click += new System.EventHandler(this.btGra_Click);
            // 
            // tbSeuNum
            // 
            this.tbSeuNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbSeuNum.Location = new System.Drawing.Point(195, 226);
            this.tbSeuNum.Name = "tbSeuNum";
            this.tbSeuNum.Size = new System.Drawing.Size(572, 26);
            this.tbSeuNum.TabIndex = 34;
            // 
            // lbLocNum
            // 
            this.lbLocNum.AutoSize = true;
            this.lbLocNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbLocNum.Location = new System.Drawing.Point(64, 229);
            this.lbLocNum.Name = "lbLocNum";
            this.lbLocNum.Size = new System.Drawing.Size(47, 20);
            this.lbLocNum.TabIndex = 33;
            this.lbLocNum.Text = "Local";
            // 
            // tbDon
            // 
            this.tbDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbDon.Location = new System.Drawing.Point(195, 280);
            this.tbDon.Name = "tbDon";
            this.tbDon.Size = new System.Drawing.Size(573, 26);
            this.tbDon.TabIndex = 32;
            // 
            // tbNomIte
            // 
            this.tbNomIte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbNomIte.Location = new System.Drawing.Point(195, 122);
            this.tbNomIte.Name = "tbNomIte";
            this.tbNomIte.Size = new System.Drawing.Size(573, 26);
            this.tbNomIte.TabIndex = 31;
            // 
            // tbNumQtd
            // 
            this.tbNumQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbNumQtd.Location = new System.Drawing.Point(195, 174);
            this.tbNumQtd.Name = "tbNumQtd";
            this.tbNumQtd.Size = new System.Drawing.Size(573, 26);
            this.tbNumQtd.TabIndex = 30;
            // 
            // lbDon
            // 
            this.lbDon.AutoSize = true;
            this.lbDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbDon.Location = new System.Drawing.Point(64, 281);
            this.lbDon.Name = "lbDon";
            this.lbDon.Size = new System.Drawing.Size(48, 20);
            this.lbDon.TabIndex = 29;
            this.lbDon.Text = "Dono";
            // 
            // cbLoc
            // 
            this.cbLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbLoc.FormattingEnabled = true;
            this.cbLoc.Items.AddRange(new object[] {
            "Frezer",
            "Geladeira",
            "Caixa de Legumes"});
            this.cbLoc.Location = new System.Drawing.Point(195, 226);
            this.cbLoc.Name = "cbLoc";
            this.cbLoc.Size = new System.Drawing.Size(573, 28);
            this.cbLoc.TabIndex = 28;
            // 
            // lbNomIte
            // 
            this.lbNomIte.AutoSize = true;
            this.lbNomIte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbNomIte.Location = new System.Drawing.Point(64, 125);
            this.lbNomIte.Name = "lbNomIte";
            this.lbNomIte.Size = new System.Drawing.Size(51, 20);
            this.lbNomIte.TabIndex = 27;
            this.lbNomIte.Text = "Nome";
            // 
            // lbNumQtd
            // 
            this.lbNumQtd.AutoSize = true;
            this.lbNumQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbNumQtd.Location = new System.Drawing.Point(64, 177);
            this.lbNumQtd.Name = "lbNumQtd";
            this.lbNumQtd.Size = new System.Drawing.Size(71, 20);
            this.lbNumQtd.TabIndex = 26;
            this.lbNumQtd.Text = "Telefone";
            // 
            // rbEmprestimo
            // 
            this.rbEmprestimo.AutoSize = true;
            this.rbEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbEmprestimo.Location = new System.Drawing.Point(630, 44);
            this.rbEmprestimo.Name = "rbEmprestimo";
            this.rbEmprestimo.Size = new System.Drawing.Size(112, 24);
            this.rbEmprestimo.TabIndex = 25;
            this.rbEmprestimo.TabStop = true;
            this.rbEmprestimo.Text = "Emprestimo";
            this.rbEmprestimo.UseVisualStyleBackColor = true;
            this.rbEmprestimo.CheckedChanged += new System.EventHandler(this.rbEmprestimo_CheckedChanged);
            // 
            // rbGeladeira
            // 
            this.rbGeladeira.AutoSize = true;
            this.rbGeladeira.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbGeladeira.Location = new System.Drawing.Point(383, 44);
            this.rbGeladeira.Name = "rbGeladeira";
            this.rbGeladeira.Size = new System.Drawing.Size(96, 24);
            this.rbGeladeira.TabIndex = 24;
            this.rbGeladeira.TabStop = true;
            this.rbGeladeira.Text = "Geladeira";
            this.rbGeladeira.UseVisualStyleBackColor = true;
            this.rbGeladeira.CheckedChanged += new System.EventHandler(this.rbGeladeira_CheckedChanged);
            // 
            // rbUsuario
            // 
            this.rbUsuario.AutoSize = true;
            this.rbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbUsuario.Location = new System.Drawing.Point(150, 44);
            this.rbUsuario.Name = "rbUsuario";
            this.rbUsuario.Size = new System.Drawing.Size(82, 24);
            this.rbUsuario.TabIndex = 23;
            this.rbUsuario.TabStop = true;
            this.rbUsuario.Text = "Usuário";
            this.rbUsuario.UseVisualStyleBackColor = true;
            this.rbUsuario.CheckedChanged += new System.EventHandler(this.rbUsuario_CheckedChanged);
            // 
            // mtbNumU
            // 
            this.mtbNumU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mtbNumU.Location = new System.Drawing.Point(195, 174);
            this.mtbNumU.Name = "mtbNumU";
            this.mtbNumU.Size = new System.Drawing.Size(573, 26);
            this.mtbNumU.TabIndex = 43;
            // 
            // mtbNumE
            // 
            this.mtbNumE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mtbNumE.Location = new System.Drawing.Point(195, 229);
            this.mtbNumE.Name = "mtbNumE";
            this.mtbNumE.Size = new System.Drawing.Size(572, 26);
            this.mtbNumE.TabIndex = 44;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 750);
            this.Controls.Add(this.mtbNumE);
            this.Controls.Add(this.mtbNumU);
            this.Controls.Add(this.lv_Emp);
            this.Controls.Add(this.lv_Gel);
            this.Controls.Add(this.lv_Usu);
            this.Controls.Add(this.btRel);
            this.Controls.Add(this.btOut);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btAtt);
            this.Controls.Add(this.btGra);
            this.Controls.Add(this.tbSeuNum);
            this.Controls.Add(this.lbLocNum);
            this.Controls.Add(this.tbDon);
            this.Controls.Add(this.tbNomIte);
            this.Controls.Add(this.tbNumQtd);
            this.Controls.Add(this.lbDon);
            this.Controls.Add(this.cbLoc);
            this.Controls.Add(this.lbNomIte);
            this.Controls.Add(this.lbNumQtd);
            this.Controls.Add(this.rbEmprestimo);
            this.Controls.Add(this.rbGeladeira);
            this.Controls.Add(this.rbUsuario);
            this.Name = "Form1";
            this.Text = "1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_Emp;
        private System.Windows.Forms.ColumnHeader Item2;
        private System.Windows.Forms.ColumnHeader Quantidade2;
        private System.Windows.Forms.ColumnHeader Telefone2;
        private System.Windows.Forms.ColumnHeader Dono;
        private System.Windows.Forms.ListView lv_Gel;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader Quantidade;
        private System.Windows.Forms.ColumnHeader Local;
        private System.Windows.Forms.ListView lv_Usu;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Telefone;
        private System.Windows.Forms.Button btRel;
        private System.Windows.Forms.Button btOut;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btAtt;
        private System.Windows.Forms.Button btGra;
        private System.Windows.Forms.TextBox tbSeuNum;
        private System.Windows.Forms.Label lbLocNum;
        private System.Windows.Forms.TextBox tbDon;
        private System.Windows.Forms.TextBox tbNomIte;
        private System.Windows.Forms.TextBox tbNumQtd;
        private System.Windows.Forms.Label lbDon;
        private System.Windows.Forms.ComboBox cbLoc;
        private System.Windows.Forms.Label lbNomIte;
        private System.Windows.Forms.Label lbNumQtd;
        private System.Windows.Forms.RadioButton rbEmprestimo;
        private System.Windows.Forms.RadioButton rbGeladeira;
        private System.Windows.Forms.RadioButton rbUsuario;
        private System.Windows.Forms.MaskedTextBox mtbNumU;
        private System.Windows.Forms.MaskedTextBox mtbNumE;
    }
}

