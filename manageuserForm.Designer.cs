namespace ioopassignment
{
    partial class manageuserForm
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
            btnAddUser = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(37, 382);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(153, 41);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "Add";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += button1_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(214, 382);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(153, 41);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(405, 382);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(153, 41);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(589, 382);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(153, 41);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // manageuserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnAddUser);
            Name = "manageuserForm";
            Text = "manageuserForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddUser;
        private Button btnDelete;
        private Button btnSave;
        private Button btnExit;
    }
}