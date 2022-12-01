using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 开放封闭原则
{
    internal class Program
    {
        // 需求: 描述不同需求的用户去银行办理不同的业务

        static void Main(string[] args)
        {
            // 1.在这段程序中,会出现多少个对象?
            // 2.每个对象的属性和行为

            // 对象1:用户: 属性: 记录不同类型的用户(存钱, 取钱, 转账......)
            // 对象2.银行柜员:帮助我们用户处理不同的需求
            // 对象3.银行业务系统:处理存钱,取钱,转账等需求的操作系统

            BankClient client = new BankClient();
            client.BankType = "取款";

            BankStuff bankStuff = new BankStuff();
            bankStuff.HandleProcess(client);
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
                    bankProcess.Deposite();
                    break;
                case "取款":
                    bankProcess.DrawMoney();
                    break;
                case "转账":
                    bankProcess.Transfer();
                    break;
                default:
                    Console.WriteLine("我们无法处理该业务");
                    break;
            }
        }
    }

    public class BankProcess
    {
        /// <summary>
        /// 存钱
        /// </summary>
        public void Deposite()
        {
            Console.WriteLine("处理客户存钱");
        }

        /// <summary>
        /// 取钱
        /// </summary>
        public void DrawMoney()
        {
            Console.WriteLine("处理用户取钱");
        }

        /// <summary>
        /// 转账
        /// </summary>
        public void Transfer()
        {
            Console.WriteLine("处理用户的转账");
        }
    }
}
