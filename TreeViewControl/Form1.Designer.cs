namespace TreeViewControl
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
            this.treeViewDep = new System.Windows.Forms.TreeView();
            this.comBoParents = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDep = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeViewDep
            // 
            this.treeViewDep.Location = new System.Drawing.Point(29, 25);
            this.treeViewDep.Name = "treeViewDep";
            this.treeViewDep.Size = new System.Drawing.Size(352, 401);
            this.treeViewDep.TabIndex = 0;
            // 
            // comBoParents
            // 
            this.comBoParents.FormattingEnabled = true;
            this.comBoParents.Location = new System.Drawing.Point(527, 56);
            this.comBoParents.Name = "comBoParents";
            this.comBoParents.Size = new System.Drawing.Size(132, 24);
            this.comBoParents.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parents:";
            // 
            // tbDep
            // 
            this.tbDep.Location = new System.Drawing.Point(527, 103);
            this.tbDep.Name = "tbDep";
            this.tbDep.Size = new System.Drawing.Size(128, 22);
            this.tbDep.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Abteilung:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(527, 153);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 38);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 449);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comBoParents);
            this.Controls.Add(this.treeViewDep);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewDep;
        private System.Windows.Forms.ComboBox comBoParents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
    }
}

