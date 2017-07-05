using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**************************************
 * Name: Elisabeth Feeley
 * Date: 7/11/2012
 * Assignment: HW2-3_EKF (Message)
 * Resources: N/A
 * ***********************************/

namespace HW2_3_EKF
{
    class Message
    {
        //Attributes
        private string messageTape, messageTime, messageNumber;

        //Methods
        public string deleteMessage()
        {
            return "You have deleted: " + getMessageNumber() + " from " + getMessageTape();
        }

        public string saveMessage()
        {
            return getMessageNumber() + " recieved on " + getMessageTime() + " has been saved on " + getMessageTape();
        }

        public string playMessage()
        {
            return "Playing message number " + getMessageNumber() + " recieved on " + getMessageTime();
        }

        //Gets
        public string getMessageTape()
        {
            return messageTape;
        }
        public string getMessageTime()
        {
            return messageTime;
        }
        public string getMessageNumber()
        {
            return messageNumber;
        }

        //Sets
        public void setMessageTape(string aMessageTape)
        {
            messageTape = aMessageTape;
        }
        public void setMessageTime(string aMessageTime)
        {
            messageTime = aMessageTime;
        }
        public void setMessageNumber(string aMessageNumber)
        {
            messageNumber = aMessageNumber;
        }

    }//end class Message
}//end namespace HW2-3_EKF
