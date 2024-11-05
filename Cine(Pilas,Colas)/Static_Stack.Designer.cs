namespace Cine_Pilas_Colas_
{
    partial class Static_Stack
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
            label1 = new Label();
            LblData = new Label();
            btnSize = new Button();
            btnPeek = new Button();
            btnPop = new Button();
            btnPush = new Button();
            lstStack = new ListBox();
            txtInput = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 33);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 15;
            label1.Text = "dato a ingresar";
            // 
            // LblData
            // 
            LblData.AutoSize = true;
            LblData.Location = new Point(490, 10);
            LblData.Name = "LblData";
            LblData.Size = new Size(235, 15);
            LblData.TabIndex = 14;
            LblData.Text = "Pila estatica con un espacio de 8 elementos";
            // 
            // btnSize
            // 
            btnSize.Location = new Point(148, 369);
            btnSize.Name = "btnSize";
            btnSize.Size = new Size(125, 58);
            btnSize.TabIndex = 13;
            btnSize.Text = "Size";
            btnSize.UseVisualStyleBackColor = true;
            btnSize.Click += btnSize_Click;
            // 
            // btnPeek
            // 
            btnPeek.Location = new Point(148, 273);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(125, 58);
            btnPeek.TabIndex = 12;
            btnPeek.Text = "Peek";
            btnPeek.UseVisualStyleBackColor = true;
            btnPeek.Click += btnPeek_Click;
            // 
            // btnPop
            // 
            btnPop.Location = new Point(148, 189);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(125, 58);
            btnPop.TabIndex = 11;
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = true;
            btnPop.Click += btnPop_Click;
            // 
            // btnPush
            // 
            btnPush.Location = new Point(148, 107);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(125, 58);
            btnPush.TabIndex = 10;
            btnPush.Text = "Push";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += btnPush_Click;
            // 
            // lstStack
            // 
            lstStack.Font = new Font("Berlin Sans FB", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstStack.FormattingEnabled = true;
            lstStack.ItemHeight = 46;
            lstStack.Location = new Point(490, 45);
            lstStack.Name = "lstStack";
            lstStack.Size = new Size(426, 510);
            lstStack.TabIndex = 9;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(118, 30);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(193, 23);
            txtInput.TabIndex = 8;
            // 
            // Static_Stack
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 569);
            Controls.Add(label1);
            Controls.Add(LblData);
            Controls.Add(btnSize);
            Controls.Add(btnPeek);
            Controls.Add(btnPop);
            Controls.Add(btnPush);
            Controls.Add(lstStack);
            Controls.Add(txtInput);
            Name = "Static_Stack";
            Text = "Static_Stack";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LblData;
        private Button btnSize;
        private Button btnPeek;
        private Button btnPop;
        private Button btnPush;
        private ListBox lstStack;
        private TextBox txtInput;
    }
}