namespace ComputerShop
{
    partial class Shop
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
            this.selectedAddons = new System.Windows.Forms.ListBox();
            this.laptopButton = new System.Windows.Forms.RadioButton();
            this.TablePCButton = new System.Windows.Forms.RadioButton();
            this.availableAddons = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectedAddons
            // 
            this.selectedAddons.FormattingEnabled = true;
            this.selectedAddons.Location = new System.Drawing.Point(143, 68);
            this.selectedAddons.Name = "selectedAddons";
            this.selectedAddons.Size = new System.Drawing.Size(144, 121);
            this.selectedAddons.TabIndex = 0;
            this.selectedAddons.SelectedIndexChanged += new System.EventHandler(this.selectedAddons_SelectedIndexChanged);
            // 
            // laptopButton
            // 
            this.laptopButton.AutoSize = true;
            this.laptopButton.Location = new System.Drawing.Point(39, 68);
            this.laptopButton.Name = "laptopButton";
            this.laptopButton.Size = new System.Drawing.Size(58, 17);
            this.laptopButton.TabIndex = 1;
            this.laptopButton.TabStop = true;
            this.laptopButton.Text = "Laptop";
            this.laptopButton.UseVisualStyleBackColor = true;
            // 
            // TablePCButton
            // 
            this.TablePCButton.AutoSize = true;
            this.TablePCButton.Location = new System.Drawing.Point(39, 91);
            this.TablePCButton.Name = "TablePCButton";
            this.TablePCButton.Size = new System.Drawing.Size(69, 17);
            this.TablePCButton.TabIndex = 2;
            this.TablePCButton.TabStop = true;
            this.TablePCButton.Text = "Table PC";
            this.TablePCButton.UseVisualStyleBackColor = true;
            // 
            // availableAddons
            // 
            this.availableAddons.FormattingEnabled = true;
            this.availableAddons.Location = new System.Drawing.Point(321, 68);
            this.availableAddons.Name = "availableAddons";
            this.availableAddons.Size = new System.Drawing.Size(148, 121);
            this.availableAddons.TabIndex = 3;
            this.availableAddons.SelectedIndexChanged += new System.EventHandler(this.availableAddons_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(321, 211);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(39, 211);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 5;
            this.btnBuy.Text = "Buy Product";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selected Add-ons";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Add-ons available";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Selected Add-ons";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(143, 211);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 316);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.availableAddons);
            this.Controls.Add(this.TablePCButton);
            this.Controls.Add(this.laptopButton);
            this.Controls.Add(this.selectedAddons);
            this.Name = "Shop";
            this.Text = "Computer Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox selectedAddons;
        private System.Windows.Forms.RadioButton laptopButton;
        private System.Windows.Forms.RadioButton TablePCButton;
        private System.Windows.Forms.ListBox availableAddons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemove;
    }
}

