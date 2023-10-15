namespace cs2servergui
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
            this.start_btn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.game_mode = new System.Windows.Forms.Label();
            this.game_mode_sel = new System.Windows.Forms.ComboBox();
            this.game_type = new System.Windows.Forms.Label();
            this.game_type_sel = new System.Windows.Forms.ComboBox();
            this.map_sel = new System.Windows.Forms.ComboBox();
            this.map = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(12, 459);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(141, 44);
            this.start_btn.TabIndex = 0;
            this.start_btn.Text = "Start Server";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.title.Location = new System.Drawing.Point(102, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(159, 26);
            this.title.TabIndex = 1;
            this.title.Text = "EZ CS2 Server";
            // 
            // game_mode
            // 
            this.game_mode.AutoSize = true;
            this.game_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_mode.Location = new System.Drawing.Point(21, 222);
            this.game_mode.Name = "game_mode";
            this.game_mode.Size = new System.Drawing.Size(98, 20);
            this.game_mode.TabIndex = 2;
            this.game_mode.Text = "game_mode";
            // 
            // game_mode_sel
            // 
            this.game_mode_sel.FormattingEnabled = true;
            this.game_mode_sel.Items.AddRange(new object[] {
            "0 (casual)",
            "1 (competitive)",
            "2 (wingman)",
            "3 (weapons expert)",
            "4 (training day)"});
            this.game_mode_sel.Location = new System.Drawing.Point(129, 220);
            this.game_mode_sel.Name = "game_mode_sel";
            this.game_mode_sel.Size = new System.Drawing.Size(121, 21);
            this.game_mode_sel.TabIndex = 3;
            this.game_mode_sel.SelectedIndexChanged += new System.EventHandler(this.game_mode_SelectedIndexChanged);
            // 
            // game_type
            // 
            this.game_type.AutoSize = true;
            this.game_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_type.Location = new System.Drawing.Point(21, 251);
            this.game_type.Name = "game_type";
            this.game_type.Size = new System.Drawing.Size(88, 20);
            this.game_type.TabIndex = 4;
            this.game_type.Text = "game_type";
            // 
            // game_type_sel
            // 
            this.game_type_sel.FormattingEnabled = true;
            this.game_type_sel.Items.AddRange(new object[] {
            "0 (classic)",
            "1 (gun game)",
            "2 (training)",
            "3 (custom)",
            "4 (coop)",
            "5 (skirmish)",
            "6 (ffa)"});
            this.game_type_sel.Location = new System.Drawing.Point(129, 253);
            this.game_type_sel.Name = "game_type_sel";
            this.game_type_sel.Size = new System.Drawing.Size(121, 21);
            this.game_type_sel.TabIndex = 5;
            this.game_type_sel.SelectedIndexChanged += new System.EventHandler(this.game_type_SelectedIndexChanged);
            // 
            // map_sel
            // 
            this.map_sel.FormattingEnabled = true;
            this.map_sel.Items.AddRange(new object[] {
            "cs_italy",
            "cs_office",
            "de_ancient",
            "de_anubis",
            "de_dust2",
            "de_inferno",
            "de_mirage",
            "de_nuke",
            "de_overpass",
            "de_vertigo"});
            this.map_sel.Location = new System.Drawing.Point(129, 284);
            this.map_sel.Name = "map_sel";
            this.map_sel.Size = new System.Drawing.Size(121, 21);
            this.map_sel.TabIndex = 7;
            this.map_sel.SelectedIndexChanged += new System.EventHandler(this.map_sel_SelectedIndexChanged);
            // 
            // map
            // 
            this.map.AutoSize = true;
            this.map.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.map.Location = new System.Drawing.Point(21, 282);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(40, 20);
            this.map.TabIndex = 6;
            this.map.Text = "map";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(339, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "use this for info on the game_mode and game_type";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Select Path";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "select your path above ";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 29);
            this.label2.TabIndex = 11;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(332, 480);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "log";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "⌄⌄⌄⌄";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label4.Location = new System.Drawing.Point(162, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "PATH";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 515);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.map_sel);
            this.Controls.Add(this.map);
            this.Controls.Add(this.game_type_sel);
            this.Controls.Add(this.game_type);
            this.Controls.Add(this.game_mode_sel);
            this.Controls.Add(this.game_mode);
            this.Controls.Add(this.title);
            this.Controls.Add(this.start_btn);
            this.Name = "Form1";
            this.Text = "EZ CS2 Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label game_mode;
        private System.Windows.Forms.ComboBox game_mode_sel;
        private System.Windows.Forms.Label game_type;
        private System.Windows.Forms.ComboBox game_type_sel;
        private System.Windows.Forms.ComboBox map_sel;
        private System.Windows.Forms.Label map;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

