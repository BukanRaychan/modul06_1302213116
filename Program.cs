// See https://aka.ms/new-console-template for more information

using modul06_1302213116;

namespace modul06_1302213116
{
    internal class Program
    {
        static void Main(String[] args)
        {
            try
            {
                SayaTubeUser obj = new SayaTubeUser("Fasya");

                obj.AddVideo(new SayaTubeVideo("Review Film Human Centipade oleh Fasya Raihan Maulana"));
                obj.AddVideo(new SayaTubeVideo("Review Film SAW 1 oleh Fasya Raihan Maulana"));
                obj.AddVideo(new SayaTubeVideo("Review Film SAW 2 oleh Fasya Raihan Maulana"));
                obj.AddVideo(new SayaTubeVideo("Review Film SAW 3 oleh Fasya Raihan Maulana"));
                obj.AddVideo(new SayaTubeVideo("Review Film SAW 4 oleh Fasya Raihan Maulana"));
                obj.AddVideo(new SayaTubeVideo("Review Film SAW 5 oleh Fasya Raihan Maulana"));
                obj.AddVideo(new SayaTubeVideo("Review Film Final Destination 1 oleh Fasya Raihan Maulana"));
               /* obj.AddVideo(new SayaTubeVideo("Review Film Final Destination 2 oleh Fasya Raihan Maulana"));
                obj.AddVideo(new SayaTubeVideo("Review Film Final Destination 3 oleh Fasya Raihan Maulana"));
                obj.AddVideo(new SayaTubeVideo("Review Film Final Destination 4 oleh Fasya Raihan Maulana"));*/

                List<SayaTubeVideo> objListVideo = objListVideo = obj.GetVideoList();

                objListVideo[0].IncreasePlayCount(1123);
                objListVideo[1].IncreasePlayCount(123);
                objListVideo[3].IncreasePlayCount(43646);

                
                    objListVideo[4].IncreasePlayCount(int.MaxValue);
                

                Console.WriteLine("Total Semua Play Count : " + obj.GetTotalVideoPlayCount() + "\n");

                obj.PrintAllVideoPlayCount();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}



