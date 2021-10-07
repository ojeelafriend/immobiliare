
namespace immobiliare
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.windowBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.localCheckBox = new System.Windows.Forms.CheckBox();
            this.flatBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.flatCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.directionBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.surfaceBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.oldBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSendFinalData = new System.Windows.Forms.Button();
            this.labelFinalPrice = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.windowBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.localCheckBox);
            this.groupBox1.Controls.Add(this.flatBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.flatCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Inmueble";
            // 
            // windowBox
            // 
            this.windowBox.Location = new System.Drawing.Point(165, 86);
            this.windowBox.Name = "windowBox";
            this.windowBox.Size = new System.Drawing.Size(23, 21);
            this.windowBox.TabIndex = 5;
            this.windowBox.TextChanged += new System.EventHandler(this.windowBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nro de ventanas";
            // 
            // localCheckBox
            // 
            this.localCheckBox.AutoSize = true;
            this.localCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.localCheckBox.Location = new System.Drawing.Point(146, 34);
            this.localCheckBox.Name = "localCheckBox";
            this.localCheckBox.Size = new System.Drawing.Size(62, 20);
            this.localCheckBox.TabIndex = 3;
            this.localCheckBox.Text = "Local";
            this.localCheckBox.UseVisualStyleBackColor = true;
            this.localCheckBox.CheckedChanged += new System.EventHandler(this.localCheckBox_CheckedChanged);
            // 
            // flatBox
            // 
            this.flatBox.Location = new System.Drawing.Point(50, 86);
            this.flatBox.Name = "flatBox";
            this.flatBox.Size = new System.Drawing.Size(23, 21);
            this.flatBox.TabIndex = 2;
            this.flatBox.TextChanged += new System.EventHandler(this.flatBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Piso Nro";
            // 
            // flatCheckBox
            // 
            this.flatCheckBox.AutoSize = true;
            this.flatCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.flatCheckBox.Location = new System.Drawing.Point(35, 34);
            this.flatCheckBox.Name = "flatCheckBox";
            this.flatCheckBox.Size = new System.Drawing.Size(56, 20);
            this.flatCheckBox.TabIndex = 0;
            this.flatCheckBox.Text = "Piso";
            this.flatCheckBox.UseVisualStyleBackColor = true;
            this.flatCheckBox.CheckedChanged += new System.EventHandler(this.flatCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dirección";
            // 
            // directionBox
            // 
            this.directionBox.Location = new System.Drawing.Point(16, 167);
            this.directionBox.Name = "directionBox";
            this.directionBox.Size = new System.Drawing.Size(261, 20);
            this.directionBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Superficie";
            // 
            // surfaceBox
            // 
            this.surfaceBox.Location = new System.Drawing.Point(16, 222);
            this.surfaceBox.Name = "surfaceBox";
            this.surfaceBox.Size = new System.Drawing.Size(62, 20);
            this.surfaceBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "(m2)";
            // 
            // oldBox
            // 
            this.oldBox.Location = new System.Drawing.Point(121, 222);
            this.oldBox.Name = "oldBox";
            this.oldBox.Size = new System.Drawing.Size(19, 20);
            this.oldBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Antiguedad";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(208, 222);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(69, 20);
            this.priceBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(205, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio base";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(146, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "(años)";
            // 
            // btnSendFinalData
            // 
            this.btnSendFinalData.Location = new System.Drawing.Point(16, 260);
            this.btnSendFinalData.Name = "btnSendFinalData";
            this.btnSendFinalData.Size = new System.Drawing.Size(261, 54);
            this.btnSendFinalData.TabIndex = 11;
            this.btnSendFinalData.Text = "Calcular Precio Final";
            this.btnSendFinalData.UseVisualStyleBackColor = true;
            this.btnSendFinalData.Click += new System.EventHandler(this.btnSendFinalData_Click);
            // 
            // labelFinalPrice
            // 
            this.labelFinalPrice.AutoSize = true;
            this.labelFinalPrice.Location = new System.Drawing.Point(16, 321);
            this.labelFinalPrice.Name = "labelFinalPrice";
            this.labelFinalPrice.Size = new System.Drawing.Size(0, 13);
            this.labelFinalPrice.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 344);
            this.Controls.Add(this.labelFinalPrice);
            this.Controls.Add(this.btnSendFinalData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.oldBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surfaceBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.directionBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Immobiliare";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox directionBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox surfaceBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oldBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSendFinalData;
        private System.Windows.Forms.Label labelFinalPrice;
        private System.Windows.Forms.TextBox windowBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox localCheckBox;
        private System.Windows.Forms.TextBox flatBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox flatCheckBox;
    }
}

