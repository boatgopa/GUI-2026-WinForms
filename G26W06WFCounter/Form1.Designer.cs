namespace G26W06WFCounter
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
        private void InitializeComponent() {
            labelCount = new Label();
            btnAdd = new Button();
            btnSub = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // labelCount
            // 
            labelCount.BackColor = SystemColors.Info;
            labelCount.Font = new Font("맑은 고딕", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCount.Location = new Point(257, 66);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(246, 291);
            labelCount.TabIndex = 1;
            labelCount.Text = "0";
            labelCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(257, 376);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(158, 27);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "증가";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += OnAdd;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(257, 409);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(158, 29);
            btnSub.TabIndex = 3;
            btnSub.Text = "감소";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += OnSub;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(421, 376);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(82, 62);
            btnReset.TabIndex = 4;
            btnReset.Text = "초기화";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += OnReset;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(btnSub);
            Controls.Add(btnAdd);
            Controls.Add(labelCount);
            Name = "Form1";
            Text = "Counter";
            ResumeLayout(false);
        }

        #endregion
        private Label labelCount;
        private Button btnAdd;
        private Button btnSub;
        private Button btnReset;
    }
}
