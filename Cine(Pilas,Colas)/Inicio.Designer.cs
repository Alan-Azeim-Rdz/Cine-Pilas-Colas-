namespace Cine_Pilas_Colas_
{
    partial class Inicio
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
            BtnGoDinamicQueue = new Button();
            BtnGoEstaticQueue = new Button();
            BtnGoDinamicStack = new Button();
            BtnGoEstaticStack = new Button();
            BtnGoDinamicQueueDouble = new Button();
            BtnGoEstaticQueueDouble = new Button();
            SuspendLayout();
            // 
            // BtnGoDinamicQueue
            // 
            BtnGoDinamicQueue.Location = new Point(95, 102);
            BtnGoDinamicQueue.Name = "BtnGoDinamicQueue";
            BtnGoDinamicQueue.Size = new Size(206, 87);
            BtnGoDinamicQueue.TabIndex = 0;
            BtnGoDinamicQueue.Text = "Queue Dinamica";
            BtnGoDinamicQueue.UseVisualStyleBackColor = true;
            BtnGoDinamicQueue.Click += BtnGoDinamicQueue_Click;
            // 
            // BtnGoEstaticQueue
            // 
            BtnGoEstaticQueue.Location = new Point(418, 102);
            BtnGoEstaticQueue.Name = "BtnGoEstaticQueue";
            BtnGoEstaticQueue.Size = new Size(206, 87);
            BtnGoEstaticQueue.TabIndex = 1;
            BtnGoEstaticQueue.Text = "Queue Estatica";
            BtnGoEstaticQueue.UseVisualStyleBackColor = true;
            BtnGoEstaticQueue.Click += BtnGoEstaticQueue_Click;
            // 
            // BtnGoDinamicStack
            // 
            BtnGoDinamicStack.Location = new Point(95, 305);
            BtnGoDinamicStack.Name = "BtnGoDinamicStack";
            BtnGoDinamicStack.Size = new Size(206, 87);
            BtnGoDinamicStack.TabIndex = 2;
            BtnGoDinamicStack.Text = "Stack Dinamica";
            BtnGoDinamicStack.UseVisualStyleBackColor = true;
            BtnGoDinamicStack.Click += BtnGoDinamicStack_Click;
            // 
            // BtnGoEstaticStack
            // 
            BtnGoEstaticStack.Location = new Point(418, 305);
            BtnGoEstaticStack.Name = "BtnGoEstaticStack";
            BtnGoEstaticStack.Size = new Size(206, 87);
            BtnGoEstaticStack.TabIndex = 3;
            BtnGoEstaticStack.Text = "Stack Estatica";
            BtnGoEstaticStack.UseVisualStyleBackColor = true;
            BtnGoEstaticStack.Click += BtnGoEstaticStack_Click;
            // 
            // BtnGoDinamicQueueDouble
            // 
            BtnGoDinamicQueueDouble.Location = new Point(729, 102);
            BtnGoDinamicQueueDouble.Name = "BtnGoDinamicQueueDouble";
            BtnGoDinamicQueueDouble.Size = new Size(206, 87);
            BtnGoDinamicQueueDouble.TabIndex = 1;
            BtnGoDinamicQueueDouble.Text = "Queue Doble Dinamica";
            BtnGoDinamicQueueDouble.UseVisualStyleBackColor = true;
            BtnGoDinamicQueueDouble.Click += BtnGoDinamicQueueDouble_Click;
            // 
            // BtnGoEstaticQueueDouble
            // 
            BtnGoEstaticQueueDouble.Location = new Point(729, 305);
            BtnGoEstaticQueueDouble.Name = "BtnGoEstaticQueueDouble";
            BtnGoEstaticQueueDouble.Size = new Size(206, 87);
            BtnGoEstaticQueueDouble.TabIndex = 3;
            BtnGoEstaticQueueDouble.Text = "Queue Doble Estatica";
            BtnGoEstaticQueueDouble.UseVisualStyleBackColor = true;
            BtnGoEstaticQueueDouble.Click += BtnGoEstaticQueueDouble_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 501);
            Controls.Add(BtnGoEstaticQueueDouble);
            Controls.Add(BtnGoEstaticStack);
            Controls.Add(BtnGoDinamicQueueDouble);
            Controls.Add(BtnGoDinamicStack);
            Controls.Add(BtnGoEstaticQueue);
            Controls.Add(BtnGoDinamicQueue);
            Name = "Inicio";
            Text = "Inicio";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnGoDinamicQueue;
        private Button BtnGoEstaticQueue;
        private Button BtnGoDinamicStack;
        private Button BtnGoEstaticStack;
        private Button BtnGoDinamicQueueDouble;
        private Button BtnGoEstaticQueueDouble;
    }
}