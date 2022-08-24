namespace WindowsFormsApp6
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_color = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.books_increm = new System.Windows.Forms.TextBox();
            this.increment = new System.Windows.Forms.Label();
            this.box_length = new System.Windows.Forms.TextBox();
            this.text_3 = new System.Windows.Forms.Label();
            this.box_angel = new System.Windows.Forms.TextBox();
            this.angle_text = new System.Windows.Forms.Label();
            this.text_1 = new System.Windows.Forms.Label();
            this.box_points = new System.Windows.Forms.TextBox();
            this.btn_polygon = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pic_color = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_move = new System.Windows.Forms.Button();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btn_redo = new System.Windows.Forms.Button();
            this.btn_undo = new System.Windows.Forms.Button();
            this.btn_exist = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_color);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btn_load);
            this.panel1.Controls.Add(this.books_increm);
            this.panel1.Controls.Add(this.increment);
            this.panel1.Controls.Add(this.box_length);
            this.panel1.Controls.Add(this.text_3);
            this.panel1.Controls.Add(this.box_angel);
            this.panel1.Controls.Add(this.angle_text);
            this.panel1.Controls.Add(this.text_1);
            this.panel1.Controls.Add(this.box_points);
            this.panel1.Controls.Add(this.btn_polygon);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.pic_color);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.Color.White;
            this.btn_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_color.Image = ((System.Drawing.Image)(resources.GetObject("btn_color.Image")));
            this.btn_color.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_color.Location = new System.Drawing.Point(0, 0);
            this.btn_color.Margin = new System.Windows.Forms.Padding(2);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(128, 100);
            this.btn_color.TabIndex = 3;
            this.btn_color.Text = "Color Palette";
            this.btn_color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 17;
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.White;
            this.btn_load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_load.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_load.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_load.Image = ((System.Drawing.Image)(resources.GetObject("btn_load.Image")));
            this.btn_load.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_load.Location = new System.Drawing.Point(775, 46);
            this.btn_load.Margin = new System.Windows.Forms.Padding(2);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(113, 54);
            this.btn_load.TabIndex = 3;
            this.btn_load.Text = "Load";
            this.btn_load.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // books_increm
            // 
            this.books_increm.Location = new System.Drawing.Point(1036, 74);
            this.books_increm.Margin = new System.Windows.Forms.Padding(2);
            this.books_increm.Name = "books_increm";
            this.books_increm.Size = new System.Drawing.Size(69, 20);
            this.books_increm.TabIndex = 15;
            this.books_increm.Text = "5";
            // 
            // increment
            // 
            this.increment.AutoSize = true;
            this.increment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.increment.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.increment.Location = new System.Drawing.Point(1019, 52);
            this.increment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.increment.Name = "increment";
            this.increment.Size = new System.Drawing.Size(95, 20);
            this.increment.TabIndex = 16;
            this.increment.Text = "Increment ";
            // 
            // box_length
            // 
            this.box_length.Location = new System.Drawing.Point(1153, 74);
            this.box_length.Margin = new System.Windows.Forms.Padding(2);
            this.box_length.Name = "box_length";
            this.box_length.Size = new System.Drawing.Size(69, 20);
            this.box_length.TabIndex = 15;
            this.box_length.Text = "30";
            this.box_length.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // text_3
            // 
            this.text_3.AutoSize = true;
            this.text_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.text_3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.text_3.Location = new System.Drawing.Point(1164, 51);
            this.text_3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text_3.Name = "text_3";
            this.text_3.Size = new System.Drawing.Size(49, 24);
            this.text_3.TabIndex = 15;
            this.text_3.Text = "Lenth";
            this.text_3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.text_3.UseCompatibleTextRendering = true;
            this.text_3.Click += new System.EventHandler(this.btn_length_Click);
            // 
            // box_angel
            // 
            this.box_angel.Location = new System.Drawing.Point(1036, 27);
            this.box_angel.Margin = new System.Windows.Forms.Padding(2);
            this.box_angel.Name = "box_angel";
            this.box_angel.Size = new System.Drawing.Size(69, 20);
            this.box_angel.TabIndex = 14;
            this.box_angel.Text = "75";
            this.box_angel.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // angle_text
            // 
            this.angle_text.AutoSize = true;
            this.angle_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.angle_text.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.angle_text.Location = new System.Drawing.Point(1050, 5);
            this.angle_text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.angle_text.Name = "angle_text";
            this.angle_text.Size = new System.Drawing.Size(55, 20);
            this.angle_text.TabIndex = 13;
            this.angle_text.Text = "Angle";
            // 
            // text_1
            // 
            this.text_1.AutoSize = true;
            this.text_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.text_1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.text_1.Location = new System.Drawing.Point(1160, 5);
            this.text_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text_1.Name = "text_1";
            this.text_1.Size = new System.Drawing.Size(41, 20);
            this.text_1.TabIndex = 12;
            this.text_1.Text = "size";
            this.text_1.Click += new System.EventHandler(this.btn_points_Click);
            // 
            // box_points
            // 
            this.box_points.Location = new System.Drawing.Point(1153, 27);
            this.box_points.Margin = new System.Windows.Forms.Padding(2);
            this.box_points.Name = "box_points";
            this.box_points.Size = new System.Drawing.Size(69, 20);
            this.box_points.TabIndex = 11;
            this.box_points.Text = "20";
            this.box_points.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_polygon
            // 
            this.btn_polygon.BackColor = System.Drawing.Color.White;
            this.btn_polygon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_polygon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_polygon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_polygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_polygon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_polygon.Image = ((System.Drawing.Image)(resources.GetObject("btn_polygon.Image")));
            this.btn_polygon.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_polygon.Location = new System.Drawing.Point(904, 9);
            this.btn_polygon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_polygon.Name = "btn_polygon";
            this.btn_polygon.Size = new System.Drawing.Size(100, 85);
            this.btn_polygon.TabIndex = 10;
            this.btn_polygon.Text = "Polygon";
            this.btn_polygon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_polygon.UseVisualStyleBackColor = false;
            this.btn_polygon.Click += new System.EventHandler(this.btn_polygon_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.Location = new System.Drawing.Point(775, 0);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(113, 51);
            this.btn_save.TabIndex = 9;
            this.btn_save.Tag = "Clear";
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.White;
            this.pic_color.Location = new System.Drawing.Point(148, 33);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(38, 42);
            this.pic_color.TabIndex = 0;
            this.pic_color.UseVisualStyleBackColor = false;
            this.pic_color.Click += new System.EventHandler(this.pic_color_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.btn_move);
            this.panel3.Controls.Add(this.btn_fill);
            this.panel3.Controls.Add(this.btn_pencil);
            this.panel3.Controls.Add(this.btn_eraser);
            this.panel3.Controls.Add(this.btn_ellipse);
            this.panel3.Controls.Add(this.btn_rect);
            this.panel3.Controls.Add(this.btn_line);
            this.panel3.Location = new System.Drawing.Point(213, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(549, 82);
            this.panel3.TabIndex = 3;
            // 
            // btn_move
            // 
            this.btn_move.BackColor = System.Drawing.Color.White;
            this.btn_move.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_move.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_move.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_move.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_move.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_move.Image = ((System.Drawing.Image)(resources.GetObject("btn_move.Image")));
            this.btn_move.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_move.Location = new System.Drawing.Point(-1, -2);
            this.btn_move.Margin = new System.Windows.Forms.Padding(2);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(71, 85);
            this.btn_move.TabIndex = 0;
            this.btn_move.Text = "Move";
            this.btn_move.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_move.UseVisualStyleBackColor = false;
            this.btn_move.Click += new System.EventHandler(this.btn_move_Click);
            // 
            // btn_fill
            // 
            this.btn_fill.BackColor = System.Drawing.Color.White;
            this.btn_fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_fill.Image = ((System.Drawing.Image)(resources.GetObject("btn_fill.Image")));
            this.btn_fill.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_fill.Location = new System.Drawing.Point(67, -2);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(66, 90);
            this.btn_fill.TabIndex = 2;
            this.btn_fill.Text = "Fill";
            this.btn_fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_fill.UseVisualStyleBackColor = false;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // btn_pencil
            // 
            this.btn_pencil.BackColor = System.Drawing.Color.White;
            this.btn_pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pencil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_pencil.Image = ((System.Drawing.Image)(resources.GetObject("btn_pencil.Image")));
            this.btn_pencil.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_pencil.Location = new System.Drawing.Point(131, -3);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(67, 91);
            this.btn_pencil.TabIndex = 3;
            this.btn_pencil.Text = "Pencil";
            this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pencil.UseVisualStyleBackColor = false;
            this.btn_pencil.Click += new System.EventHandler(this.btn_pencil_Click);
            // 
            // btn_eraser
            // 
            this.btn_eraser.BackColor = System.Drawing.Color.White;
            this.btn_eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_eraser.Image = ((System.Drawing.Image)(resources.GetObject("btn_eraser.Image")));
            this.btn_eraser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_eraser.Location = new System.Drawing.Point(190, -2);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(93, 85);
            this.btn_eraser.TabIndex = 4;
            this.btn_eraser.Text = "Earser";
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eraser.UseVisualStyleBackColor = false;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.BackColor = System.Drawing.Color.White;
            this.btn_ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ellipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_ellipse.Image = ((System.Drawing.Image)(resources.GetObject("btn_ellipse.Image")));
            this.btn_ellipse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ellipse.Location = new System.Drawing.Point(271, -3);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(97, 87);
            this.btn_ellipse.TabIndex = 5;
            this.btn_ellipse.Text = "Elipse";
            this.btn_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_ellipse.UseVisualStyleBackColor = false;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.BackColor = System.Drawing.Color.White;
            this.btn_rect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_rect.Image = ((System.Drawing.Image)(resources.GetObject("btn_rect.Image")));
            this.btn_rect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rect.Location = new System.Drawing.Point(356, -2);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(115, 87);
            this.btn_rect.TabIndex = 6;
            this.btn_rect.Text = "Rectangle";
            this.btn_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rect.UseVisualStyleBackColor = false;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // btn_line
            // 
            this.btn_line.BackColor = System.Drawing.Color.White;
            this.btn_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_line.Image = ((System.Drawing.Image)(resources.GetObject("btn_line.Image")));
            this.btn_line.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_line.Location = new System.Drawing.Point(461, -3);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(89, 87);
            this.btn_line.TabIndex = 7;
            this.btn_line.Text = "Line";
            this.btn_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_line.UseVisualStyleBackColor = false;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.White;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.Image")));
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.Location = new System.Drawing.Point(1010, -2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(113, 67);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Tag = "Clear";
            this.btn_clear.Text = "Clear";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Controls.Add(this.btn_redo);
            this.panel2.Controls.Add(this.btn_undo);
            this.panel2.Controls.Add(this.btn_exist);
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1247, 65);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.Location = new System.Drawing.Point(25, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pen Width";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(3, 20);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(174, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btn_redo
            // 
            this.btn_redo.BackColor = System.Drawing.Color.White;
            this.btn_redo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_redo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_redo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_redo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_redo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_redo.Image = ((System.Drawing.Image)(resources.GetObject("btn_redo.Image")));
            this.btn_redo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_redo.Location = new System.Drawing.Point(776, -4);
            this.btn_redo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_redo.Name = "btn_redo";
            this.btn_redo.Size = new System.Drawing.Size(120, 69);
            this.btn_redo.TabIndex = 9;
            this.btn_redo.Tag = "";
            this.btn_redo.Text = "Redo";
            this.btn_redo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_redo.UseVisualStyleBackColor = false;
            this.btn_redo.Click += new System.EventHandler(this.btn_redo_Click);
            // 
            // btn_undo
            // 
            this.btn_undo.BackColor = System.Drawing.Color.White;
            this.btn_undo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_undo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_undo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_undo.Image = ((System.Drawing.Image)(resources.GetObject("btn_undo.Image")));
            this.btn_undo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_undo.Location = new System.Drawing.Point(894, -1);
            this.btn_undo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_undo.Name = "btn_undo";
            this.btn_undo.Size = new System.Drawing.Size(118, 66);
            this.btn_undo.TabIndex = 9;
            this.btn_undo.Text = "Undo";
            this.btn_undo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_undo.UseVisualStyleBackColor = false;
            this.btn_undo.Click += new System.EventHandler(this.btn_undo_Click);
            // 
            // btn_exist
            // 
            this.btn_exist.BackColor = System.Drawing.Color.White;
            this.btn_exist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_exist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_exist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_exist.Image = ((System.Drawing.Image)(resources.GetObject("btn_exist.Image")));
            this.btn_exist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exist.Location = new System.Drawing.Point(1122, -2);
            this.btn_exist.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exist.Name = "btn_exist";
            this.btn_exist.Size = new System.Drawing.Size(112, 67);
            this.btn_exist.TabIndex = 3;
            this.btn_exist.Text = "Exit";
            this.btn_exist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exist.UseVisualStyleBackColor = false;
            this.btn_exist.Click += new System.EventHandler(this.btn_exist_Click);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 100);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1247, 285);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 450);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dor and Tal Painter";
            this.Load += new System.EventHandler(this.form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_polygon;
        private System.Windows.Forms.TextBox box_points;
        private System.Windows.Forms.Label text_1;
        private System.Windows.Forms.Label angle_text;
        private System.Windows.Forms.TextBox box_angel;
        private System.Windows.Forms.Label text_3;
        private System.Windows.Forms.TextBox box_length;
        private System.Windows.Forms.TextBox books_increm;
        private System.Windows.Forms.Label increment;
        private System.Windows.Forms.Button btn_exist;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_undo;
        private System.Windows.Forms.Button btn_move;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_redo;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
    }
}

