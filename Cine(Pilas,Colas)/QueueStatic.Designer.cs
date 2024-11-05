namespace Cine_Pilas_Colas_
{
    partial class QueueStatic
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
            label7 = new Label();
            BtnSizeIn = new Button();
            label6 = new Label();
            label5 = new Label();
            LisboxPriority = new ListBox();
            LisBxDataNumber = new ListBox();
            TxtNumberAdd = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BtnSizeP = new Button();
            BtnPeek = new Button();
            BtnDequeue = new Button();
            BtnEnqueue = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 262);
            label7.Name = "label7";
            label7.Size = new Size(172, 15);
            label7.TabIndex = 29;
            label7.Text = "verificar espacio numeros inpar";
            // 
            // BtnSizeIn
            // 
            BtnSizeIn.Location = new Point(223, 254);
            BtnSizeIn.Name = "BtnSizeIn";
            BtnSizeIn.Size = new Size(75, 23);
            BtnSizeIn.TabIndex = 28;
            BtnSizeIn.Text = "size";
            BtnSizeIn.UseVisualStyleBackColor = true;
            BtnSizeIn.Click += BtnSizeIn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(692, 8);
            label6.Name = "label6";
            label6.Size = new Size(109, 15);
            label6.TabIndex = 27;
            label6.Text = "Prioridad 2 impares";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(474, 8);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 26;
            label5.Text = "Prioridad 1 pares";
            // 
            // LisboxPriority
            // 
            LisboxPriority.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LisboxPriority.FormattingEnabled = true;
            LisboxPriority.ItemHeight = 45;
            LisboxPriority.Location = new Point(453, 30);
            LisboxPriority.Name = "LisboxPriority";
            LisboxPriority.Size = new Size(135, 409);
            LisboxPriority.TabIndex = 25;
            // 
            // LisBxDataNumber
            // 
            LisBxDataNumber.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LisBxDataNumber.FormattingEnabled = true;
            LisBxDataNumber.ItemHeight = 45;
            LisBxDataNumber.Location = new Point(675, 26);
            LisBxDataNumber.Name = "LisBxDataNumber";
            LisBxDataNumber.Size = new Size(135, 409);
            LisBxDataNumber.TabIndex = 24;
            // 
            // TxtNumberAdd
            // 
            TxtNumberAdd.Location = new Point(327, 44);
            TxtNumberAdd.Name = "TxtNumberAdd";
            TxtNumberAdd.Size = new Size(100, 23);
            TxtNumberAdd.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 205);
            label4.Name = "label4";
            label4.Size = new Size(162, 15);
            label4.TabIndex = 22;
            label4.Text = "verificar espacio numeros par";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 151);
            label3.Name = "label3";
            label3.Size = new Size(144, 15);
            label3.TabIndex = 21;
            label3.Text = "mostrar dato mas antiguo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 97);
            label2.Name = "label2";
            label2.Size = new Size(177, 15);
            label2.TabIndex = 20;
            label2.Text = "Quitar datos (Dato mas antiguo)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 48);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 19;
            label1.Text = "Agrega un numero";
            // 
            // BtnSizeP
            // 
            BtnSizeP.Location = new Point(223, 205);
            BtnSizeP.Name = "BtnSizeP";
            BtnSizeP.Size = new Size(75, 23);
            BtnSizeP.TabIndex = 18;
            BtnSizeP.Text = "size";
            BtnSizeP.UseVisualStyleBackColor = true;
            BtnSizeP.Click += BtnSizeP_Click;
            // 
            // BtnPeek
            // 
            BtnPeek.Location = new Point(223, 151);
            BtnPeek.Name = "BtnPeek";
            BtnPeek.Size = new Size(75, 23);
            BtnPeek.TabIndex = 17;
            BtnPeek.Text = "Mostrar";
            BtnPeek.UseVisualStyleBackColor = true;
            BtnPeek.Click += BtnPeek_Click;
            // 
            // BtnDequeue
            // 
            BtnDequeue.Location = new Point(223, 97);
            BtnDequeue.Name = "BtnDequeue";
            BtnDequeue.Size = new Size(75, 23);
            BtnDequeue.TabIndex = 16;
            BtnDequeue.Text = "Remove";
            BtnDequeue.UseVisualStyleBackColor = true;
            BtnDequeue.Click += BtnDequeue_Click;
            // 
            // BtnEnqueue
            // 
            BtnEnqueue.Location = new Point(223, 44);
            BtnEnqueue.Name = "BtnEnqueue";
            BtnEnqueue.Size = new Size(75, 23);
            BtnEnqueue.TabIndex = 15;
            BtnEnqueue.Text = "Add";
            BtnEnqueue.UseVisualStyleBackColor = true;
            BtnEnqueue.Click += BtnEnqueue_Click;
            // 
            // QueueStatic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 496);
            Controls.Add(label7);
            Controls.Add(BtnSizeIn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(LisboxPriority);
            Controls.Add(LisBxDataNumber);
            Controls.Add(TxtNumberAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnSizeP);
            Controls.Add(BtnPeek);
            Controls.Add(BtnDequeue);
            Controls.Add(BtnEnqueue);
            Name = "QueueStatic";
            Text = "QueueStatic";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Button BtnSizeIn;
        private Label label6;
        private Label label5;
        private ListBox LisboxPriority;
        private ListBox LisBxDataNumber;
        private TextBox TxtNumberAdd;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BtnSizeP;
        private Button BtnPeek;
        private Button BtnDequeue;
        private Button BtnEnqueue;
    }
}