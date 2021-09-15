
namespace TWong_Lab1_CPRG006
{
    partial class frmLunchOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLunchOrder));
            this.grpBoxMainCourse = new System.Windows.Forms.GroupBox();
            this.radioBtnSalad = new System.Windows.Forms.RadioButton();
            this.radioBtnPizza = new System.Windows.Forms.RadioButton();
            this.radioBtnHam = new System.Windows.Forms.RadioButton();
            this.grpBoxAddOn = new System.Windows.Forms.GroupBox();
            this.chkBox3 = new System.Windows.Forms.CheckBox();
            this.chkBox2 = new System.Windows.Forms.CheckBox();
            this.chkBox1 = new System.Windows.Forms.CheckBox();
            this.grpBoxOrderTotal = new System.Windows.Forms.GroupBox();
            this.txtBoxOrderTotal = new System.Windows.Forms.TextBox();
            this.txtBoxTax = new System.Windows.Forms.TextBox();
            this.txtBoxSubtotal = new System.Windows.Forms.TextBox();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBoxMainCourse.SuspendLayout();
            this.grpBoxAddOn.SuspendLayout();
            this.grpBoxOrderTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxMainCourse
            // 
            this.grpBoxMainCourse.BackColor = System.Drawing.Color.LightGray;
            this.grpBoxMainCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpBoxMainCourse.Controls.Add(this.radioBtnSalad);
            this.grpBoxMainCourse.Controls.Add(this.radioBtnPizza);
            this.grpBoxMainCourse.Controls.Add(this.radioBtnHam);
            this.grpBoxMainCourse.Location = new System.Drawing.Point(16, 16);
            this.grpBoxMainCourse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxMainCourse.Name = "grpBoxMainCourse";
            this.grpBoxMainCourse.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxMainCourse.Size = new System.Drawing.Size(228, 172);
            this.grpBoxMainCourse.TabIndex = 0;
            this.grpBoxMainCourse.TabStop = false;
            this.grpBoxMainCourse.Text = "Main Course";
            // 
            // radioBtnSalad
            // 
            this.radioBtnSalad.AutoSize = true;
            this.radioBtnSalad.BackColor = System.Drawing.Color.LightGray;
            this.radioBtnSalad.Location = new System.Drawing.Point(18, 123);
            this.radioBtnSalad.Name = "radioBtnSalad";
            this.radioBtnSalad.Size = new System.Drawing.Size(120, 24);
            this.radioBtnSalad.TabIndex = 2;
            this.radioBtnSalad.TabStop = true;
            this.radioBtnSalad.Text = "radioButton3";
            this.radioBtnSalad.UseVisualStyleBackColor = false;
            this.radioBtnSalad.CheckedChanged += new System.EventHandler(this.radioBtnSalad_CheckedChanged);
            // 
            // radioBtnPizza
            // 
            this.radioBtnPizza.AutoSize = true;
            this.radioBtnPizza.BackColor = System.Drawing.Color.LightGray;
            this.radioBtnPizza.Location = new System.Drawing.Point(18, 81);
            this.radioBtnPizza.Name = "radioBtnPizza";
            this.radioBtnPizza.Size = new System.Drawing.Size(120, 24);
            this.radioBtnPizza.TabIndex = 1;
            this.radioBtnPizza.TabStop = true;
            this.radioBtnPizza.Text = "radioButton2";
            this.radioBtnPizza.UseVisualStyleBackColor = false;
            this.radioBtnPizza.CheckedChanged += new System.EventHandler(this.radioBtnPizza_CheckedChanged);
            // 
            // radioBtnHam
            // 
            this.radioBtnHam.AutoSize = true;
            this.radioBtnHam.BackColor = System.Drawing.Color.LightGray;
            this.radioBtnHam.Location = new System.Drawing.Point(18, 36);
            this.radioBtnHam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioBtnHam.Name = "radioBtnHam";
            this.radioBtnHam.Size = new System.Drawing.Size(120, 24);
            this.radioBtnHam.TabIndex = 0;
            this.radioBtnHam.TabStop = true;
            this.radioBtnHam.Text = "radioButton1";
            this.radioBtnHam.UseVisualStyleBackColor = false;
            this.radioBtnHam.CheckedChanged += new System.EventHandler(this.radioBtnHam_CheckedChanged);
            // 
            // grpBoxAddOn
            // 
            this.grpBoxAddOn.BackColor = System.Drawing.Color.LightGray;
            this.grpBoxAddOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grpBoxAddOn.Controls.Add(this.chkBox3);
            this.grpBoxAddOn.Controls.Add(this.chkBox2);
            this.grpBoxAddOn.Controls.Add(this.chkBox1);
            this.grpBoxAddOn.Location = new System.Drawing.Point(16, 210);
            this.grpBoxAddOn.Name = "grpBoxAddOn";
            this.grpBoxAddOn.Size = new System.Drawing.Size(332, 172);
            this.grpBoxAddOn.TabIndex = 1;
            this.grpBoxAddOn.TabStop = false;
            this.grpBoxAddOn.Text = "Add-On Items";
            // 
            // chkBox3
            // 
            this.chkBox3.AutoSize = true;
            this.chkBox3.BackColor = System.Drawing.Color.LightGray;
            this.chkBox3.Location = new System.Drawing.Point(23, 123);
            this.chkBox3.Name = "chkBox3";
            this.chkBox3.Size = new System.Drawing.Size(109, 24);
            this.chkBox3.TabIndex = 2;
            this.chkBox3.Text = "checkBox3";
            this.chkBox3.UseVisualStyleBackColor = false;
            // 
            // chkBox2
            // 
            this.chkBox2.AutoSize = true;
            this.chkBox2.BackColor = System.Drawing.Color.LightGray;
            this.chkBox2.Location = new System.Drawing.Point(23, 81);
            this.chkBox2.Name = "chkBox2";
            this.chkBox2.Size = new System.Drawing.Size(109, 24);
            this.chkBox2.TabIndex = 1;
            this.chkBox2.Text = "checkBox2";
            this.chkBox2.UseVisualStyleBackColor = false;
            // 
            // chkBox1
            // 
            this.chkBox1.AutoSize = true;
            this.chkBox1.BackColor = System.Drawing.Color.LightGray;
            this.chkBox1.Location = new System.Drawing.Point(23, 36);
            this.chkBox1.Name = "chkBox1";
            this.chkBox1.Size = new System.Drawing.Size(109, 24);
            this.chkBox1.TabIndex = 0;
            this.chkBox1.Text = "checkBox1";
            this.chkBox1.UseVisualStyleBackColor = false;
            // 
            // grpBoxOrderTotal
            // 
            this.grpBoxOrderTotal.BackColor = System.Drawing.Color.LightGray;
            this.grpBoxOrderTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grpBoxOrderTotal.Controls.Add(this.txtBoxOrderTotal);
            this.grpBoxOrderTotal.Controls.Add(this.txtBoxTax);
            this.grpBoxOrderTotal.Controls.Add(this.txtBoxSubtotal);
            this.grpBoxOrderTotal.Controls.Add(this.lblOrderTotal);
            this.grpBoxOrderTotal.Controls.Add(this.lblTax);
            this.grpBoxOrderTotal.Controls.Add(this.lblSubtotal);
            this.grpBoxOrderTotal.Location = new System.Drawing.Point(264, 16);
            this.grpBoxOrderTotal.Name = "grpBoxOrderTotal";
            this.grpBoxOrderTotal.Size = new System.Drawing.Size(282, 172);
            this.grpBoxOrderTotal.TabIndex = 2;
            this.grpBoxOrderTotal.TabStop = false;
            this.grpBoxOrderTotal.Text = "Order Total";
            // 
            // txtBoxOrderTotal
            // 
            this.txtBoxOrderTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxOrderTotal.Location = new System.Drawing.Point(116, 123);
            this.txtBoxOrderTotal.Name = "txtBoxOrderTotal";
            this.txtBoxOrderTotal.Size = new System.Drawing.Size(151, 26);
            this.txtBoxOrderTotal.TabIndex = 5;
            // 
            // txtBoxTax
            // 
            this.txtBoxTax.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxTax.Location = new System.Drawing.Point(116, 81);
            this.txtBoxTax.Name = "txtBoxTax";
            this.txtBoxTax.Size = new System.Drawing.Size(151, 26);
            this.txtBoxTax.TabIndex = 4;
            // 
            // txtBoxSubtotal
            // 
            this.txtBoxSubtotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxSubtotal.Location = new System.Drawing.Point(116, 36);
            this.txtBoxSubtotal.Name = "txtBoxSubtotal";
            this.txtBoxSubtotal.Size = new System.Drawing.Size(151, 26);
            this.txtBoxSubtotal.TabIndex = 3;
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.BackColor = System.Drawing.Color.LightGray;
            this.lblOrderTotal.Location = new System.Drawing.Point(17, 123);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(93, 20);
            this.lblOrderTotal.TabIndex = 2;
            this.lblOrderTotal.Text = "Order Total:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.BackColor = System.Drawing.Color.LightGray;
            this.lblTax.Location = new System.Drawing.Point(17, 81);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(69, 20);
            this.lblTax.TabIndex = 1;
            this.lblTax.Text = "Tax (5%):";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.BackColor = System.Drawing.Color.LightGray;
            this.lblSubtotal.Location = new System.Drawing.Point(17, 36);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(72, 20);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlaceOrder.Location = new System.Drawing.Point(396, 220);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(135, 41);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "&Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            this.btnPlaceOrder.MouseLeave += new System.EventHandler(this.btnPlaceOrder_MouseLeave);
            this.btnPlaceOrder.MouseHover += new System.EventHandler(this.btnPlaceOrder_MouseHover);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(396, 284);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 39);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseLeave += new System.EventHandler(this.btnReset_MouseLeave);
            this.btnReset.MouseHover += new System.EventHandler(this.btnReset_MouseHover);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(396, 343);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 39);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLunchOrder
            // 
            this.AcceptButton = this.btnPlaceOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(558, 403);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.grpBoxOrderTotal);
            this.Controls.Add(this.grpBoxAddOn);
            this.Controls.Add(this.grpBoxMainCourse);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLunchOrder";
            this.Text = "Lunch Order";
            this.Load += new System.EventHandler(this.frmLunchOrder_Load);
            this.grpBoxMainCourse.ResumeLayout(false);
            this.grpBoxMainCourse.PerformLayout();
            this.grpBoxAddOn.ResumeLayout(false);
            this.grpBoxAddOn.PerformLayout();
            this.grpBoxOrderTotal.ResumeLayout(false);
            this.grpBoxOrderTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxMainCourse;
        private System.Windows.Forms.RadioButton radioBtnSalad;
        private System.Windows.Forms.RadioButton radioBtnPizza;
        private System.Windows.Forms.RadioButton radioBtnHam;
        private System.Windows.Forms.GroupBox grpBoxAddOn;
        private System.Windows.Forms.CheckBox chkBox3;
        private System.Windows.Forms.CheckBox chkBox2;
        private System.Windows.Forms.CheckBox chkBox1;
        private System.Windows.Forms.GroupBox grpBoxOrderTotal;
        private System.Windows.Forms.TextBox txtBoxOrderTotal;
        private System.Windows.Forms.TextBox txtBoxTax;
        private System.Windows.Forms.TextBox txtBoxSubtotal;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}

