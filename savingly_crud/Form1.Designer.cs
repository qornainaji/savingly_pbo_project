namespace savingly_crud
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
            this.text_spending = new System.Windows.Forms.Label();
            this.textbox_spending = new System.Windows.Forms.TextBox();
            this.textbox_items = new System.Windows.Forms.TextBox();
            this.text_items = new System.Windows.Forms.Label();
            this.button_insert = new System.Windows.Forms.Button();
            this.text_date = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.date_picker = new System.Windows.Forms.DateTimePicker();
            this.textbox_items_updel = new System.Windows.Forms.TextBox();
            this.text_items_updel = new System.Windows.Forms.Label();
            this.textbox_spending_updel = new System.Windows.Forms.TextBox();
            this.text_spending_updel = new System.Windows.Forms.Label();
            this.textbox_ID_updel = new System.Windows.Forms.TextBox();
            this.text_ID = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.savingly_DBDataSet = new savingly_crud.Savingly_DBDataSet();
            this.table = new System.Windows.Forms.DataGridView();
            this.savinglyDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.savingly_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.savinglyDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // text_spending
            // 
            this.text_spending.AutoSize = true;
            this.text_spending.Location = new System.Drawing.Point(9, 28);
            this.text_spending.Name = "text_spending";
            this.text_spending.Size = new System.Drawing.Size(145, 13);
            this.text_spending.TabIndex = 1;
            this.text_spending.Text = "How much you spend today?";
            // 
            // textbox_spending
            // 
            this.textbox_spending.Location = new System.Drawing.Point(12, 44);
            this.textbox_spending.Name = "textbox_spending";
            this.textbox_spending.Size = new System.Drawing.Size(188, 20);
            this.textbox_spending.TabIndex = 2;
            this.textbox_spending.TextChanged += new System.EventHandler(this.textbox_spending_TextChanged);
            // 
            // textbox_items
            // 
            this.textbox_items.Location = new System.Drawing.Point(9, 100);
            this.textbox_items.Name = "textbox_items";
            this.textbox_items.Size = new System.Drawing.Size(191, 20);
            this.textbox_items.TabIndex = 4;
            // 
            // text_items
            // 
            this.text_items.AutoSize = true;
            this.text_items.Location = new System.Drawing.Point(6, 84);
            this.text_items.Name = "text_items";
            this.text_items.Size = new System.Drawing.Size(194, 13);
            this.text_items.TabIndex = 3;
            this.text_items.Text = "What are the things that you’ve spend?";
            // 
            // button_insert
            // 
            this.button_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_insert.Location = new System.Drawing.Point(121, 198);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(75, 23);
            this.button_insert.TabIndex = 5;
            this.button_insert.Text = "insert";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // text_date
            // 
            this.text_date.AutoSize = true;
            this.text_date.Location = new System.Drawing.Point(7, 136);
            this.text_date.Name = "text_date";
            this.text_date.Size = new System.Drawing.Size(136, 13);
            this.text_date.TabIndex = 6;
            this.text_date.Text = "When do/did you spend it?";
            this.text_date.Click += new System.EventHandler(this.text_date_Click);
            // 
            // button_update
            // 
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Location = new System.Drawing.Point(600, 198);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 8;
            this.button_update.Text = "update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // date_picker
            // 
            this.date_picker.Location = new System.Drawing.Point(9, 156);
            this.date_picker.MaxDate = new System.DateTime(2022, 12, 18, 0, 0, 0, 0);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(187, 20);
            this.date_picker.TabIndex = 9;
            this.date_picker.Value = new System.DateTime(2022, 12, 18, 0, 0, 0, 0);
            this.date_picker.ValueChanged += new System.EventHandler(this.date_picker_ValueChanged);
            // 
            // textbox_items_updel
            // 
            this.textbox_items_updel.Location = new System.Drawing.Point(597, 156);
            this.textbox_items_updel.Name = "textbox_items_updel";
            this.textbox_items_updel.Size = new System.Drawing.Size(191, 20);
            this.textbox_items_updel.TabIndex = 13;
            // 
            // text_items_updel
            // 
            this.text_items_updel.AutoSize = true;
            this.text_items_updel.Location = new System.Drawing.Point(594, 140);
            this.text_items_updel.Name = "text_items_updel";
            this.text_items_updel.Size = new System.Drawing.Size(194, 13);
            this.text_items_updel.TabIndex = 12;
            this.text_items_updel.Text = "What are the things that you’ve spend?";
            // 
            // textbox_spending_updel
            // 
            this.textbox_spending_updel.Location = new System.Drawing.Point(597, 100);
            this.textbox_spending_updel.Name = "textbox_spending_updel";
            this.textbox_spending_updel.Size = new System.Drawing.Size(188, 20);
            this.textbox_spending_updel.TabIndex = 11;
            // 
            // text_spending_updel
            // 
            this.text_spending_updel.AutoSize = true;
            this.text_spending_updel.Location = new System.Drawing.Point(594, 84);
            this.text_spending_updel.Name = "text_spending_updel";
            this.text_spending_updel.Size = new System.Drawing.Size(172, 13);
            this.text_spending_updel.TabIndex = 10;
            this.text_spending_updel.Text = "How much you spend on that day?";
            // 
            // textbox_ID_updel
            // 
            this.textbox_ID_updel.Location = new System.Drawing.Point(597, 44);
            this.textbox_ID_updel.Name = "textbox_ID_updel";
            this.textbox_ID_updel.Size = new System.Drawing.Size(188, 20);
            this.textbox_ID_updel.TabIndex = 15;
            // 
            // text_ID
            // 
            this.text_ID.AutoSize = true;
            this.text_ID.Location = new System.Drawing.Point(594, 28);
            this.text_ID.Name = "text_ID";
            this.text_ID.Size = new System.Drawing.Size(177, 13);
            this.text_ID.TabIndex = 14;
            this.text_ID.Text = "What ID do you want to edit/erase?";
            // 
            // button_delete
            // 
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Location = new System.Drawing.Point(713, 198);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 16;
            this.button_delete.Text = "delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // savingly_DBDataSet
            // 
            this.savingly_DBDataSet.DataSetName = "Savingly_DBDataSet";
            this.savingly_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(447, 288);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(341, 170);
            this.table.TabIndex = 17;
            // 
            // savinglyDBDataSetBindingSource
            // 
            this.savinglyDBDataSetBindingSource.DataSource = this.savingly_DBDataSet;
            this.savinglyDBDataSetBindingSource.Position = 0;
            // 
            // button_refresh
            // 
            this.button_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.Location = new System.Drawing.Point(738, 249);
            this.button_refresh.Margin = new System.Windows.Forms.Padding(0);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(53, 32);
            this.button_refresh.TabIndex = 19;
            this.button_refresh.Text = "🔃";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.table);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.textbox_ID_updel);
            this.Controls.Add(this.text_ID);
            this.Controls.Add(this.textbox_items_updel);
            this.Controls.Add(this.text_items_updel);
            this.Controls.Add(this.textbox_spending_updel);
            this.Controls.Add(this.text_spending_updel);
            this.Controls.Add(this.date_picker);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.text_date);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.textbox_items);
            this.Controls.Add(this.text_items);
            this.Controls.Add(this.textbox_spending);
            this.Controls.Add(this.text_spending);
            this.Name = "Form1";
            this.Text = "Saving.ly";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.savingly_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.savinglyDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label text_spending;
        private System.Windows.Forms.TextBox textbox_spending;
        private System.Windows.Forms.TextBox textbox_items;
        private System.Windows.Forms.Label text_items;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Label text_date;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.DateTimePicker date_picker;
        private System.Windows.Forms.TextBox textbox_items_updel;
        private System.Windows.Forms.Label text_items_updel;
        private System.Windows.Forms.TextBox textbox_spending_updel;
        private System.Windows.Forms.Label text_spending_updel;
        private System.Windows.Forms.TextBox textbox_ID_updel;
        private System.Windows.Forms.Label text_ID;
        private System.Windows.Forms.Button button_delete;
        private Savingly_DBDataSet savingly_DBDataSet;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.BindingSource savinglyDBDataSetBindingSource;
        private System.Windows.Forms.Button button_refresh;
    }
}

