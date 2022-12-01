using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 开放封闭原则_调整2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 在类中,将每一个方法都进行接口抽象,也比较极端.所以,还是根据实际的业务情况,减少接口的封装(根据业务,进行高度抽象封装)

            BankClient client = new BankClient();
            client.BankType = "转账";

            BankStuff bankStuff = new BankStuff();
            bankStuff.HandleProcess(client);

            Console.ReadKey();
        }
    }

    public interface IBankProcess
    {
        void BankProcess();
    }

    public class DepositeClass : IBankProcess
    {
        public void BankProcess()
        {
            Console.WriteLine("处理用户存钱");
        }
    }
    
    public class DrawMoneyClass : IBankProcess
    {
        public void BankProcess()
        {
            Console.WriteLine("处理用户取钱");
        }
    }
    
    public class TransferClass : IBankProcess
    {
        public void BankProcess()
        {
            Console.WriteLine("处理用户转账");
        }
    }

    public class BankClient
    {
        public string BankType { get; set; }
    }

    public class BankStuff
    {
        private IBankProcess _bankProcess;

        public void HandleProcess(BankClient bankClient)
        {
            // TODO: 调用银行业务系统,处理用户请求
            switch (bankClient.BankType)
            {
                case "存款":
                    _bankProcess = new DepositeClass();
                    _bankProcess.BankProcess();
                    break;
                case "取款":
                    _bankProcess = new DrawMoneyClass();
                    _bankProcess.BankProcess();
                    break;
                case "转账":
                    _bankProcess = new TransferClass();
                    _bankProcess.BankProcess();
                    break;
                default:
                    Console.WriteLine("我们无法处理该业务");
                    break;
            }
        }
    }
}
