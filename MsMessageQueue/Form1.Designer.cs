namespace MsMessageQueue
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtQueueName = new System.Windows.Forms.TextBox();
            this.btnCreateMQ = new System.Windows.Forms.Button();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.txtBookNO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookAuther = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAcceptMessage = new System.Windows.Forms.Button();
            this.txtMessageList = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSendMessage2 = new System.Windows.Forms.Button();
            this.txtMessageList2 = new System.Windows.Forms.TextBox();
            this.btnAcceptMessage2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "队列名：";
            // 
            // txtQueueName
            // 
            this.txtQueueName.Location = new System.Drawing.Point(80, 18);
            this.txtQueueName.Name = "txtQueueName";
            this.txtQueueName.Size = new System.Drawing.Size(179, 21);
            this.txtQueueName.TabIndex = 1;
            this.txtQueueName.Text = ".\\myQueue";
            // 
            // btnCreateMQ
            // 
            this.btnCreateMQ.Location = new System.Drawing.Point(265, 17);
            this.btnCreateMQ.Name = "btnCreateMQ";
            this.btnCreateMQ.Size = new System.Drawing.Size(75, 23);
            this.btnCreateMQ.TabIndex = 2;
            this.btnCreateMQ.Text = "创建队列";
            this.btnCreateMQ.UseVisualStyleBackColor = true;
            this.btnCreateMQ.Click += new System.EventHandler(this.btnCreateMQ_Click);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(265, 160);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(75, 23);
            this.btnSendMessage.TabIndex = 5;
            this.btnSendMessage.Text = "发送消息";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // txtBookNO
            // 
            this.txtBookNO.Location = new System.Drawing.Point(80, 54);
            this.txtBookNO.Name = "txtBookNO";
            this.txtBookNO.Size = new System.Drawing.Size(179, 21);
            this.txtBookNO.TabIndex = 4;
            this.txtBookNO.Text = "0001";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "图书编号：";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(80, 90);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(179, 21);
            this.txtBookName.TabIndex = 7;
            this.txtBookName.Text = "ASP.NET";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "图书名称：";
            // 
            // txtBookAuther
            // 
            this.txtBookAuther.Location = new System.Drawing.Point(80, 126);
            this.txtBookAuther.Name = "txtBookAuther";
            this.txtBookAuther.Size = new System.Drawing.Size(179, 21);
            this.txtBookAuther.TabIndex = 10;
            this.txtBookAuther.Text = "ZHANGSAN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "图书作者：";
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Location = new System.Drawing.Point(80, 162);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(179, 21);
            this.txtBookPrice.TabIndex = 13;
            this.txtBookPrice.Text = "55.80";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "图书定价：";
            // 
            // btnAcceptMessage
            // 
            this.btnAcceptMessage.Location = new System.Drawing.Point(158, 341);
            this.btnAcceptMessage.Name = "btnAcceptMessage";
            this.btnAcceptMessage.Size = new System.Drawing.Size(75, 23);
            this.btnAcceptMessage.TabIndex = 17;
            this.btnAcceptMessage.Text = "接收消息";
            this.btnAcceptMessage.UseVisualStyleBackColor = true;
            this.btnAcceptMessage.Click += new System.EventHandler(this.btnAcceptMessage_Click);
            // 
            // txtMessageList
            // 
            this.txtMessageList.Location = new System.Drawing.Point(80, 201);
            this.txtMessageList.Multiline = true;
            this.txtMessageList.Name = "txtMessageList";
            this.txtMessageList.Size = new System.Drawing.Size(260, 136);
            this.txtMessageList.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "消息列表：";
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(519, 91);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(179, 21);
            this.txtSex.TabIndex = 22;
            this.txtSex.Text = "F";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(452, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "性别：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(519, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(179, 21);
            this.txtName.TabIndex = 20;
            this.txtName.Text = "ZHAOSHANG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "姓名：";
            // 
            // btnSendMessage2
            // 
            this.btnSendMessage2.Location = new System.Drawing.Point(704, 89);
            this.btnSendMessage2.Name = "btnSendMessage2";
            this.btnSendMessage2.Size = new System.Drawing.Size(75, 23);
            this.btnSendMessage2.TabIndex = 18;
            this.btnSendMessage2.Text = "发送消息";
            this.btnSendMessage2.UseVisualStyleBackColor = true;
            this.btnSendMessage2.Click += new System.EventHandler(this.btnSendMessage2_Click);
            // 
            // txtMessageList2
            // 
            this.txtMessageList2.Location = new System.Drawing.Point(519, 201);
            this.txtMessageList2.Multiline = true;
            this.txtMessageList2.Name = "txtMessageList2";
            this.txtMessageList2.Size = new System.Drawing.Size(260, 136);
            this.txtMessageList2.TabIndex = 23;
            // 
            // btnAcceptMessage2
            // 
            this.btnAcceptMessage2.Location = new System.Drawing.Point(623, 343);
            this.btnAcceptMessage2.Name = "btnAcceptMessage2";
            this.btnAcceptMessage2.Size = new System.Drawing.Size(75, 23);
            this.btnAcceptMessage2.TabIndex = 24;
            this.btnAcceptMessage2.Text = "接收消息";
            this.btnAcceptMessage2.UseVisualStyleBackColor = true;
            this.btnAcceptMessage2.Click += new System.EventHandler(this.btnAcceptMessage2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 376);
            this.Controls.Add(this.btnAcceptMessage2);
            this.Controls.Add(this.txtMessageList2);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSendMessage2);
            this.Controls.Add(this.btnAcceptMessage);
            this.Controls.Add(this.txtMessageList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBookPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBookAuther);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.txtBookNO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreateMQ);
            this.Controls.Add(this.txtQueueName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQueueName;
        private System.Windows.Forms.Button btnCreateMQ;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox txtBookNO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBookAuther;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAcceptMessage;
        private System.Windows.Forms.TextBox txtMessageList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSendMessage2;
        private System.Windows.Forms.TextBox txtMessageList2;
        private System.Windows.Forms.Button btnAcceptMessage2;
    }
}

