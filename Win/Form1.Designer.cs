namespace Win
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.мебельBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asdDataSet = new Win.AsdDataSet();
            this.мебельTableAdapter = new Win.AsdDataSetTableAdapters.МебельTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.мебельBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asdDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.мебельBindingSource;
            this.comboBox1.DisplayMember = "Название";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // мебельBindingSource
            // 
            this.мебельBindingSource.DataMember = "Мебель";
            this.мебельBindingSource.DataSource = this.asdDataSet;
            // 
            // asdDataSet
            // 
            this.asdDataSet.DataSetName = "AsdDataSet";
            this.asdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // мебельTableAdapter
            // 
            this.мебельTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(49, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Выберите модель мебели";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Эскиз мебели";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.мебельBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asdDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private AsdDataSet asdDataSet;
        private System.Windows.Forms.BindingSource мебельBindingSource;
        private AsdDataSetTableAdapters.МебельTableAdapter мебельTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
    }
}