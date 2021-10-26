
namespace GadgetMachine
{
    partial class MainWindow
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
            this.gadgetInfoField = new System.Windows.Forms.RichTextBox();
            this.notebookAmount = new System.Windows.Forms.Label();
            this.tabletAmount = new System.Windows.Forms.Label();
            this.smartphoneAmount = new System.Windows.Forms.Label();
            this.notebookLabel = new System.Windows.Forms.Label();
            this.tabletLabel = new System.Windows.Forms.Label();
            this.smartphoneLabel = new System.Windows.Forms.Label();
            this.gadgetPicture = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.queueLabel = new System.Windows.Forms.Label();
            this.fillButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gadgetPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // gadgetInfoField
            // 
            this.gadgetInfoField.BackColor = System.Drawing.Color.AliceBlue;
            this.gadgetInfoField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gadgetInfoField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gadgetInfoField.Location = new System.Drawing.Point(170, 115);
            this.gadgetInfoField.Name = "gadgetInfoField";
            this.gadgetInfoField.ReadOnly = true;
            this.gadgetInfoField.Size = new System.Drawing.Size(597, 274);
            this.gadgetInfoField.TabIndex = 0;
            this.gadgetInfoField.Text = "";
            // 
            // notebookAmount
            // 
            this.notebookAmount.BackColor = System.Drawing.Color.AliceBlue;
            this.notebookAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.notebookAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notebookAmount.Location = new System.Drawing.Point(170, 20);
            this.notebookAmount.Name = "notebookAmount";
            this.notebookAmount.Size = new System.Drawing.Size(195, 46);
            this.notebookAmount.TabIndex = 2;
            this.notebookAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabletAmount
            // 
            this.tabletAmount.BackColor = System.Drawing.Color.AliceBlue;
            this.tabletAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabletAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabletAmount.Location = new System.Drawing.Point(371, 20);
            this.tabletAmount.Name = "tabletAmount";
            this.tabletAmount.Size = new System.Drawing.Size(195, 46);
            this.tabletAmount.TabIndex = 3;
            this.tabletAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // smartphoneAmount
            // 
            this.smartphoneAmount.BackColor = System.Drawing.Color.AliceBlue;
            this.smartphoneAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.smartphoneAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.smartphoneAmount.Location = new System.Drawing.Point(572, 20);
            this.smartphoneAmount.Name = "smartphoneAmount";
            this.smartphoneAmount.Size = new System.Drawing.Size(195, 46);
            this.smartphoneAmount.TabIndex = 4;
            this.smartphoneAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notebookLabel
            // 
            this.notebookLabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.notebookLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notebookLabel.Location = new System.Drawing.Point(170, 75);
            this.notebookLabel.Name = "notebookLabel";
            this.notebookLabel.Size = new System.Drawing.Size(195, 29);
            this.notebookLabel.TabIndex = 5;
            this.notebookLabel.Text = "ноутбуки";
            this.notebookLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabletLabel
            // 
            this.tabletLabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabletLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabletLabel.Location = new System.Drawing.Point(371, 75);
            this.tabletLabel.Name = "tabletLabel";
            this.tabletLabel.Size = new System.Drawing.Size(195, 29);
            this.tabletLabel.TabIndex = 6;
            this.tabletLabel.Text = "планшеты";
            this.tabletLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // smartphoneLabel
            // 
            this.smartphoneLabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.smartphoneLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.smartphoneLabel.Location = new System.Drawing.Point(572, 75);
            this.smartphoneLabel.Name = "smartphoneLabel";
            this.smartphoneLabel.Size = new System.Drawing.Size(195, 29);
            this.smartphoneLabel.TabIndex = 7;
            this.smartphoneLabel.Text = "смартфоны";
            this.smartphoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gadgetPicture
            // 
            this.gadgetPicture.BackColor = System.Drawing.Color.AliceBlue;
            this.gadgetPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gadgetPicture.Location = new System.Drawing.Point(572, 129);
            this.gadgetPicture.Name = "gadgetPicture";
            this.gadgetPicture.Size = new System.Drawing.Size(182, 202);
            this.gadgetPicture.TabIndex = 8;
            this.gadgetPicture.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 75);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(131, 366);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // queueLabel
            // 
            this.queueLabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.queueLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.queueLabel.Location = new System.Drawing.Point(12, 29);
            this.queueLabel.Name = "queueLabel";
            this.queueLabel.Size = new System.Drawing.Size(131, 29);
            this.queueLabel.TabIndex = 10;
            this.queueLabel.Text = "Очередь";
            this.queueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fillButton
            // 
            this.fillButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.fillButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.fillButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fillButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fillButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fillButton.Location = new System.Drawing.Point(170, 404);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(195, 37);
            this.fillButton.TabIndex = 11;
            this.fillButton.Text = "Заполнить";
            this.fillButton.UseVisualStyleBackColor = false;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.showButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.showButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.showButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showButton.Location = new System.Drawing.Point(371, 404);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(195, 37);
            this.showButton.TabIndex = 12;
            this.showButton.Text = "Выдать";
            this.showButton.UseVisualStyleBackColor = false;
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.infoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.infoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.infoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoButton.Location = new System.Drawing.Point(572, 404);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(195, 37);
            this.infoButton.TabIndex = 13;
            this.infoButton.Text = "О программе";
            this.infoButton.UseVisualStyleBackColor = false;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.fillButton);
            this.Controls.Add(this.queueLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.gadgetPicture);
            this.Controls.Add(this.smartphoneLabel);
            this.Controls.Add(this.tabletLabel);
            this.Controls.Add(this.notebookLabel);
            this.Controls.Add(this.smartphoneAmount);
            this.Controls.Add(this.tabletAmount);
            this.Controls.Add(this.notebookAmount);
            this.Controls.Add(this.gadgetInfoField);
            this.KeyPreview = true;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GadgetMachine";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gadgetPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox gadgetInfoField;
        private System.Windows.Forms.Label notebookAmount;
        private System.Windows.Forms.Label tabletAmount;
        private System.Windows.Forms.Label smartphoneAmount;
        private System.Windows.Forms.Label notebookLabel;
        private System.Windows.Forms.Label tabletLabel;
        private System.Windows.Forms.Label smartphoneLabel;
        private System.Windows.Forms.PictureBox gadgetPicture;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label queueLabel;
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button infoButton;
    }
}