using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Messaging;

namespace MsMessageQueue
{
   public class MsgQueue
    {//https://msdn.microsoft.com/zh-cn/library/system.messaging.messagequeue(v=vs.100).aspx
        /// <summary>
        /// 通过Create方法创建使用指定路径的新消息队列 
        /// </summary>
        /// <param name="queuePath"></param>
        public void CreateQueue(string queuePath)
        {
            ////本机消息队列  
            ///*公共队列，消息队列名为myQueue*/  
            //./ myQueue
            ///*专用队列，消息队列名为myQueue*/
            //./private$/myQueue
            ///*Format格式，计算机名为zhang，消息队列名为myQueue*/
            //FormatName:DIRECT=OS:zhang/Private$/myQueue
            ////远程消息队列  
            ///*配置为Ip为192.168.101.130的服务器的专用消息队列，队列名为myQueue*/
            //FormatName:DIRECT=TCP:192.168.101.130/Private$/myQueue

            try
            {
                if (!MessageQueue.Exists(queuePath))
                {
                    MessageQueue.Create(@".\private$\myQueue");
                    MessageBox.Show("创建队列成功！");
                }
                else 
                {
                    MessageBox.Show(queuePath + "已经存在！");
                }
            }
            catch (MessageQueueException e)
            {
                MessageBox.Show(e.Message);
            }
        }
        /// <summary>
        /// 连接消息队列并发送消息到队列  
        /// </summary>
        /// <param name="queuePath"></param>
        public bool SendMessage(object o,Type t)
        {
            
            bool flag = false;
            try
            {
                MessageQueue myQueue = new MessageQueue(".\\private$\\myQueue");
                
                System.Messaging.Message myMessage = new System.Messaging.Message();
                myMessage.Body = o;
                myMessage.Formatter = new XmlMessageFormatter(new Type[] { t });
                myQueue.Send(myMessage);
                flag = true; 
            }
            catch (MessageQueueException e)
            {
                MessageBox.Show(e.Message);
            }
            return flag;
        }
        
        /// <summary>
        /// 连接消息队列并从队列中接收消息 
        /// </summary>
        /// <param name="queuePath"></param>
        public string ReceiveMessageBook()
        {
            //连接到本地队列
            MessageQueue myQueue = new MessageQueue(".\\private$\\myQueue");
            myQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(MsMessageQueue.Book) });
            try
            {
                //从队列中接收消息  MessageQueueTransactionType.None#
                MessageQueueTransaction m = new MessageQueueTransaction();               
                System.Messaging.Message myMessage = myQueue.Receive();
                Book book = (Book)myMessage.Body; //获取消息的内容 
                return string.Format("编号：{0},书名：{1},作者：{2},定价：{3}",
                    book.BookId,
                    book.BookName,
                    book.BookAuthor,
                    book.BookPrice);
            }
            catch (MessageQueueException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (InvalidCastException e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }
        public string ReceiveMessagePerson()
        {
            //连接到本地队列
            MessageQueue myQueue = new MessageQueue(".\\private$\\myQueue");
            myQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(MsMessageQueue.Person) });
            try
            {
                //从队列中接收消息 
                System.Messaging.Message myMessage = myQueue.Receive();
                Person person = (Person)myMessage.Body; //获取消息的内容 
                return string.Format("姓名：{0},性别：{1}",
                    person.Name,
                    person.Sex);
            }
            catch (MessageQueueException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (InvalidCastException e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }
        public object ReceiveMessage(Type t)
        {
            //连接到本地队列
            MessageQueue myQueue = new MessageQueue(".\\private$\\myQueue");
            myQueue.Formatter = new XmlMessageFormatter(new Type[] { t });
            try
            {
                //从队列中接收消息 
                System.Messaging.Message myMessage = myQueue.Receive();
                return myMessage.Body; //获取消息的内容                
            }
            catch (MessageQueueException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (InvalidCastException e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }
        public void Purge()
        {
            MessageQueue myQueue = new MessageQueue(".\\private$\\myQueue");
            myQueue.Purge();
        }
    }
}
