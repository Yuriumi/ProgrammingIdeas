using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 开放封闭原则_调整1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankClient client = new BankClient();
            client.BankType = "取款";

            BankStuff bankStuff = new BankStuff();
            bankStuff.HandleProcess(client);

            Console.ReadKey();
        }
    }

    public class BankClient
    {
        public string BankType { get; set; }
    }

    public class BankStuff
    {
        private BankProcess bankProcess = new BankProcess();

        public void HandleProcess(BankClient bankClient)
        {
            // TODO: 调用银行业务系统,处理用户请求
            switch (bankClient.BankType)
            {
                case "存款":
                    bankProcess.Deposite = new DeposizeClass();
                    bankProcess.DepositeFuc();
                    break;
                case "取款":
                    bankProcess.DrawMoney = new DrawMoneyClass();
                    bankProcess.DrawMoneyFuc();
                    break;
                case "转账":
                    bankProcess.Transfer = new TransferClass();
                    bankProcess.TransferFuc();
                    break;
                default:
                    Console.WriteLine("我们无法处理该业务");
                    break;
            }
        }
    }

    public class BankProcess
    {
        public IDeposite Deposite { get; set; }
        public IDrawMoney DrawMoney { get; set; }
        public ITransfer Transfer { get; set; }

        public void DepositeFuc()
        {
            Deposite.DepositeInterface();
        }

        public void DrawMoneyFuc()
        {
            DrawMoney.DrawMoneyInterface();
        }

        public void TransferFuc()
        {
            Transfer.TransferInterface();
        }
    }

    // 1.抽取接口
    // 2.在BankProcess中进行调用

    public interface IDeposite
    {
        void DepositeInterface();
    }

    public interface IDrawMoney
    {
        void DrawMoneyInterface();
    }

    public class DeposizeClass : IDeposite
    {
        public void DepositeInterface()
        {
            Console.WriteLine("处理用户存款");
        }
    }

    public class DrawMoneyClass : IDrawMoney
    {
        public void DrawMoneyInterface()
        {
            Console.WriteLine("处理用户取款");
        }
    }

    public interface ITransfer
    {
        void TransferInterface();
    }

    public class TransferClass : ITransfer
    {
        public void TransferInterface()
        {
            Console.WriteLine("处理客户转账");
        }
    }
}
