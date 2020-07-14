namespace SportskiRezultati
{
    partial class AddGoalscorer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPlayer = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbGoal = new System.Windows.Forms.TextBox();
            this.btnAddGoalscorerToList = new System.Windows.Forms.Button();
            this.btnCancelAddGoalScorer = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Points/Minute";
            // 
            // tbPlayer
            // 
            this.tbPlayer.Location = new System.Drawing.Point(85, 28);
            this.tbPlayer.Name = "tbPlayer";
            this.tbPlayer.Size = new System.Drawing.Size(100, 20);
            this.tbPlayer.TabIndex = 2;
            this.tbPlayer.Validating += new System.ComponentModel.CancelEventHandler(this.tbPlayer_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelAddGoalScorer);
            this.groupBox1.Controls.Add(this.btnAddGoalscorerToList);
            this.groupBox1.Controls.Add(this.tbGoal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbPlayer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 226);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // tbGoal
            // 
            this.tbGoal.Location = new System.Drawing.Point(85, 113);
            this.tbGoal.Name = "tbGoal";
            this.tbGoal.Size = new System.Drawing.Size(100, 20);
            this.tbGoal.TabIndex = 3;
            this.tbGoal.Validating += new System.ComponentModel.CancelEventHandler(this.tbGoal_Validating);
            // 
            // btnAddGoalscorerToList
            // 
            this.btnAddGoalscorerToList.Location = new System.Drawing.Point(9, 183);
            this.btnAddGoalscorerToList.Name = "btnAddGoalscorerToList";
            this.btnAddGoalscorerToList.Size = new System.Drawing.Size(75, 23);
            this.btnAddGoalscorerToList.TabIndex = 4;
            this.btnAddGoalscorerToList.Text = "Add";
            this.btnAddGoalscorerToList.UseVisualStyleBackColor = true;
            this.btnAddGoalscorerToList.Click += new System.EventHandler(this.btnAddGoalscorerToList_Click);
            // 
            // btnCancelAddGoalScorer
            // 
            this.btnCancelAddGoalScorer.Location = new System.Drawing.Point(110, 183);
            this.btnCancelAddGoalScorer.Name = "btnCancelAddGoalScorer";
            this.btnCancelAddGoalScorer.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAddGoalScorer.TabIndex = 5;
            this.btnCancelAddGoalScorer.Text = "Cancel";
            this.btnCancelAddGoalScorer.UseVisualStyleBackColor = true;
            this.btnCancelAddGoalScorer.Click += new System.EventHandler(this.btnCancelAddGoalScorer_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddGoalscorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 250);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddGoalscorer";
            this.Text = "AddGoalscorer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPlayer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelAddGoalScorer;
        private System.Windows.Forms.Button btnAddGoalscorerToList;
        private System.Windows.Forms.TextBox tbGoal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}