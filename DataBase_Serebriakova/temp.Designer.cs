namespace DataBase_Serebriakova
{
    partial class temp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(temp));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.doing = new System.Windows.Forms.Label();
            this.listizmen = new System.Windows.Forms.ListBox();
            this.izmen = new System.Windows.Forms.Label();
            this.buttondelete = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.textizmen = new System.Windows.Forms.TextBox();
            this.replace2 = new System.Windows.Forms.Label();
            this.textadd2 = new System.Windows.Forms.TextBox();
            this.textadd3 = new System.Windows.Forms.TextBox();
            this.textadd4 = new System.Windows.Forms.TextBox();
            this.add2 = new System.Windows.Forms.Label();
            this.add3 = new System.Windows.Forms.Label();
            this.add4 = new System.Windows.Forms.Label();
            this.textadd5 = new System.Windows.Forms.TextBox();
            this.add5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите номер актёра (ID), которого хотите удалить";
            this.label1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            // 
            // doing
            // 
            this.doing.AutoSize = true;
            this.doing.Location = new System.Drawing.Point(12, 428);
            this.doing.Name = "doing";
            this.doing.Size = new System.Drawing.Size(13, 13);
            this.doing.TabIndex = 2;
            this.doing.Text = "1";
            this.doing.Visible = false;
            // 
            // listizmen
            // 
            this.listizmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listizmen.FormattingEnabled = true;
            this.listizmen.ItemHeight = 16;
            this.listizmen.Items.AddRange(new object[] {
            "номер",
            "фио",
            "ранг",
            "опыт"});
            this.listizmen.Location = new System.Drawing.Point(15, 77);
            this.listizmen.Name = "listizmen";
            this.listizmen.Size = new System.Drawing.Size(120, 68);
            this.listizmen.TabIndex = 3;
            this.listizmen.Visible = false;
            // 
            // izmen
            // 
            this.izmen.AutoSize = true;
            this.izmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.izmen.Location = new System.Drawing.Point(12, 55);
            this.izmen.Name = "izmen";
            this.izmen.Size = new System.Drawing.Size(240, 16);
            this.izmen.TabIndex = 4;
            this.izmen.Text = "Выберите поле для изменения:";
            this.izmen.Visible = false;
            // 
            // buttondelete
            // 
            this.buttondelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttondelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondelete.Image = ((System.Drawing.Image)(resources.GetObject("buttondelete.Image")));
            this.buttondelete.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttondelete.Location = new System.Drawing.Point(12, 298);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(75, 140);
            this.buttondelete.TabIndex = 14;
            this.buttondelete.Text = "У\r\nд\r\nа\r\nл\r\nи\r\nт\r\nь";
            this.buttondelete.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttondelete.UseVisualStyleBackColor = false;
            this.buttondelete.Visible = false;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button6.Location = new System.Drawing.Point(112, 298);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 140);
            this.button6.TabIndex = 15;
            this.button6.Text = "И\r\nз\r\nм\r\nе\r\nн\r\nи\r\nт\r\nь";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonadd.Image = ((System.Drawing.Image)(resources.GetObject("buttonadd.Image")));
            this.buttonadd.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonadd.Location = new System.Drawing.Point(204, 298);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(75, 140);
            this.buttonadd.TabIndex = 16;
            this.buttonadd.Text = "Д\r\nо\r\nб\r\nа\r\nв\r\nи\r\nт\r\nь";
            this.buttonadd.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonadd.UseVisualStyleBackColor = false;
            this.buttonadd.Visible = false;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // textizmen
            // 
            this.textizmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textizmen.Location = new System.Drawing.Point(15, 151);
            this.textizmen.Name = "textizmen";
            this.textizmen.Size = new System.Drawing.Size(262, 21);
            this.textizmen.TabIndex = 17;
            this.textizmen.Visible = false;
            // 
            // replace2
            // 
            this.replace2.AutoSize = true;
            this.replace2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.replace2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.replace2.Location = new System.Drawing.Point(38, 175);
            this.replace2.Name = "replace2";
            this.replace2.Size = new System.Drawing.Size(214, 32);
            this.replace2.TabIndex = 18;
            this.replace2.Text = "Введите выше ту информацию, \r\nна которую хотите заменить";
            this.replace2.Visible = false;
            // 
            // textadd2
            // 
            this.textadd2.Location = new System.Drawing.Point(174, 169);
            this.textadd2.Name = "textadd2";
            this.textadd2.Size = new System.Drawing.Size(100, 20);
            this.textadd2.TabIndex = 20;
            this.textadd2.Visible = false;
            // 
            // textadd3
            // 
            this.textadd3.Location = new System.Drawing.Point(174, 195);
            this.textadd3.Name = "textadd3";
            this.textadd3.Size = new System.Drawing.Size(100, 20);
            this.textadd3.TabIndex = 21;
            this.textadd3.Visible = false;
            // 
            // textadd4
            // 
            this.textadd4.Location = new System.Drawing.Point(174, 221);
            this.textadd4.Name = "textadd4";
            this.textadd4.Size = new System.Drawing.Size(100, 20);
            this.textadd4.TabIndex = 22;
            this.textadd4.Visible = false;
            // 
            // add2
            // 
            this.add2.AutoSize = true;
            this.add2.Location = new System.Drawing.Point(129, 172);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(39, 13);
            this.add2.TabIndex = 24;
            this.add2.Text = "номер";
            this.add2.Visible = false;
            // 
            // add3
            // 
            this.add3.AutoSize = true;
            this.add3.Location = new System.Drawing.Point(134, 198);
            this.add3.Name = "add3";
            this.add3.Size = new System.Drawing.Size(34, 13);
            this.add3.TabIndex = 25;
            this.add3.Text = "ФИО";
            this.add3.Visible = false;
            // 
            // add4
            // 
            this.add4.AutoSize = true;
            this.add4.Location = new System.Drawing.Point(137, 224);
            this.add4.Name = "add4";
            this.add4.Size = new System.Drawing.Size(31, 13);
            this.add4.TabIndex = 26;
            this.add4.Text = "Ранг";
            this.add4.Visible = false;
            // 
            // textadd5
            // 
            this.textadd5.Location = new System.Drawing.Point(174, 247);
            this.textadd5.Name = "textadd5";
            this.textadd5.Size = new System.Drawing.Size(100, 20);
            this.textadd5.TabIndex = 27;
            this.textadd5.Visible = false;
            // 
            // add5
            // 
            this.add5.AutoSize = true;
            this.add5.Location = new System.Drawing.Point(135, 250);
            this.add5.Name = "add5";
            this.add5.Size = new System.Drawing.Size(33, 13);
            this.add5.TabIndex = 28;
            this.add5.Text = "Стаж";
            this.add5.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "<- Выбрать нужное";
            this.label2.Visible = false;
            // 
            // temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add5);
            this.Controls.Add(this.textadd5);
            this.Controls.Add(this.add4);
            this.Controls.Add(this.add3);
            this.Controls.Add(this.add2);
            this.Controls.Add(this.textadd4);
            this.Controls.Add(this.textadd3);
            this.Controls.Add(this.textadd2);
            this.Controls.Add(this.replace2);
            this.Controls.Add(this.textizmen);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.izmen);
            this.Controls.Add(this.listizmen);
            this.Controls.Add(this.doing);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "temp";
            this.Text = "Редактирование";
            this.Load += new System.EventHandler(this.temp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label doing;
        private System.Windows.Forms.ListBox listizmen;
        private System.Windows.Forms.Label izmen;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.TextBox textizmen;
        private System.Windows.Forms.Label replace2;
        private System.Windows.Forms.TextBox textadd2;
        private System.Windows.Forms.TextBox textadd3;
        private System.Windows.Forms.TextBox textadd4;
        private System.Windows.Forms.Label add2;
        private System.Windows.Forms.Label add3;
        private System.Windows.Forms.Label add4;
        private System.Windows.Forms.TextBox textadd5;
        private System.Windows.Forms.Label add5;
        private System.Windows.Forms.Label label2;
    }
}