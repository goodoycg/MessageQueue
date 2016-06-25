using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MsMessageQueue
{//http://www.cnblogs.com/sk-net/archive/2011/11/25/2232341.html
    public partial class Form1 : Form
    {
        private MsgQueue m_MsgQueue;
        public Form1()
        {
            InitializeComponent();
            m_MsgQueue = new MsgQueue();
            m_MsgQueue.Purge();
        }

        private void btnCreateMQ_Click(object sender, EventArgs e)
        {
            m_MsgQueue.CreateQueue(this.txtQueueName.Text.Trim());           
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            m_MsgQueue.SendMessage(new Book
            {
                BookId = this.txtBookNO.Text.Trim(),
                BookName = this.txtBookName.Text.Trim(),
                BookAuthor = this.txtBookAuther.Text.Trim(),
                BookPrice = this.txtBookPrice.Text.Trim()
            }, typeof(MsMessageQueue.Book));
        }

       

        private void btnSendMessage2_Click(object sender, EventArgs e)
        {
            m_MsgQueue.SendMessage(new Person
            {
                Name = this.txtName.Text.Trim(),
                Sex = this.txtSex.Text.Trim()
            }, typeof(MsMessageQueue.Person));
        }
        private void btnAcceptMessage_Click(object sender, EventArgs e)
        {
            this.txtMessageList.Text += m_MsgQueue.ReceiveMessageBook() + System.Environment.NewLine;//ok

            ////error
            //Book book = m_MsgQueue.ReceiveMessage(typeof(MSMQ.Book)) as Book;
            //this.txtMessageList.Text += string.Format("编号：{0},书名：{1},作者：{2},定价：{3}",
            //        book.BookId,
            //        book.BookName,
            //        book.BookAuthor,
            //        book.BookPrice);
        }
        private void btnAcceptMessage2_Click(object sender, EventArgs e)
        {
            this.txtMessageList2.Text += m_MsgQueue.ReceiveMessagePerson() + System.Environment.NewLine;//ok
                        
            ////error
            //Person person = m_MsgQueue.ReceiveMessage(typeof(MSMQ.Person)) as Person;
            //this.txtMessageList2.Text += string.Format("姓名：{0},性别：{1}",
            //        person.Name,
            //        person.Sex);
        }
    }
}
