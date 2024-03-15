namespace PictureViewer
{
    partial class PictureViewer
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkbox = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.Setthebackroundcolour = new System.Windows.Forms.Button();
            this.Clearthepicture = new System.Windows.Forms.Button();
            this.Showthepicture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.04702F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.95298F));
            this.tableLayoutPanel1.Controls.Add(this.checkbox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(638, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // checkbox
            // 
            this.checkbox.AutoSize = true;
            this.checkbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkbox.Location = new System.Drawing.Point(3, 388);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(89, 59);
            this.checkbox.TabIndex = 0;
            this.checkbox.Text = "Stretch";
            this.checkbox.UseVisualStyleBackColor = true;
            this.checkbox.CheckedChanged += new System.EventHandler(this.chOne_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.CloseButton);
            this.flowLayoutPanel1.Controls.Add(this.Setthebackroundcolour);
            this.flowLayoutPanel1.Controls.Add(this.Clearthepicture);
            this.flowLayoutPanel1.Controls.Add(this.Showthepicture);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(98, 388);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(537, 59);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Location = new System.Drawing.Point(3, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 56);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Setthebackroundcolour
            // 
            this.Setthebackroundcolour.AutoSize = true;
            this.Setthebackroundcolour.Location = new System.Drawing.Point(84, 3);
            this.Setthebackroundcolour.Name = "Setthebackroundcolour";
            this.Setthebackroundcolour.Size = new System.Drawing.Size(165, 56);
            this.Setthebackroundcolour.TabIndex = 1;
            this.Setthebackroundcolour.Text = "Set the backround colour";
            this.Setthebackroundcolour.UseVisualStyleBackColor = true;
            this.Setthebackroundcolour.Click += new System.EventHandler(this.Setthebackroundcolour_Click);
            // 
            // Clearthepicture
            // 
            this.Clearthepicture.AutoSize = true;
            this.Clearthepicture.Location = new System.Drawing.Point(255, 3);
            this.Clearthepicture.Name = "Clearthepicture";
            this.Clearthepicture.Size = new System.Drawing.Size(113, 56);
            this.Clearthepicture.TabIndex = 2;
            this.Clearthepicture.Text = "Clear the picture";
            this.Clearthepicture.UseVisualStyleBackColor = true;
            this.Clearthepicture.Click += new System.EventHandler(this.Clearthepicture_Click);
            // 
            // Showthepicture
            // 
            this.Showthepicture.AutoSize = true;
            this.Showthepicture.Location = new System.Drawing.Point(374, 3);
            this.Showthepicture.Name = "Showthepicture";
            this.Showthepicture.Size = new System.Drawing.Size(114, 56);
            this.Showthepicture.TabIndex = 3;
            this.Showthepicture.Text = "Show the picture";
            this.Showthepicture.UseVisualStyleBackColor = true;
            this.Showthepicture.Click += new System.EventHandler(this.Showthepicture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(98, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(537, 379);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            this.openFileDialog1.Title = "Select the picture";
            // 
            // PictureViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PictureViewer";
            this.Text = "PictureViewer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox checkbox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button Setthebackroundcolour;
        private System.Windows.Forms.Button Clearthepicture;
        private System.Windows.Forms.Button Showthepicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

