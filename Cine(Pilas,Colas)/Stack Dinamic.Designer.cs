namespace Cine_Pilas_Colas_
{
    partial class Stack_Dinamic
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
            BtnSize = new Button();
            label1 = new Label();
            lstPila = new ListBox();
            btnPeek = new Button();
            btnPop = new Button();
            txtData = new TextBox();
            btnPush = new Button();
            SuspendLayout();
            // 
            // BtnSize
            // 
            BtnSize.Location = new Point(112, 421);
            BtnSize.Name = "BtnSize";
            BtnSize.Size = new Size(126, 53);
            BtnSize.TabIndex = 13;
            BtnSize.Text = "Size";
            BtnSize.UseVisualStyleBackColor = true;
            BtnSize.Click += BtnSize_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 116);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 12;
            label1.Text = "Dato a insertar:";
            // 
            // lstPila
            // 
            lstPila.Font = new Font("Tahoma", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstPila.FormattingEnabled = true;
            lstPila.ItemHeight = 42;
            lstPila.Location = new Point(494, 78);
            lstPila.Name = "lstPila";
            lstPila.Size = new Size(453, 424);
            lstPila.TabIndex = 11;
            // 
            // btnPeek
            // 
            btnPeek.Location = new Point(112, 342);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(126, 53);
            btnPeek.TabIndex = 10;
            btnPeek.Text = "Peek";
            btnPeek.UseVisualStyleBackColor = true;
            btnPeek.Click += btnPeek_Click;
            // 
            // btnPop
            // 
            btnPop.Location = new Point(112, 262);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(126, 53);
            btnPop.TabIndex = 9;
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = true;
            btnPop.Click += btnPop_Click;
            // 
            // txtData
            // 
            txtData.Location = new Point(154, 108);
            txtData.Name = "txtData";
            txtData.Size = new Size(156, 23);
            txtData.TabIndex = 8;
            // 
            // btnPush
            // 
            btnPush.Location = new Point(112, 185);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(126, 53);
            btnPush.TabIndex = 7;
            btnPush.Text = "Push";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += btnPush_Click;
            // 
            // Stack_Dinamic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 581);
            Controls.Add(BtnSize);
            Controls.Add(label1);
            Controls.Add(lstPila);
            Controls.Add(btnPeek);
            Controls.Add(btnPop);
            Controls.Add(txtData);
            Controls.Add(btnPush);
            Name = "Stack_Dinamic";
            Text = "Stack_Dinamic";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSize;
        private Label label1;
        private ListBox lstPila;
        private Button btnPeek;
        private Button btnPop;
        private TextBox txtData;
        private Button btnPush;
    }
}