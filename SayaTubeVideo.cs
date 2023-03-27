using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul06_1302213116
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int PlayCount;

        public SayaTubeVideo(string title)
        {
            this.title = title;
            Random random = new Random();
            id = random.Next(10000, 99999);
            PlayCount = 0;
        }

        public int getPlayCount() { return PlayCount; }

        public string getTitle() { return title; }

        public void IncreasePlayCount(int PlayCount)
        {
            this.PlayCount = PlayCount;
        }

        public void PrintVideoDetails() {
            Console.WriteLine
                ($"id\t\t: {id}\n" +
                $"title\t\t: {title}\n" +
                $"PlayCount\t: {PlayCount}\n"
                );
        }
    }
}
