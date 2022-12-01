using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单一职责原则
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }


    // 变化一: 内部的变化,如果TelPhone内部的方法,任意之一,放生了改变,都要修改TelPhone,不符合单一职责原则
    // 变化二: 外部的变化,如果TelPhone要添加新的方法,也许需要修改TelPhone

    #region 不符合单一职责原则
    //class TelPhone
    //{
    //    public void Dial(string phone_number)
    //    {
    //        Console.WriteLine("给" + phone_number + "打电话.");
    //    }

    //    public void HongUp(string phone_number)
    //    {
    //        Console.WriteLine("挂断" + phone_number + "电话.");
    //    }

    //    public void SendMessage(string message)
    //    {
    //        Console.WriteLine("发送" + message);
    //    }

    //    public void ReciveMessage(string message)
    //    {
    //        Console.WriteLine("接受" + message);
    //    }
    //}
    #endregion

    // 明确需求: 我们希望,有且只有一个(添加功能),引起TelPhone变化的原因
    // 思路: 给每一个方法,都提炼成一个接口,抽象成一种能力,然后分别写类,去实现接口,最终在TelPhone中,只进行调用

    public interface IDial
    {
        void DialNumver(string phone_number);
    }

    public interface IHangUp
    {
        void HangUpNumber(string phone_number);
    }

    public interface ISendMessage
    {
        void SendMessage(string message);
    }

    public interface IReciveMessage
    {
        void ReciveMessage(string message);
    }

    public class Dial : IDial
    {
        public void DialNumver(string phone_number)
        {
            Console.WriteLine("给" + phone_number + "打电话.");
        }
    }

    public class HangUp : IHangUp
    {
        public void HangUpNumber(string phone_number)
        {
            Console.WriteLine("挂断" + phone_number + "电话.");
        }
    }

    public class SendMessage : ISendMessage
    {
        void ISendMessage.SendMessage(string message)
        {
            Console.WriteLine("发送" + message);
        }
    }

    public class ReciveMessage : IReciveMessage
    {
        void IReciveMessage.ReciveMessage(string message)
        {
            Console.WriteLine("接受" + message);
        }
    }

    // 新需求: 添加PowerOn,PowerDown

    public interface IPowerOn
    {
        void PowerOn();
    }

    public interface IPowerOff
    {
        void PowerOff();
    }

    public class TelPhone
    {
        private IDial _idial;
        private IHangUp _ihangUp;
        private ISendMessage _isendMessage;
        private IReciveMessage _ireciveMessage;
        private IPowerOn _ipowerOn;
        private IPowerOff _ipowerOff;

        public void PowerOn()
        {
            _ipowerOn.PowerOn();
        }

        public void PowerOff()
        {
            _ipowerOff.PowerOff();
        }

        public void DiaIPhoneNumber(string phone_number)
        {
            // 调用接口提供的方法
            _idial.DialNumver(phone_number);
        }

        public void HangUp(string phone_number)
        {
            _ihangUp.HangUpNumber(phone_number);
        }

        public void SendMessage(string message)
        {
            _isendMessage.SendMessage(message);
        }

        public void ReciveMessage(string message)
        {
            _ireciveMessage.ReciveMessage(message);
        }
    }
}
