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
    class TestMessage
    {
        static void Main(string[] args)
        {
            Message m1 = new Message();

            m1.setMessageNumber("M42");
            m1.setMessageTime("July 11, 2012 10:45 PM");
            m1.setMessageTape("Tape 3");

            Console.WriteLine(m1.saveMessage());
            Console.ReadLine();

            Console.WriteLine(m1.playMessage());
            Console.ReadLine();

            Console.WriteLine(m1.deleteMessage());
            Console.ReadLine();
        }//end static void main
    }//end class TestMessage
}//end namespace HW2-3_EKF
