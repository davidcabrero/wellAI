﻿using System.Windows.Forms;

namespace wellAI
{
    partial class WellAI
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WellAI));
            this.botonEnviar = new Sunny.UI.UIButton();
            this.textBoxMessage = new Sunny.UI.UITextBox();
            this.flowLayoutPanelChat = new Sunny.UI.UIFlowLayoutPanel();
            this.SuspendLayout();
            // 
            // botonEnviar
            // 
            this.botonEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.botonEnviar.Location = new System.Drawing.Point(899, 602);
            this.botonEnviar.MinimumSize = new System.Drawing.Size(1, 1);
            this.botonEnviar.Name = "botonEnviar";
            this.botonEnviar.Size = new System.Drawing.Size(160, 50);
            this.botonEnviar.TabIndex = 0;
            this.botonEnviar.Text = "Enviar";
            this.botonEnviar.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.botonEnviar.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxMessage.Location = new System.Drawing.Point(13, 602);
            this.textBoxMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMessage.MinimumSize = new System.Drawing.Size(1, 16);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxMessage.ShowText = false;
            this.textBoxMessage.Size = new System.Drawing.Size(879, 50);
            this.textBoxMessage.TabIndex = 1;
            this.textBoxMessage.Text = "Chatea con WellAI";
            this.textBoxMessage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBoxMessage.Watermark = "";
            this.textBoxMessage.KeyDown += new KeyEventHandler(this.textBoxMessage_KeyDown);
            // 
            // flowLayoutPanelChat
            // 
            this.flowLayoutPanelChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.flowLayoutPanelChat.Location = new System.Drawing.Point(13, 14);
            this.flowLayoutPanelChat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanelChat.MinimumSize = new System.Drawing.Size(1, 1);
            this.flowLayoutPanelChat.Name = "flowLayoutPanelChat";
            this.flowLayoutPanelChat.Padding = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelChat.ShowText = false;
            this.flowLayoutPanelChat.Size = new System.Drawing.Size(1046, 578);
            this.flowLayoutPanelChat.TabIndex = 0;
            this.flowLayoutPanelChat.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WellAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 666);
            this.Controls.Add(this.flowLayoutPanelChat);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.botonEnviar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WellAI";
            this.Text = "WellAI";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton botonEnviar;
        private Sunny.UI.UITextBox textBoxMessage;
        private Sunny.UI.UIFlowLayoutPanel flowLayoutPanelChat;
    }
}

