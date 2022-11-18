namespace _3_feladat_Linq
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
            this.components = new System.ComponentModel.Container();
            this.txtCountryFilter = new System.Windows.Forms.TextBox();
            this.listCountries = new System.Windows.Forms.ListBox();
            this.dgwRamen = new System.Windows.Forms.DataGridView();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRamen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCountryFilter
            // 
            this.txtCountryFilter.Location = new System.Drawing.Point(12, 12);
            this.txtCountryFilter.Name = "txtCountryFilter";
            this.txtCountryFilter.Size = new System.Drawing.Size(195, 20);
            this.txtCountryFilter.TabIndex = 0;
            // 
            // listCountries
            // 
            this.listCountries.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.countryBindingSource, "Name", true));
            this.listCountries.FormattingEnabled = true;
            this.listCountries.Location = new System.Drawing.Point(12, 38);
            this.listCountries.Name = "listCountries";
            this.listCountries.Size = new System.Drawing.Size(195, 407);
            this.listCountries.TabIndex = 1;
            // 
            // dgwRamen
            // 
            this.dgwRamen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRamen.Location = new System.Drawing.Point(213, 38);
            this.dgwRamen.Name = "dgwRamen";
            this.dgwRamen.Size = new System.Drawing.Size(575, 407);
            this.dgwRamen.TabIndex = 2;
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataSource = typeof(_3_feladat_Linq.Country);
            // 
            // countryBindingSource1
            // 
            this.countryBindingSource1.DataSource = typeof(_3_feladat_Linq.Country);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwRamen);
            this.Controls.Add(this.listCountries);
            this.Controls.Add(this.txtCountryFilter);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwRamen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCountryFilter;
        private System.Windows.Forms.ListBox listCountries;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private System.Windows.Forms.BindingSource countryBindingSource1;
        private System.Windows.Forms.DataGridView dgwRamen;
    }
}

