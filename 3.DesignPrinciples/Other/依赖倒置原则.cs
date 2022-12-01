using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 依赖倒置原则
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 需求: 歌手唱不同国家的歌曲
            // 对象 -> 歌手
            // 对象 -> 歌曲

            Singer singer = new Singer();
            singer.SingASong(new EnglishSong());
            singer.SingASong(new ChineseSong());

            Console.ReadKey();
        }

        public interface IASong
        {
            string ASong();
        }

        public class EnglishSong : IASong
        {
            public string ASong()
            {
                return "一首英文歌";
            }
        }

        public class ChineseSong : IASong
        {
            public string ASong()
            {
                return "一首中文歌";
            }
        }

        public class Singer
        {
            public void SingASong(IASong song)
            {
                Console.WriteLine("歌手正在唱" + song.ASong());
            }
        }
    }
}
