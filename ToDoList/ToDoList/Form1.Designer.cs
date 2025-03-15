namespace ToDoList
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
            txtTask = new TextBox();
            btnAdd = new Button();
            txtTasks = new ListBox();
            btnEdit = new Button();
            btnDelete = new Button();
            btnMarkComplete = new Button();
            lblTotalTasks = new Label();
            SuspendLayout();
            // 
            // txtTask
            // 
            txtTask.Font = new Font("Segoe UI", 12F);
            txtTask.ForeColor = Color.Black;
            txtTask.Location = new Point(20, 50);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(100, 29);
            txtTask.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.AppWorkspace;
            btnAdd.Font = new Font("Segoe UI", 10F);
            btnAdd.ForeColor = SystemColors.Desktop;
            btnAdd.Location = new Point(350, 50);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 30);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAdd_Click1;
            // 
            // txtTasks
            // 
            txtTasks.BackColor = Color.White;
            txtTasks.Font = new Font("Segoe UI", 12F);
            txtTasks.ForeColor = Color.Black;
            txtTasks.FormattingEnabled = true;
            txtTasks.ItemHeight = 21;
            txtTasks.Location = new Point(20, 90);
            txtTasks.Name = "txtTasks";
            txtTasks.Size = new Size(450, 193);
            txtTasks.TabIndex = 2;
            txtTasks.SelectedIndexChanged += txtTasks_SelectedIndexChanged;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.AppWorkspace;
            btnEdit.Font = new Font("Segoe UI", 10F);
            btnEdit.Location = new Point(20, 300);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(140, 30);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.AppWorkspace;
            btnDelete.Font = new Font("Segoe UI", 10F);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(180, 300);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 30);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnMarkComplete
            // 
            btnMarkComplete.BackColor = SystemColors.AppWorkspace;
            btnMarkComplete.Font = new Font("Segoe UI", 10F);
            btnMarkComplete.ForeColor = SystemColors.ControlText;
            btnMarkComplete.Location = new Point(20, 340);
            btnMarkComplete.Name = "btnMarkComplete";
            btnMarkComplete.Size = new Size(180, 30);
            btnMarkComplete.TabIndex = 5;
            btnMarkComplete.Text = "Complete";
            btnMarkComplete.UseVisualStyleBackColor = false;
            // 
            // lblTotalTasks
            // 
            lblTotalTasks.AutoSize = true;
            lblTotalTasks.Location = new Point(20, 373);
            lblTotalTasks.Name = "lblTotalTasks";
            lblTotalTasks.Size = new Size(64, 15);
            lblTotalTasks.TabIndex = 6;
            lblTotalTasks.Text = "Total tasks:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 411);
            Controls.Add(lblTotalTasks);
            Controls.Add(btnMarkComplete);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(txtTasks);
            Controls.Add(btnAdd);
            Controls.Add(txtTask);
            Name = "Form1";
            Text = "To do list";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTask;
        private Button btnAdd;
        private ListBox txtTasks;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnMarkComplete;
        private Label lblTotalTasks;
    }
}
