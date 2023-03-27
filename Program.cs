// See https://aka.ms/new-console-template for more information

using modul06_1302213116;

SayaTubeUser obj = new SayaTubeUser("Fasya Raihan Maulana");

obj.AddVideo(new SayaTubeVideo("Review Film Human Centipade oleh Fasya Raihan Maulana"));
obj.AddVideo(new SayaTubeVideo("Review Film SAW 1 oleh Fasya Raihan Maulana"));
obj.AddVideo(new SayaTubeVideo("Review Film SAW 2 oleh Fasya Raihan Maulana"));
obj.AddVideo(new SayaTubeVideo("Review Film SAW 3 oleh Fasya Raihan Maulana"));
obj.AddVideo(new SayaTubeVideo("Review Film SAW 4 oleh Fasya Raihan Maulana"));
obj.AddVideo(new SayaTubeVideo("Review Film SAW 5 oleh Fasya Raihan Maulana"));
obj.AddVideo(new SayaTubeVideo("Review Film Final Destination 1 oleh Fasya Raihan Maulana"));
obj.AddVideo(new SayaTubeVideo("Review Film Final Destination 2 oleh Fasya Raihan Maulana"));
obj.AddVideo(new SayaTubeVideo("Review Film Final Destination 3 oleh Fasya Raihan Maulana"));
obj.AddVideo(new SayaTubeVideo("Review Film Final Destination 4 oleh Fasya Raihan Maulana"));

List<SayaTubeVideo> objListVideo = objListVideo = obj.GetVideoList();

objListVideo[0].IncreasePlayCount(1123);
objListVideo[1].IncreasePlayCount(123);
objListVideo[3].IncreasePlayCount(43646);


Console.WriteLine("Total Semua Play Count : "+ obj.GetTotalVideoPlayCount()+"\n");

obj.PrintAllVideoPlayCount();