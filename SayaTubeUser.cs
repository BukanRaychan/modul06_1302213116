using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul06_1302213116
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;


        public SayaTubeUser(string Username)
        {
            Random random = new Random();
            id = random.Next(10000, 99999);
            this.Username = Username;
            uploadedVideos = new List<SayaTubeVideo>();
        }

        public List<SayaTubeVideo> GetVideoList() {
            return uploadedVideos;
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach(SayaTubeVideo video in uploadedVideos)
            {
                total += video.getPlayCount();
            }
            return total;
        }

        public void AddVideo(SayaTubeVideo newVideo)
        {
            uploadedVideos.Add(newVideo);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine($"User\t\t: {Username}");

            for(int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine($"Video {i+1} judul\t: {uploadedVideos[i].getTitle()}");
            }
        }

    }
}
