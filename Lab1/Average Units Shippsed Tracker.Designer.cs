
namespace Lab1
{
    partial class Form1
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
            this.labelUnits = new System.Windows.Forms.Label();
            this.textboxShippedQuantityEntry = new System.Windows.Forms.TextBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.textboxRunningTotal = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelAverageShipped = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUnits
            // 
            this.labelUnits.AutoSize = true;
            this.labelUnits.Location = new System.Drawing.Point(58, 40);
            this.labelUnits.Name = "labelUnits";
            this.labelUnits.Size = new System.Drawing.Size(37, 15);
            this.labelUnits.TabIndex = 0;
            this.labelUnits.Text = "Units:";
            // 
            // textboxShippedQuantityEntry
            // 
            this.textboxShippedQuantityEntry.Location = new System.Drawing.Point(119, 36);
            this.textboxShippedQuantityEntry.Name = "textboxShippedQuantityEntry";
            this.textboxShippedQuantityEntry.Size = new System.Drawing.Size(109, 23);
            this.textboxShippedQuantityEntry.TabIndex = 1;
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(262, 40);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(30, 15);
            this.labelDay.TabIndex = 2;
            this.labelDay.Text = "Day ";
            // 
            // textboxRunningTotal
            // 
            this.textboxRunningTotal.Location = new System.Drawing.Point(58, 77);
            this.textboxRunningTotal.Multiline = true;
            this.textboxRunningTotal.Name = "textboxRunningTotal";
            this.textboxRunningTotal.ReadOnly = true;
            this.textboxRunningTotal.Size = new System.Drawing.Size(234, 155);
            this.textboxRunningTotal.TabIndex = 3;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(8, 289);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(110, 32);
            this.buttonEnter.TabIndex = 4;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.ButtonEnterClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(124, 289);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(110, 32);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonResetClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(240, 289);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(110, 32);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // labelAverageShipped
            // 
            this.labelAverageShipped.AutoSize = true;
            this.labelAverageShipped.Location = new System.Drawing.Point(119, 235);
            this.labelAverageShipped.Name = "labelAverageShipped";
            this.labelAverageShipped.Size = new System.Drawing.Size(0, 15);
            this.labelAverageShipped.TabIndex = 7;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 333);
            this.Controls.Add(this.labelAverageShipped);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textboxRunningTotal);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.textboxShippedQuantityEntry);
            this.Controls.Add(this.labelUnits);
            this.Name = "Form1";
            this.Text = "Average Units Shipped";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUnits;
        private System.Windows.Forms.TextBox textboxShippedQuantityEntry;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.TextBox textboxRunningTotal;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelAverageShipped;
    }
}

